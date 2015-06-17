using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Decks.HallOfBeorn;
using HallOfBeorn.Models.Decks.TalesFromTheCards;
using HallOfBeorn.Models.Products;

namespace HallOfBeorn.Services
{
    public class SearchService
    {
        public SearchService(ProductRepository productRepository, CardRepository cardRepository, ScenarioService scenarioService)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            this.scenarioService = scenarioService;

            this.cards = cardRepository.Cards();
        }

        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;
        private readonly IEnumerable<Card> cards;        

        const int MAX_RESULTS = 128;

        private Func<CardScore, bool> NegateFilter(Func<CardScore, bool> predicate)
        {
            return (score) => { return !predicate(score); };
        }

        private List<CardScore> FilterByByte(string typeName, string value, List<CardScore> results, bool negate)
        {
            //Params: card value, filter values. returns bool
            Func<byte, List<byte>, bool> comparison = null;

            if (value.StartsWith(">"))
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue >  f); };
            }
            else if (value.StartsWith("<"))
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue < f); };
            }
            else if (value.Contains("-"))
            {
                comparison = (cardValue, filters) => {
                    if (filters.Count != 2 || filters[0] > filters[1])
                        return false;

                    return cardValue >= filters[0] && cardValue <= filters[1];
                };
            }
            else
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue == f); };
            }

            value = value.TrimStart('>', '<').Replace("-", ",");

            var tokens = value.SplitOnComma();

            var bytes = new List<byte>();

            foreach (var token in tokens)
            {
                var item = (byte)0;
                if (byte.TryParse(token, out item))
                {
                    bytes.Add(item);
                }
            }

            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "rcost":
                    predicate = (score) => { return score.Card.ResourceCost.HasValue && comparison(score.Card.ResourceCost.Value, bytes); };
                    break;
                case "tcost":
                    predicate = (score) => { return score.Card.ThreatCost.HasValue && comparison(score.Card.ThreatCost.Value, bytes); };
                    break;
                case "ecost":
                    predicate = (score) => { return score.Card.EngagementCost.HasValue && comparison(score.Card.EngagementCost.Value, bytes); };
                    break;
                case "threat":
                    predicate = (score) => { return score.Card.Threat.HasValue && comparison(score.Card.Threat.Value, bytes); };
                    break;
                case "wp":
                    predicate = (score) => { return score.Card.Willpower.HasValue && comparison(score.Card.Willpower.Value, bytes); };
                    break;
                case "qp":
                    predicate = (score) => { return score.Card.QuestPoints.HasValue && comparison(score.Card.QuestPoints.Value, bytes); };
                    break;
                case "atk":
                    predicate = (score) => { return score.Card.Attack.HasValue && comparison(score.Card.Attack.Value, bytes); };
                    break;
                case "def":
                    predicate = (score) => { return score.Card.Defense.HasValue && comparison(score.Card.Defense.Value, bytes); };
                    break;
                case "hp":
                    predicate = (score) => { return score.Card.HitPoints.HasValue && comparison(score.Card.HitPoints.Value, bytes); };
                    break;
                case "victory":
                    predicate = (score) => { return comparison(score.Card.VictoryPoints, bytes); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByString(string typeName, string value, List<CardScore> results, bool negate)
        {
            var names = value.SplitOnComma().Select(x => x.Replace('+', ' ').Replace('_', ' ')).ToList();
            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "title":
                    predicate = (score) => { return names.Any(y => score.Card.Title.MatchesWildcard(y)); };
                    break;
                case "cycle":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Cycle.MatchesWildcard(y)); };
                    break;
                case "set":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Name.MatchesWildcard(y) || score.Card.CardSet.Abbreviation.MatchesWildcard(y) || (!string.IsNullOrEmpty(score.Card.CardSet.AlternateName) && score.Card.CardSet.AlternateName.MatchesWildcard(y)) || (!string.IsNullOrEmpty(score.Card.CardSet.NormalizedName) && score.Card.CardSet.NormalizedName.MatchesWildcard(y))); };
                    break;
                case "product":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Product != null && (score.Card.CardSet.Product.Name.Replace(":",string.Empty).MatchesWildcard(y))); };
                    break;
                case "encounter":
                    predicate = (score) => { return names.Any(y => score.Card.EncounterSet.MatchesWildcard(y)); };
                    break;
                case "trait":
                    predicate = (score) => { return names.Any(y => score.Card.Traits.Select(z => z.Trim(' ','.')).Any(a => a.MatchesWildcard(y)) || score.Card.NormalizedTraits.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y))); };
                    break;
                case "keyword":
                    predicate = (score) => { return names.Any(y => score.Card.Keywords.Select(z => z.Trim(' ','.')).Any(a => a.MatchesWildcard(y)) || score.Card.NormalizedKeywords.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y))); };
                    break;
                case "artist":
                    predicate = (score) => { return names.Any(y => (score.Card.Artist != null && score.Card.Artist.Name.MatchesWildcard(y)) || (score.Card.SecondArtist != null && score.Card.SecondArtist.Name.MatchesWildcard(y))); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByBool(string typeName, List<CardScore> results, bool negate)
        {
            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "unique":
                    predicate = (score) => { return score.Card.IsUnique; };
                    break;
                case "custom":
                    predicate = (score) => { return score.Card.CardSet.SetType == SetType.CUSTOM; };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByEnum<TEnum>(string value, List<CardScore> results, bool negate)
            where TEnum: struct
        {
            var tokens = value.SplitOnComma();

            var enums = new List<TEnum>();

            foreach (var token in tokens)
            {
                var parsedItem = token.ParseEnum<TEnum>();
                if (parsedItem.Item2)
                {
                    enums.Add(parsedItem.Item1);
                }
            }

            var typeName = typeof(TEnum).Name.ToLowerSafe();
            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "cardtype":
                    predicate = (score) => { return enums.Any(y => y.ToEnum<CardType>() == score.Card.CardType); };
                    break;
                case "sphere":
                    predicate = (score) => { return enums.Any(y => y.ToEnum<Sphere>() == score.Card.Sphere); };
                    break;
                case "category":
                    predicate = (score) => { return enums.Any(y => score.Card.Categories.Any(z => y.ToEnum<Category>() == z)); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> AdvancedSearch(SearchViewModel searchModel, List<CardScore> results)
        {
            var query = searchModel.Query;
            var filters = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => x.StartsWith("-") || x.StartsWith("+")).ToListSafe();

            foreach (var filter in filters)
            {
                var fields = filter.Split(new char[] { ':', '=' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();

                if (fields.Count == 0 || string.IsNullOrEmpty(fields[0]))
                    continue;

                var negate = (fields[0][0] == '-');
                var field = fields[0].ToLower().Trim('-', '+');
                var value = string.Empty;

                if (fields.Count > 1)
                {
                    value = fields[1];
                }

                switch (field)
                {
                    case "title":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "cycle":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "set":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "product":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "type":
                        results = FilterByEnum<CardType>(value, results, negate);
                        break;
                    case "sphere":
                        results = FilterByEnum<Sphere>(value, results, negate);
                        break;
                    case "rcost":
                    case "tcost":
                    case "ecost":
                    case "threat":
                    case "wp":
                    case "atk":
                    case "def":
                    case "hp":
                        results = FilterByByte(field, value, results, negate);
                        break;
                    case "trait":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "keyword":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "encounter":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "artist":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "category":
                        results = FilterByEnum<Category>(value, results, negate);
                        break;
                    case "victory":
                        results = FilterByByte(field, value, results, negate);
                        break;
                    case "unique":
                        results = FilterByBool(field, results, negate);
                        break;
                    case "custom":
                        results = FilterByBool(field, results, negate);
                        if (!negate)
                        {
                            searchModel.Custom = true;
                        }
                        break;
                    default:
                        break;
                }
            }

            return results;
        }

        public IEnumerable<Card> All()
        {
            return cards;
        }

        public Card Find(string id)
        {
            return cards.Where(x => x.Id == id).FirstOrDefault();
        }

        public Card FindBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return null;

            var exact = cards.Where(x => x.Slug.ToLower() == slug.ToLower()).FirstOrDefault();
            if (exact != null)
                return exact;

            var partials = cards.Where(x => x.Slug.ToLower().StartsWith(slug.ToLower())).ToList();
            if (partials.Count == 1)
                return partials.First();

            return null;
        }

        public IEnumerable<CardScore> Search(SearchViewModel model)
        {
            var filters = new List<WeightedSearchFilter>();
            var results = new Dictionary<string, CardScore>();

            if (model.HasQuery() && !string.IsNullOrEmpty(model.BasicQuery()))
            {
                var queryFilters = new List<WeightedSearchFilter>();
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Title.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.NormalizedTitle.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Title.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.NormalizedTitle.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Title.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.NormalizedTitle.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Text.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.OppositeText.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Equals(s.BasicQuery())); }, 115, "Keyword matches '" + model.Query + "'"));
                queryFilters.Add(new WeightedSearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Contains(s.BasicQuery())); }, 110, "Keyword contains '" + model.Query + "'"));
                filters.Add(new WeightedSearchFilter(queryFilters));
            }

            if (model.HasCardType())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.CardTypeMatches(c); }, 100, "Card Type matches '" + model.CardType.ToEnumDisplayString() + "'"));

            if (model.HasCardSubtype())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.CardSubtype == c.CardSubtype; }, 100, "Card Subtype matches '" + model.CardSubtype.ToEnumDisplayString() + "'"));

            if (model.HasDeckType())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.DeckType == c.GetDeckType(); }, 100, "Deck Type matches '" + model.DeckType.ToEnumDisplayString() + "'"));

            if (model.HasCardSet())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.CardSetMatches(c); }, 100, "Card Set matches '" + model.CardSet + "'"));

            if (model.HasScenario())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.BelongsToScenario(scenarioService.GetScenario(s.Scenario.ToUrlSafeString())); }, 100, "Scenario matches '" + model.Scenario + "'"));

            if (model.HasTrait())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.HasTrait(s.Trait); }, 100, "Has Trait '" + model.Trait + "'"));

            if (model.HasKeyword())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.HasKeyword(s.Keyword); }, 100, "Has Keyword '" + model.Trait + "'"));
            
            if (model.HasSphere())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.Sphere == c.Sphere; }, 100, "Has Sphere '" + model.Sphere.ToEnumDisplayString() + "'"));

            if (model.HasCategory())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.Categories.Any(x => x == s.GetCategory()); }, 100, "Has Category '" + model.Category + "'"));

            if (model.HasEncounterCategory())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.EncounterCategories.Any(x => x == s.GetEncounterCategory()); }, 100, "Has Encounter Category '" + model.EncounterCategory + "'"));

            if (model.HasQuestCategory())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.QuestCategories.Any(x => x == s.GetQuestCategory()); }, 100, "Has Quest Category '" + model.QuestCategory + "'"));

            if (model.HasResourceCost())
            {
                if (model.Cost == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.ResourceCost.HasValue && c.ResourceCost.Value == byte.MaxValue; }, 100, "Cost is '-'"));
                }
                else if (model.Cost != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.ResourceCost.CompareTo(s.CostOperator, s.Cost); }, 100, "Cost " + model.CostOperator.ToEnumDisplayString() + " '" + model.Cost + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return s.Cost == c.ResourceCostLabel; }, 100, "Cost is 'X'"));
                }
            }

            if (model.Attack.IsDefinedFilter())
            {
                if (model.Attack == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value == byte.MaxValue; }, 100, "Attack is '-'"));
                }
                else if (model.Attack != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value != byte.MaxValue && c.Attack.CompareTo(s.AttackOp, s.Attack); }, 100, "Attack " + model.AttackOp.ToEnumDisplayString() + " '" + model.Attack + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value != byte.MaxValue && c.IsVariableAttack; }, 100, "Attack is 'X'"));
                } 
            }

            if (model.Defense.IsDefinedFilter())
            {
                if (model.Defense == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value == byte.MaxValue; }, 100, "Defense is '-'"));
                }
                else if (model.Defense != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value != byte.MaxValue && c.Defense.CompareTo(s.DefenseOp, s.Defense); }, 100, "Defense " + model.DefenseOp.ToEnumDisplayString() + " '" + model.Defense + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value != byte.MaxValue && c.IsVariableDefense; }, 100, "Defense is 'X'"));
                }
            }

            if (model.HitPoints.IsDefinedFilter())
            {
                if (model.HitPoints == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value == byte.MaxValue; }, 100, "Hit Points are '-'"));
                }
                else if (model.HitPoints != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value != byte.MaxValue && c.HitPoints.CompareTo(s.HitPointsOp, s.HitPoints); }, 100, "Hit Points " + model.HitPointsOp.ToEnumDisplayString() + " '" + model.HitPoints + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value != byte.MaxValue && c.IsVariableHitPoints; }, 100, "Hit Points are 'X'"));
                }
            }

            if (model.Willpower.IsDefinedFilter())
            {
                if (model.Willpower == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value == byte.MaxValue; }, 100, "Willpower is '-'"));
                }
                else if (model.Willpower != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value != byte.MaxValue && !c.IsVariableWillpower && c.Willpower.CompareTo(s.WillpowerOp, s.Willpower); }, 100, "Willpower " + model.WillpowerOp.ToEnumDisplayString() + " '" + model.Willpower + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value != byte.MaxValue && c.IsVariableWillpower; }, 100, "Willpower is 'X'"));
                }
            }

            if (model.Threat.IsDefinedFilter())
            {
                if (model.Threat == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value == byte.MaxValue; }, 100, "Threat is '-'"));
                }
                else if (model.Threat != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value != byte.MaxValue && !c.IsVariableThreat && c.Threat.CompareTo(s.ThreatOp, s.Threat); }, 100, "Threat " + model.ThreatOp.ToEnumDisplayString() + " '" + model.Threat + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value != byte.MaxValue && c.IsVariableThreat; }, 100, "Threat is 'X'"));
                }
            }

            if (model.QuestPoints.IsDefinedFilter())
            {
                if (model.QuestPoints == "-")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value == byte.MaxValue; }, 100, "Quest Points are '-'"));
                }
                else if (model.QuestPoints != "X")
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value != byte.MaxValue && !c.IsVariableQuestPoints && c.QuestPoints.CompareTo(s.QuestPointsOp, s.QuestPoints); }, 100, "Quest Points " + model.QuestPointsOp.ToEnumDisplayString() + " '" + model.QuestPoints + "'"));
                }
                else
                {
                    filters.Add(new WeightedSearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value != byte.MaxValue && c.IsVariableQuestPoints; }, 100, "Quest Points are 'X'"));
                }
            }

            if (model.HasThreatCost())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.ThreatCost.CompareTo(s.ThreatCostOperator, s.ThreatCost); }, 100, "Threat Cost" + model.ThreatCostOperator.ToEnumDisplayString() + " '" + model.ThreatCost + "'"));

            if (model.HasEngagementCost())
                filters.Add(new WeightedSearchFilter((s, c) => { return c.EngagementCost.CompareTo(s.EngagementCostOperator, s.EngagementCost); }, 100, "Engagement Cost" + model.EngagementCostOperator.ToEnumDisplayString() + " '" + model.EngagementCost + "'"));

            if (model.HasArtist())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.Artist == c.Artist.Name; }, 100, "Has Artist '" + model.Artist + "'"));

            if (model.HasEncounterSet())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.EncounterSet == c.EncounterSet; }, 100, "Has Encounter Set '" + model.EncounterSet + "'"));

            if (model.HasVictoryPoints())
                filters.Add(new WeightedSearchFilter((s, c) => { return s.VictoryPointsMatch(c); }, 100, "Has Victory Points '" + model.VictoryPoints + "'"));
            
            if (model.Unique)
                filters.Add(new WeightedSearchFilter((s, c) => { return c.IsUnique; }, 100, "Is Unique"));

            if (model.HasShadow != HasShadow.Any)
                filters.Add(new WeightedSearchFilter((s, c) => { return (s.HasShadow == HasShadow.Yes && !string.IsNullOrEmpty(c.Shadow) || s.HasShadow == HasShadow.No && string.IsNullOrEmpty(c.Shadow)); }, 50, model.HasShadow == HasShadow.Yes ? "Has Shadow Effect" : "Does Not Have Shadow Effect"));

            if (model.IsUnique != Uniqueness.Any)
                filters.Add(new WeightedSearchFilter((s, c) => { return (s.IsUnique == Uniqueness.Yes && c.IsUnique) || (s.IsUnique == Uniqueness.No && !c.IsUnique); }, 50, model.IsUnique == Uniqueness.Yes ? "Is Unique" : "Is Not Unique"));

            if (model.SetType != SetType.None)
                filters.Add(new WeightedSearchFilter((s, c) => { return (s.SetType == SetType.OFFICIAL && c.CardSet.SetType != SetType.CUSTOM) || (s.SetType == c.CardSet.SetType); }, 50, "Has Set Type '" + model.SetType + "'"));

            if (model.HasQuest())
            {
                var scenario = scenarioService.GetScenario(model.Quest.ToUrlSafeString());
                filters.Add(new WeightedSearchFilter((s, c) => 
                {
                    return !string.IsNullOrEmpty(c.EncounterSet) && 
                        scenario.QuestCards.Any(x => (x.Quest != null && x.Quest.EncounterSet != null && x.Quest.EncounterSet == c.EncounterSet) || (x.IncludedEncounterSets != null && x.IncludedEncounterSets.Any(y => y != null && y.Name == c.EncounterSet))); 
                }, 50, "Has Quest '" + model.Quest + "'"));
            }

            if (filters.Count > 0)
            {
                foreach (var card in cards)
                {
                    foreach (var filter in filters)
                    {
                        var score = filter.Score(model, card);
                        
                        if (results.ContainsKey(card.Slug))
                        {
                            results[card.Slug].Description += " and " + filter.Description(model, card);

                            var existing = results[card.Slug].Score;
                            if (score == 0 || existing > 0 && score > existing)
                            {
                                results[card.Slug].Score = score;
                            }
                        }
                        else
                        {
                            results[card.Slug] = new CardScore(card, score, filter.Description(model, card));
                        }
                    }
                }
            }
            else if (!model.IsAdvancedSearch())
            {
                var setNames = cards.Select(x => x.CardSet.Name).Distinct().OrderBy(y => y).ToList();
                var sn = setNames;

                //If this is not an advanced search and there are no filters then return only the heroes from the Core Set
                foreach (var item in cards.Where(x => x.CardSet.Name == "Core Set" && x.Number < 13))
                {
                    results[item.Slug] = new CardScore(item, 13 - item.Number, string.Empty);
                }
            }
            else
            {
                foreach (var card in cards)
                {
                    results[card.Slug] = new CardScore(card, WeightedSearchFilter.WeightedScore(card, 1), string.Empty);
                }
            }

            if (!model.Custom && model.SetType != SetType.CUSTOM)
            {
                var official = new Dictionary<string, CardScore>();

                foreach (var score in results)
                {
                    if (!model.CardIsCustom(score.Value.Card))
                        official.Add(score.Key, score.Value);
                }

                results = official;
            }

            if (model.IsRandom())
            {
                var total = results.Count();
                if (total > 1)
                {
                    var random = new Random();
                    var choice = random.Next(0, total - 1);
                    var score = results.Values.ToList()[choice];
                    results = new Dictionary<string, CardScore>();
                    results[score.Card.Slug] = score;
                }
            }

            var takeCount = model.HasFilter() || model.IsRandom() ? results.Count : MAX_RESULTS;

            var sortedResults = new List<CardScore>();

            if (filters.Count == 1 && model.CardSet != null && model.CardSet != "Any" && model.Sort == Sort.None)
            {
                model.Sort = Sort.Set_Number;
            }

            switch (model.Sort)
            {
                case Sort.Alphabetical:
                    sortedResults = results.Where(x => x.Value.Score > 0).OrderBy(x => x.Value.Card.Title).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Sort.Sphere_Type_Cost:
                    sortedResults = results.Where(x => x.Value.Score > 0).OrderBy(x => x.Value.Card.Sphere).ThenBy(x => x.Value.Card.CardType).ThenBy(x =>
                    {
                        if (x.Value.Card.ThreatCost.HasValue && x.Value.Card.ThreatCost.Value > 0)
                            return x.Value.Card.ThreatCost.Value;
                        else if (x.Value.Card.ResourceCost.HasValue && x.Value.Card.ResourceCost.Value > 0)
                            return x.Value.Card.ResourceCost.Value;
                        else if (x.Value.Card.EngagementCost.HasValue && x.Value.Card.EngagementCost.Value > 0)
                            return x.Value.Card.EngagementCost.Value;
                        else if (x.Value.Card.QuestPoints.HasValue && x.Value.Card.QuestPoints > 0)
                            return x.Value.Card.QuestPoints.Value;
                        else
                            return -1;
                    }).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Sort.Set_Number:
                    sortedResults = results.Where(x => x.Value.Score > 0).OrderBy(x => x.Value.Card.CardSet.Number).ThenBy(x => x.Value.Card.Number).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                default:
                    sortedResults = results.Where(x => x.Value.Score > 0).OrderByDescending(x => x.Value.Score).Select(y => y.Value).Take(takeCount).ToList();
                    break;
            }

            if (model.IsAdvancedSearch())
            {
                sortedResults = AdvancedSearch(model, sortedResults);
            }

            return sortedResults;
        }
    }
}
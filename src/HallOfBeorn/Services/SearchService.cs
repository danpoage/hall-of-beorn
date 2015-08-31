using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Decks.HallOfBeorn;
using HallOfBeorn.Models.Decks.TalesFromTheCards;
using HallOfBeorn.Models.Products;
using HallOfBeorn.Models.Search;

namespace HallOfBeorn.Services
{
    public class SearchService
    {
        public SearchService(ProductRepository productRepository, CardRepository cardRepository, ScenarioService scenarioService, AdvancedSearchService advancedSearchService, SearchSortService sortService)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            this.scenarioService = scenarioService;
            this.advancedSearchService = advancedSearchService;
            this.sortService = sortService;
            this.cards = cardRepository.Cards();
        }

        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;
        private readonly AdvancedSearchService advancedSearchService;
        private readonly SearchSortService sortService;
        private readonly IEnumerable<Card> cards;

        public IEnumerable<CardScore> SearchNew(SearchViewModel model)
        {
            model.GetScenario = () => {
                return !string.IsNullOrEmpty(model.Scenario) ?
                scenarioService.GetScenario(model.Scenario.ToUrlSafeString())
                : null;
            };

            model.Initialize();

            var results = new Dictionary<string, CardScore>();
            var filters = model.Filters();

            if (filters.Count() == 0)
            {
                filters.Add(new SearchFilter((m, c) => { return c.CardSet != null && c.CardSet.Name == "Core Set" && c.CardType == CardType.Hero; }, 100f, 0f, "Default Search: Core Set Heroes", false));
            }

            foreach (var card in cards)
            {
                foreach (var filter in filters)
                {
                    var score = filter.Score(model, card);

                    if (results.ContainsKey(card.Slug))
                    {
                        results[card.Slug].Description += " and " + filter.Description(model, card);
                        results[card.Slug].AddScore(score);

                        /*
                        var existing = results[card.Slug].Score;
                        if (score == 0 || existing > 0 && score > existing)
                        {
                            results[card.Slug].Score = score;
                        }
                        */
                    }
                    else
                    {
                        results[card.Slug] = new CardScore(card, score, filter.Description(model, card));
                    }
                }
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

            var sortedResults = sortService.Sort(model, filters, results);

            if (model.IsAdvancedSearch())
            {
                sortedResults = advancedSearchService.Search(model, sortedResults);
            }

            return sortedResults;
        }

        public IEnumerable<CardScore> Search(SearchViewModel model)
        {
            var filters = new List<SearchFilter>();
            var results = new Dictionary<string, CardScore>();

            if (model.HasQuery() && !string.IsNullOrEmpty(model.BasicQuery()))
            {
                var queryFilters = new List<SearchFilter>();
                queryFilters.Add(new SearchFilter((s, c) => { return c.Title.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Title.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Title.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Text.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.OppositeText.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Equals(s.BasicQuery())); }, 115, "Keyword matches '" + model.Query + "'"));
                queryFilters.Add(new SearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Contains(s.BasicQuery())); }, 110, "Keyword contains '" + model.Query + "'"));
                filters.Add(new SearchFilter(queryFilters));
            }

            if (model.HasCardType())
                filters.Add(new SearchFilter((s, c) => { return s.CardTypeMatches(c); }, 100, "Card Type matches '" + model.CardType.ToEnumDisplayString() + "'"));

            if (model.HasCardSubtype())
                filters.Add(new SearchFilter((s, c) => { return s.CardSubtype == c.CardSubtype; }, 100, "Card Subtype matches '" + model.CardSubtype.ToEnumDisplayString() + "'"));

            if (model.HasDeckType())
                filters.Add(new SearchFilter((s, c) => { return s.DeckType == c.GetDeckType(); }, 100, "Deck Type matches '" + model.DeckType.ToEnumDisplayString() + "'"));

            if (model.HasCardSet())
                filters.Add(new SearchFilter((s, c) => { return s.CardSetMatches(c); }, 100, "Card Set matches '" + model.CardSet + "'"));

            if (model.HasScenario())
                filters.Add(new SearchFilter((s, c) => { return c.BelongsToScenario(scenarioService.GetScenario(s.Scenario.ToUrlSafeString())); }, 100, "Scenario matches '" + model.Scenario + "'"));

            if (model.HasTrait())
                filters.Add(new SearchFilter((s, c) => { return c.HasTrait(s.Trait); }, 100, "Has Trait '" + model.Trait + "'"));

            if (model.HasKeyword())
                filters.Add(new SearchFilter((s, c) => { return c.HasKeyword(s.Keyword); }, 100, "Has Keyword '" + model.Trait + "'"));
            
            if (model.HasSphere())
                filters.Add(new SearchFilter((s, c) => { return s.Sphere == c.Sphere; }, 100, "Has Sphere '" + model.Sphere.ToEnumDisplayString() + "'"));

            if (model.HasCategory())
                filters.Add(new SearchFilter((s, c) => { return c.Categories.Any(x => x == s.GetCategory()); }, 100, "Has Category '" + model.Category + "'"));

            if (model.HasEncounterCategory())
                filters.Add(new SearchFilter((s, c) => { return c.EncounterCategories.Any(x => x == s.GetEncounterCategory()); }, 100, "Has Encounter Category '" + model.EncounterCategory + "'"));

            if (model.HasQuestCategory())
                filters.Add(new SearchFilter((s, c) => { return c.QuestCategories.Any(x => x == s.GetQuestCategory()); }, 100, "Has Quest Category '" + model.QuestCategory + "'"));

            if (model.HasResourceCost())
            {
                if (model.Cost == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.ResourceCost.HasValue && c.ResourceCost.Value == byte.MaxValue; }, 100, "Cost is '-'"));
                }
                else if (model.Cost != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.ResourceCost.CompareTo(s.CostOperator, s.Cost); }, 100, "Cost " + model.CostOperator.ToEnumDisplayString() + " '" + model.Cost + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return s.Cost == c.ResourceCostLabel; }, 100, "Cost is 'X'"));
                }
            }

            if (model.Attack.IsDefinedFilter())
            {
                if (model.Attack == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value == byte.MaxValue; }, 100, "Attack is '-'"));
                }
                else if (model.Attack != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value != byte.MaxValue && c.Attack.CompareTo(s.AttackOp, s.Attack); }, 100, "Attack " + model.AttackOp.ToEnumDisplayString() + " '" + model.Attack + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Attack.HasValue && c.Attack.Value != byte.MaxValue && c.IsVariableAttack; }, 100, "Attack is 'X'"));
                } 
            }

            if (model.Defense.IsDefinedFilter())
            {
                if (model.Defense == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value == byte.MaxValue; }, 100, "Defense is '-'"));
                }
                else if (model.Defense != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value != byte.MaxValue && c.Defense.CompareTo(s.DefenseOp, s.Defense); }, 100, "Defense " + model.DefenseOp.ToEnumDisplayString() + " '" + model.Defense + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Defense.HasValue && c.Defense.Value != byte.MaxValue && c.IsVariableDefense; }, 100, "Defense is 'X'"));
                }
            }

            if (model.HitPoints.IsDefinedFilter())
            {
                if (model.HitPoints == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value == byte.MaxValue; }, 100, "Hit Points are '-'"));
                }
                else if (model.HitPoints != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value != byte.MaxValue && c.HitPoints.CompareTo(s.HitPointsOp, s.HitPoints); }, 100, "Hit Points " + model.HitPointsOp.ToEnumDisplayString() + " '" + model.HitPoints + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.HitPoints.HasValue && c.HitPoints.Value != byte.MaxValue && c.IsVariableHitPoints; }, 100, "Hit Points are 'X'"));
                }
            }

            if (model.Willpower.IsDefinedFilter())
            {
                if (model.Willpower == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value == byte.MaxValue; }, 100, "Willpower is '-'"));
                }
                else if (model.Willpower != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value != byte.MaxValue && !c.IsVariableWillpower && c.Willpower.CompareTo(s.WillpowerOp, s.Willpower); }, 100, "Willpower " + model.WillpowerOp.ToEnumDisplayString() + " '" + model.Willpower + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Willpower.HasValue && c.Willpower.Value != byte.MaxValue && c.IsVariableWillpower; }, 100, "Willpower is 'X'"));
                }
            }

            if (model.Threat.IsDefinedFilter())
            {
                if (model.Threat == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value == byte.MaxValue; }, 100, "Threat is '-'"));
                }
                else if (model.Threat != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value != byte.MaxValue && !c.IsVariableThreat && c.Threat.CompareTo(s.ThreatOp, s.Threat); }, 100, "Threat " + model.ThreatOp.ToEnumDisplayString() + " '" + model.Threat + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.Threat.HasValue && c.Threat.Value != byte.MaxValue && c.IsVariableThreat; }, 100, "Threat is 'X'"));
                }
            }

            if (model.QuestPoints.IsDefinedFilter())
            {
                if (model.QuestPoints == "-")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value == byte.MaxValue; }, 100, "Quest Points are '-'"));
                }
                else if (model.QuestPoints != "X")
                {
                    filters.Add(new SearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value != byte.MaxValue && !c.IsVariableQuestPoints && c.QuestPoints.CompareTo(s.QuestPointsOp, s.QuestPoints); }, 100, "Quest Points " + model.QuestPointsOp.ToEnumDisplayString() + " '" + model.QuestPoints + "'"));
                }
                else
                {
                    filters.Add(new SearchFilter((s, c) => { return c.QuestPoints.HasValue && c.QuestPoints.Value != byte.MaxValue && c.IsVariableQuestPoints; }, 100, "Quest Points are 'X'"));
                }
            }

            if (model.HasThreatCost())
                filters.Add(new SearchFilter((s, c) => { return c.ThreatCost.CompareTo(s.ThreatCostOperator, s.ThreatCost); }, 100, "Threat Cost" + model.ThreatCostOperator.ToEnumDisplayString() + " '" + model.ThreatCost + "'"));

            if (model.HasEngagementCost())
                filters.Add(new SearchFilter((s, c) => { return c.EngagementCost.CompareTo(s.EngagementCostOperator, s.EngagementCost); }, 100, "Engagement Cost" + model.EngagementCostOperator.ToEnumDisplayString() + " '" + model.EngagementCost + "'"));

            if (model.HasArtist())
                filters.Add(new SearchFilter((s, c) => { return s.Artist == c.Artist.Name; }, 100, "Has Artist '" + model.Artist + "'"));

            if (model.HasEncounterSet())
                filters.Add(new SearchFilter((s, c) => { return s.EncounterSet == c.EncounterSet; }, 100, "Has Encounter Set '" + model.EncounterSet + "'"));

            if (model.HasVictoryPoints())
                filters.Add(new SearchFilter((s, c) => { return s.VictoryPointsMatch(c); }, 100, "Has Victory Points '" + model.VictoryPoints + "'"));
            
            //if (model.Unique)
            //    filters.Add(new WeightedSearchFilter((s, c) => { return c.IsUnique; }, 100, "Is Unique"));

            if (model.HasShadow.HasValue && model.HasShadow.Value != HasShadow.Any)
                filters.Add(new SearchFilter((s, c) => { return (s.HasShadow == HasShadow.Yes && !string.IsNullOrEmpty(c.Shadow) || s.HasShadow == HasShadow.No && string.IsNullOrEmpty(c.Shadow)); }, 50, model.HasShadow == HasShadow.Yes ? "Has Shadow Effect" : "Does Not Have Shadow Effect"));

            if (model.IsUnique.HasValue && model.IsUnique.Value != Uniqueness.Any)
                filters.Add(new SearchFilter((s, c) => { return (s.IsUnique == Uniqueness.Yes && c.IsUnique) || (s.IsUnique == Uniqueness.No && !c.IsUnique); }, 50, model.IsUnique == Uniqueness.Yes ? "Is Unique" : "Is Not Unique"));

            if (model.HasQuest())
            {
                var scenario = scenarioService.GetScenario(model.Quest.ToUrlSafeString());
                filters.Add(new SearchFilter((s, c) => 
                {
                    return !string.IsNullOrEmpty(c.EncounterSet) && 
                        scenario.QuestCards.Any(x => (x.Quest != null && x.Quest.EncounterSet != null && x.Quest.EncounterSet == c.EncounterSet) || (x.IncludedEncounterSets != null && x.IncludedEncounterSets.Any(y => y != null && y.Name == c.EncounterSet))); 
                }, 50, "Has Quest '" + model.Quest + "'"));
            }

            if (model.SetType.HasValue && model.SetType.Value != SetType.None)
            {
                //var limit = 0;
                //&& model.SetType.Value == SetType.OFFICIAL
                filters.Add(new SearchFilter((s, c) => { return (s.SetType == SetType.OFFICIAL && c.CardSet.SetType != SetType.CUSTOM) || (s.SetType.Value == c.CardSet.SetType); }, 50f, 0f, "Has Set Type '" + model.SetType + "'"));
            }

            if (filters.Count == 0 && !model.IsAdvancedSearch())
            {
                //limit = 12;
                filters.Add(new SearchFilter((s, c) => { return (c.CardType == CardType.Hero && c.CardSet.Name == "Core Set"); }, 100f, "Default Search - Core Set Heroes"));
                //model.Sort = Sort.Set_Number;
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
                            results[card.Slug].AddScore(score);

                            /*
                            var existing = results[card.Slug].Score;
                            if (score == 0 || existing > 0 && score > existing)
                            {
                                results[card.Slug].Score = score;
                            }*/
                        }
                        else
                        {
                            results[card.Slug] = new CardScore(card, score, filter.Description(model, card));
                        }
                    }
                }
            }
            else
            {
                foreach (var card in cards)
                {
                    results[card.Slug] = new CardScore(card, SearchFilter.WeightedScore(card, 1), string.Empty);
                }
            }

            /*
            if (!model.IsAdvancedSearch() && isOfficialOnly)
            {
                //var setNames = cards.Select(x => x.CardSet.Name).Distinct().OrderBy(y => y).ToList();
                //var sn = setNames;

                //If this is not an advanced search and there are no filters then return only the heroes from the Core Set
                foreach (var item in cards.Where(x => x.CardSet.Name == "Core Set" && x.Number < 13))
                {
                    results[item.Slug] = new CardScore(item, 13 - item.Number, string.Empty);
                }
            }*/

            /*
            if (!model.Custom && model.SetType != SetType.CUSTOM)
            {
                var official = new Dictionary<string, CardScore>();

                foreach (var score in results)
                {
                    if (!model.CardIsCustom(score.Value.Card))
                        official.Add(score.Key, score.Value);
                }

                results = official;
            }*/

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

            var sortedResults = sortService.Sort(model, filters, results);

            if (model.IsAdvancedSearch())
            {
                sortedResults = advancedSearchService.Search(model, sortedResults);
            }

            return sortedResults;
        }
    }
}
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
        public SearchService(ProductRepository productRepository, CardRepository cardRepository, ScenarioService scenarioService, AdvancedSearchService advancedSearchService, SearchSortService sortService, RingsDbService ringsDbService)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            this.scenarioService = scenarioService;
            this.advancedSearchService = advancedSearchService;
            this.sortService = sortService;
            this.cards = cardRepository.Cards();
            this.ringsDbService = ringsDbService;
            this.getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
        }

        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;
        private readonly AdvancedSearchService advancedSearchService;
        private readonly SearchSortService sortService;
        private readonly IEnumerable<Card> cards;
        private readonly RingsDbService ringsDbService;
        private readonly Func<string, byte> getPopularity;

        private bool BelongsToScenario(Card card, string scenarioTitle)
        {
            if (string.IsNullOrEmpty(scenarioTitle))
            {
                return false;
            }

            var scenario = scenarioService.GetScenario(scenarioTitle.ToUrlSafeString());

            if (card.CardType == CardType.Quest)
            {
                return scenario.QuestCardIds().Any(x => x == card.Slug);
            }

            return scenario.ScenarioCards.Any(x => x.Card.Slug == card.Slug);

            /*
            if (scenario.Title == card.ScenarioTitle)
            {
                return true;
            }

            if (!string.IsNullOrEmpty(EncounterSet))
            {
                if (scenario.IncludesEncounterSet(EncounterSet))
                {
                    return true;
                }
            }
            */

            //return false;
        }

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

        private SearchFilter getProductFilter(SearchViewModel model)
        {
            var codes = new List<string>();

            if (model.MEC01.HasValue && model.MEC01.Value)
            {
                codes.Add("MEC01");
            }
            if (model.MEC02.HasValue && model.MEC02.Value)
            {
                codes.Add("MEC02");
            }
            if (model.MEC03.HasValue && model.MEC03.Value)
            {
                codes.Add("MEC03");
            }
            if (model.MEC04.HasValue && model.MEC04.Value)
            {
                codes.Add("MEC04");
            }
            if (model.MEC05.HasValue && model.MEC05.Value)
            {
                codes.Add("MEC05");
            }
            if (model.MEC06.HasValue && model.MEC06.Value)
            {
                codes.Add("MEC06");
            }
            if (model.MEC07.HasValue && model.MEC07.Value)
            {
                codes.Add("MEC07");
            }

            if (model.MEC08.HasValue && model.MEC08.Value)
            {
                codes.Add("MEC08");
            }
            if (model.MEC09.HasValue && model.MEC09.Value)
            {
                codes.Add("MEC09");
            }
            if (model.MEC10.HasValue && model.MEC10.Value)
            {
                codes.Add("MEC10");
            }
            if (model.MEC11.HasValue && model.MEC11.Value)
            {
                codes.Add("MEC11");
            }
            if (model.MEC12.HasValue && model.MEC12.Value)
            {
                codes.Add("MEC12");
            }
            if (model.MEC13.HasValue && model.MEC13.Value)
            {
                codes.Add("MEC13");
            }
            if (model.MEC14.HasValue && model.MEC14.Value)
            {
                codes.Add("MEC14");
            }

            if (model.MEC17.HasValue && model.MEC17.Value)
            {
                codes.Add("MEC17");
            }

            if (model.MEC18.HasValue && model.MEC18.Value)
            {
                codes.Add("MEC18");
            }
            if (model.MEC19.HasValue && model.MEC19.Value)
            {
                codes.Add("MEC19");
            }
            if (model.MEC20.HasValue && model.MEC20.Value)
            {
                codes.Add("MEC20");
            }
            if (model.MEC21.HasValue && model.MEC21.Value)
            {
                codes.Add("MEC21");
            }
            if (model.MEC22.HasValue && model.MEC22.Value)
            {
                codes.Add("MEC22");
            }
            if (model.MEC23.HasValue && model.MEC23.Value)
            {
                codes.Add("MEC23");
            }

            if (model.MEC25.HasValue && model.MEC25.Value)
            {
                codes.Add("MEC25");
            }
            if (model.MEC26.HasValue && model.MEC26.Value)
            {
                codes.Add("MEC26");
            }
            if (model.MEC27.HasValue && model.MEC27.Value)
            {
                codes.Add("MEC27");
            }
            if (model.MEC28.HasValue && model.MEC28.Value)
            {
                codes.Add("MEC28");
            }
            if (model.MEC29.HasValue && model.MEC29.Value)
            {
                codes.Add("MEC29");
            }
            if (model.MEC30.HasValue && model.MEC30.Value)
            {
                codes.Add("MEC30");
            }
            if (model.MEC31.HasValue && model.MEC31.Value)
            {
                codes.Add("MEC31");
            }

            if (model.MEC38.HasValue && model.MEC38.Value)
            {
                codes.Add("MEC38");
            }
            if (model.MEC39.HasValue && model.MEC39.Value)
            {
                codes.Add("MEC39");
            }
            if (model.MEC40.HasValue && model.MEC40.Value)
            {
                codes.Add("MEC40");
            }
            if (model.MEC41.HasValue && model.MEC41.Value)
            {
                codes.Add("MEC41");
            }
            if (model.MEC42.HasValue && model.MEC42.Value)
            {
                codes.Add("MEC42");
            }
            if (model.MEC43.HasValue && model.MEC43.Value)
            {
                codes.Add("MEC43");
            }
            if (model.MEC44.HasValue && model.MEC44.Value)
            {
                codes.Add("MEC44");
            }

            if (model.MEC47.HasValue && model.MEC47.Value)
            {
                codes.Add("MEC47");
            }

            if (model.MEC16.HasValue && model.MEC16.Value)
            {
                codes.Add("MEC16");
            }
            if (model.MEC24.HasValue && model.MEC24.Value)
            {
                codes.Add("MEC24");
            }

            if (model.MEC32.HasValue && model.MEC32.Value)
            {
                codes.Add("MEC32");
            }
            if (model.MEC34.HasValue && model.MEC34.Value)
            {
                codes.Add("MEC34");
            }
            if (model.MEC45.HasValue && model.MEC45.Value)
            {
                codes.Add("MEC45");
            }
            if (model.MEC46.HasValue && model.MEC46.Value)
            {
                codes.Add("MEC46");
            }

            if (model.FA01.HasValue && model.FA01.Value)
            {
                codes.Add("FA01");
            }
            if (model.FA02.HasValue && model.FA02.Value)
            {
                codes.Add("FA02");
            }
            if (model.FA03.HasValue && model.FA03.Value)
            {
                codes.Add("FA03");
            }

            if (codes.Count > 0)
            {
                return new SearchFilter((m, c) => { return codes.Contains(c.CardSet.Product.Code); }, 100, "Product matches filters");
            }

            return null;
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
                filters.Add(new SearchFilter((s, c) => { return s.CardSetMatches(c) || (!string.IsNullOrEmpty(c.CardSet.Cycle) && s.CardSet.ToUpper() == c.CardSet.Cycle.ToUpper()); }, 100, "Card Set matches '" + model.CardSet + "'"));

            if (model.HasScenario())
                filters.Add(new SearchFilter((s, c) => { return BelongsToScenario(c, s.Scenario); }, 100, "Scenario matches '" + model.Scenario + "'"));

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

            if (model.Popularity.IsDefinedFilter())
            {
                filters.Add(new SearchFilter((s, c) => { var pop = c.Popularity(getPopularity);  return pop > 0 && pop.CompareTo(s.PopularityOp, s.Popularity); }, 100, "Popularity " + model.PopularityOp.ToEnumDisplayString() + " '" + model.Popularity + "'"));
            }

            if (model.HasThreatCost())
                filters.Add(new SearchFilter((s, c) => { return c.ThreatCost.CompareTo(s.ThreatCostOperator, s.ThreatCost); }, 100, "Threat Cost" + model.ThreatCostOperator.ToEnumDisplayString() + " '" + model.ThreatCost + "'"));

            if (model.HasEngagementCost())
                filters.Add(new SearchFilter((s, c) => { return c.EngagementCost.CompareTo(s.EngagementCostOperator, s.EngagementCost); }, 100, "Engagement Cost" + model.EngagementCostOperator.ToEnumDisplayString() + " '" + model.EngagementCost + "'"));

            if (model.HasArtist())
                filters.Add(new SearchFilter((s, c) => { return s.Artist == c.Artist.Name; }, 100, "Has Artist '" + model.Artist + "'"));

            if (model.HasEncounterSet())
                filters.Add(new SearchFilter((s, c) => { return s.EncounterSet == c.EncounterSet || s.EncounterSet == c.AlternateEncounterSet; }, 100, "Has Encounter Set '" + model.EncounterSet + "'"));

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

            var officialSetFilter = false;
            if (model.SetType.HasValue)
            {
                if (model.SetType.Value != SetType.None)
                {
                    if (model.SetType.Value == SetType.Non_Nightmare)
                    {
                        filters.Add(new SearchFilter((s, c) => { return c.CardSet.SetType != SetType.Nightmare_Expansion; }, 50f, 0f, "Is Not From A Nightmare Set"));
                    }
                    else if (model.SetType.Value != SetType.ALL_SETS)
                    {
                        filters.Add(new SearchFilter((s, c) => { return (s.SetType == SetType.OFFICIAL && c.CardSet.SetType != SetType.CUSTOM) || (s.SetType.Value == c.CardSet.SetType); }, 50f, 0f, "Has Set Type '" + model.SetType + "'"));
                    }
                }
                else
                {
                    officialSetFilter = true;
                }
            }
            else
            {
                officialSetFilter = true;
            }

            var productFilter = getProductFilter(model);
            if (productFilter != null)
            {
                filters.Add(productFilter);
            }

            if (filters.Count == 0 && !model.IsAdvancedSearch())
            {
                //limit = 12;
                filters.Add(new SearchFilter((s, c) => { return (c.CardType == CardType.Hero && c.CardSet.Name == "Core Set"); }, 100f, "Default Search - Core Set Heroes"));
                //model.Sort = Sort.Set_Number;
            }
            //else if (!model.SetType.HasValue)
            //{
                //default set type search to official, if a card set filter is not already defined
                //filters.Add(new SearchFilter((s, c) => { return (c.CardSet.SetType != SetType.CUSTOM); }, 1, "Official Release"));
            //}

            if (filters.Count > 0)
            {
                if (officialSetFilter)
                {
                    filters.Add(new SearchFilter((s, c) => { return (c.CardSet.SetType != SetType.CUSTOM); }, 50f, 0f, "From an Official release"));
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
                var total = results.Values.Where(x => x.Score() > 0).Count();
                if (total > 1)
                {
                    var random = new Random();
                    var choice = random.Next(0, total - 1);
                    var score = results.Values.Where(x => x.Score() > 0).ToList()[choice];
                    results = new Dictionary<string, CardScore>();
                    results[score.Card.Slug] = score;
                }

                return results.Values.ToList();
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
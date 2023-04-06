using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Services.LotR.Scenarios
{
    public class ScenarioService : IScenarioService
    {
        public ScenarioService(ICategoryService<PlayerCategory> playerCategoryService, 
            ICategoryService<EncounterCategory> encounterCategoryService,
            ICategoryService<QuestCategory> questCategoryService,
            ICategoryService<Region> regionService,
            ICategoryService<Archetype> archetypeService,
            IRingsDbService ringsDbService,
            ProductRepository productRepository, ICardRepository<LotRCard> cardRepository)
            //ITranslationService translationService)
        {
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _regionService = regionService;
            _archetypeService = archetypeService;
            _ringsDbService = ringsDbService;
            this.cardRepository = cardRepository;
            //this.translationService = translationService;
            this.cards = cardRepository.Cards().ToList();
            foreach (var card in this.cards.Where(x => !string.IsNullOrEmpty(x.EncounterSet)))
            {
                var esKey = card.CardSetName + ":" + card.EncounterSet;
                if (!cardsByEncounterSet.ContainsKey(esKey))
                {
                    cardsByEncounterSet[esKey] = new List<LotRCard>();
                }

                cardsByEncounterSet[esKey].Add(card);
            }

            foreach (var group in productRepository.ProductGroups())
            {
                foreach (var main in group.MainProducts)
                {
                    AddProduct(main, cards);
                }
                
                foreach (var product in group.ChildProducts)
                {
                    AddProduct(product, cards);
                }
            }

            listViewModel = new ScenarioListViewModel();
            var lookupCard = new Func<string, LotRCard>((slug) => { return cardRepository.FindBySlug(slug); });
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
            var getRegions = new Func<string, IEnumerable<Region>>(slug => _regionService.Categories(slug));
            var getArchetypes = new Func<string, IEnumerable<Archetype>>(slug => _archetypeService.Categories(slug));

            foreach (var scenarioGroup in ScenarioGroups())
            {
                //TODO: Pass translateTitle function instead of null
                listViewModel.ScenarioGroups.Add(new ScenarioGroupViewModel(scenarioGroup, lookupCard, 
                    getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, null));
            }
        }

        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly ICategoryService<Region> _regionService;
        private readonly ICategoryService<Archetype> _archetypeService;
        private readonly IRingsDbService _ringsDbService;
        private readonly ICardRepository<LotRCard> cardRepository;
        //private readonly ITranslationService translationService;
        private readonly IList<LotRCard> cards;
        private readonly IDictionary<string, List<LotRCard>> cardsByEncounterSet = new Dictionary<string, List<LotRCard>>();
        private readonly Dictionary<string, Scenario> scenariosByAlternateTitle = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, Scenario> scenariosByTitle = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, Scenario> scenariosByNormalizedTitle = new Dictionary<string, Scenario>();
        private readonly ScenarioListViewModel listViewModel;

        private const string selectListSeparator = "————————————————————";

        private void AddScenario(Scenario scenario)
        {
            var escapedTitle = scenario.Title.ToUrlSafeString();
            if (scenariosByTitle.ContainsKey(escapedTitle))
            {
                return;
            }

            scenariosByTitle.Add(escapedTitle, scenario);
            scenariosByNormalizedTitle.Add(escapedTitle.NormalizeCaseSensitiveString(), scenario);

            if (!string.IsNullOrEmpty(scenario.AlternateTitle))
            {
                scenariosByAlternateTitle[scenario.AlternateTitle.ToUrlSafeString()] = scenario;
            }

            foreach (var set in scenario.EncounterSets())
            {
                var esKey = set.Set + ":" + set.Name;
                if (!cardsByEncounterSet.ContainsKey(esKey))
                {
                    continue;
                }

                foreach (var card in cardsByEncounterSet[esKey].Where(card => card.CardType != CardType.Quest))
                {
                    byte easyCount = 0; byte normalCount = 0; byte nightmareCount = 0;

                    if (set.IsNightmare)
                    {
                        nightmareCount = scenario.NightmareModeCount(card.Slug, card.Quantity);
                    }
                    else
                    {
                        easyCount = scenario.EasyModeCount(card.Slug, card.Quantity);
                        normalCount = scenario.NormalModeCount(card.Slug, card.Quantity);
                        nightmareCount = scenario.NightmareModeCount(card.Slug, card.Quantity);
                    }

                    if (card.SideLetter.GetValueOrDefault('a') != 'b')
                    {
                        scenario.MapCardCount(card.Slug, easyCount, normalCount, nightmareCount);
                    }
                    else 
                    {
                        scenario.MapCardCount(card.Slug, 0, 0, 0);
                    }

                    scenario.AddScenarioCard(card);
                }
            }

            foreach (var questId in scenario.QuestCardIds())
            {
                var questCard = cardRepository.FindBySlug(questId);
                if (questCard != null)
                {
                    var releaseQuantity = questCard.CardSet.IsNightmare ? (byte)0 : (byte)1;
                    var easyQuantity = scenario.EasyModeCount(questId, releaseQuantity);
                    var normalQuantity = scenario.NormalModeCount(questId, releaseQuantity);
                    var nightmareQuantity = scenario.NightmareModeCount(questId, 1);

                    scenario.AddQuestCard(questCard, easyQuantity, normalQuantity, nightmareQuantity);
                }
                else
                {
                    //invalid quest card ID
                    var x = questId;
                }
            }
        }

        private void AddProduct(Product product, IEnumerable<LotRCard> cards)
        {
            foreach (var scenario in product.Scenarios())
            {
                AddScenario(scenario);
            }
        }

        public IEnumerable<string> SetNames()
        {
            var setNames = new List<string>();

            CardSet previous = null;
            foreach (var set in CardSet.All())
            {
                if (previous != null && set.Cycle != previous.Cycle)
                {
                    if (!string.IsNullOrEmpty(previous.Cycle) || previous.SetType != set.SetType)
                    {
                        setNames.Add(selectListSeparator);
                    }

                    if (!string.IsNullOrEmpty(set.Cycle))
                    {
                        setNames.Add(set.Cycle.ToUpper());
                    }
                }

                setNames.Add(set.Name);

                previous = set;
            }

            return setNames;
        }

        public IEnumerable<CardSet> CardSets()
        {
            return CardSet.All();
        }

        public IEnumerable<string> EncounterSetNames()
        {
            return EncounterSet.All().Select(x => x.Name).ToList();
        }

        public IEnumerable<ScenarioGroup> ScenarioGroups()
        {
            var scenarioGroups = new Dictionary<string, ScenarioGroup>();

            foreach (var scenario in scenariosByTitle)
            {
                var name = scenario.Value.GroupName;

                if (!scenarioGroups.ContainsKey(name))
                {
                    scenarioGroups.Add(name, new ScenarioGroup() { Name = name });
                }

                scenarioGroups[name].AddScenario(scenario.Value);
            }

            return scenarioGroups.Values.ToList();
        }

        public IEnumerable<string> ScenarioTitles()
        {
            return scenariosByTitle.Values.Select(x => x.Title).ToList();
        }

        public Scenario GetScenario(string scenarioTitle)
        {
            if (scenariosByAlternateTitle.ContainsKey(scenarioTitle))
            {
                return scenariosByAlternateTitle[scenarioTitle];
            }

            if (scenariosByTitle.ContainsKey(scenarioTitle))
            {
                return scenariosByTitle[scenarioTitle];
            }

            var normalizedTitle = scenarioTitle.NormalizeCaseSensitiveString();
            if (scenariosByNormalizedTitle.ContainsKey(normalizedTitle))
            {
                return scenariosByNormalizedTitle[normalizedTitle];
            }

            return null;
        }

        public ScenarioListViewModel GetListViewModel()
        {
            return listViewModel;
        }

        public bool BelongsToScenario(string cardSlug, CardType cardType, string scenarioTitle)
        {
            if (string.IsNullOrEmpty(scenarioTitle))
            {
                return false;
            }

            var scenario = GetScenario(scenarioTitle.ToUrlSafeString());

            if (cardType == CardType.Quest)
            {
                return scenario.QuestCardIds().Any(x => x == cardSlug);
            }

            return scenario.ScenarioCards.Any(x => x.Card.Slug == cardSlug);
        }

        private void addAssociatedScenario(Dictionary<string, Tuple<Scenario, double>> map, Scenario scenario, double score)
        {
            if (!map.ContainsKey(scenario.Title))
            {
                map[scenario.Title] = new Tuple<Scenario,double>(scenario, score);
            } else {
                var existingScore = map[scenario.Title].Item2;
                map[scenario.Title] = new Tuple<Scenario,double>(scenario, existingScore + score);
            }
        }

        public IEnumerable<Tuple<Scenario, double>> AssociatedScenarios(string cardSlug, CardType cardType, double score)
        {
            var map = new Dictionary<string, Tuple<Scenario, double>>();

            foreach (var group in ScenarioGroups())
            {
                foreach (var scenario in group.Scenarios)
                {
                    if (cardType == CardType.Quest)
                    {
                        if (scenario.QuestCards.Any(qc => qc.Quest.Slug == cardSlug))
                        {
                            addAssociatedScenario(map, scenario, score);
                        }
                    }
                    else if (cardType.IsEncounterCard())
                    {
                        if (scenario.ScenarioCards.Any(sc => sc.Card.Slug == cardSlug))
                        {
                            addAssociatedScenario(map, scenario, score);
                        }
                    }
                    else if (cardType.IsPlayerCard())
                    {
                        foreach (var deckId in scenario.RelatedDecks)
                        {
                            if (_ringsDbService.DeckIncludesCard(deckId, cardSlug))
                            {
                                addAssociatedScenario(map, scenario, score);
                            }
                        }
                    }
                }
            }

            return map.Values;
        }

        private readonly HashSet<SetType> printOnDemand = new HashSet<SetType>
        {
            SetType.Nightmare_Expansion, SetType.GenCon_Expansion, SetType.GenConSaga_Expansion, SetType.Fellowship_Deck, SetType.FellowshipSaga_Deck, SetType.Custom_Scenario_Kit, SetType.Scenario_Pack,
        };

        private readonly HashSet<SetType> saga = new HashSet<SetType>
        {
            SetType.Saga_Expansion, SetType.GenConSaga_Expansion, SetType.FellowshipSaga_Deck,
        };

        private readonly HashSet<SetType> community = new HashSet<SetType>
        {
            SetType.First_Age, SetType.A_Long_extended_Party,
        };

        public bool HasSetType(LotRCard card, SetType? setType, UserSettings settings)
        {
            if (!setType.HasValue || setType.Value == SetType.None)
            {
                if (settings.IncludeCommunity) {
                    return true;
                } else if (settings.IncludeAlep) {
                    return card.CardSet.SetType != SetType.First_Age;
                } else if (settings.IncludeFirstAge) {
                    return card.CardSet.SetType != SetType.A_Long_extended_Party;
                } else {
                    return !card.CardSet.SetType.IsCommunity();
                }
            }

            if (setType.Value == SetType.ALL_SETS)
                return true;

            if (setType.Value == SetType.OFFICIAL)
                return !card.CardSet.SetType.IsCommunity();

            if (setType.Value == SetType.PRINT_ON_DEMAND)
                return printOnDemand.Contains(card.CardSet.SetType);

            if (setType.Value == SetType.SAGA)
                return saga.Contains(card.CardSet.SetType);

            if (setType.Value == SetType.Non_Nightmare)
                return card.CardSet.SetType != SetType.Nightmare_Expansion;

            if (setType.Value == SetType.COMMUNITY)
                return card.CardSet.SetType.IsCommunity();

            return card.CardSet.SetType == setType.Value;
        }
    }
}
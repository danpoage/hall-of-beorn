using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR
{
    public class ScenarioService
    {
        public ScenarioService(ProductRepository productRepository, CardRepository cardRepository)
        {
            this.cardRepository = cardRepository;
            this.cards = cardRepository.Cards().ToList();
            foreach (var card in this.cards.Where(x => !string.IsNullOrEmpty(x.EncounterSet)))
            {
                if (!cardsByEncounterSet.ContainsKey(card.EncounterSet))
                {
                    cardsByEncounterSet[card.EncounterSet] = new List<LotRCard>();
                }

                cardsByEncounterSet[card.EncounterSet].Add(card);
            }

            foreach (var group in productRepository.ProductGroups())
            {
                if (group.MainProduct != null)
                {
                    AddProduct(group.MainProduct, cards);
                }

                foreach (var product in group.ChildProducts)
                {
                    AddProduct(product, cards);
                }
            }

            listViewModel = new ScenarioListViewModel();
            var lookupCard = new Func<string, LotRCard>((slug) => { return cardRepository.FindBySlug(slug); });
            foreach (var scenarioGroup in ScenarioGroups())
            {
                listViewModel.ScenarioGroups.Add(new ScenarioGroupViewModel(scenarioGroup, lookupCard));
            }
        }

        private readonly CardRepository cardRepository;
        private readonly IList<LotRCard> cards;
        private readonly IDictionary<string, List<LotRCard>> cardsByEncounterSet = new Dictionary<string, List<LotRCard>>();
        private readonly Dictionary<string, Scenario> scenariosByAlternateTitle = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, Scenario> scenariosByTitle = new Dictionary<string, Scenario>();
        private readonly ScenarioListViewModel listViewModel;

        private void AddScenario(Scenario scenario)
        {
            var escapedTitle = scenario.Title.ToUrlSafeString();
            if (scenariosByTitle.ContainsKey(escapedTitle))
            {
                return;
            }

            scenariosByTitle.Add(escapedTitle, scenario);

            if (!string.IsNullOrEmpty(scenario.AlternateTitle))
            {
                scenariosByAlternateTitle[scenario.AlternateTitle.ToUrlSafeString()] = scenario;
            }

            foreach (var set in scenario.EncounterSets())
            {
                if (!cardsByEncounterSet.ContainsKey(set.Name))
                {
                    continue;
                }

                foreach (var card in cardsByEncounterSet[set.Name].Where(x => x.CardType != CardType.Quest))
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

                    scenario.MapCardCount(card.Slug, easyCount, normalCount, nightmareCount);
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
                        setNames.Add(Extensions.SelectListSeparator);
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
            //return getScenarioGroups();

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

        private IEnumerable<ScenarioGroup> getScenarioGroups()
        {
            var scenarioGroups = new List<ScenarioGroup>();

            scenarioGroups.Add(new ScenarioGroup("Core Set", getCoreSetScenarios()));
            scenarioGroups.Add(new ScenarioGroup("Shadows of Mirkwood", getShadowsOfMirkwoodScenarios()));

            return scenarioGroups;
        }

        private List<Scenario> getCoreSetScenarios()
        {
            var scenarios = new List<Scenario>();

            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.PassageThroughMirkwood());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.JourneyAlongTheAnduin());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.EscapeFromDolGuldur());

            return scenarios;
        }

        private List<Scenario> getShadowsOfMirkwoodScenarios()
        {
            var scenarios = new List<Scenario>();

            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.TheHuntForGollum());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.ConflictAtTheCarrock());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.AJourneyToRhosgobel());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.TheHillsOfEmynMuil());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.TheDeadMarshes());
            scenarios.Add(new HallOfBeorn.Models.LotR.Scenarios.ReturnToMirkwood());

            return scenarios;
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

            return scenariosByTitle.ContainsKey(scenarioTitle) ?
                scenariosByTitle[scenarioTitle]
                : null;
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public class ScenarioService
    {
        public ScenarioService(ProductRepository productRepository, CardRepository cardRepository)
        {
            this.cardRepository = cardRepository;
            this.cards = cardRepository.Cards().ToList();

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

            LoadScenarioCards(cards);    
        }

        private readonly CardRepository cardRepository;
        private readonly IList<Card> cards;
        private readonly List<CardSet> sets = new List<CardSet>();
        private readonly List<string> setNames = new List<string>();
        private readonly Dictionary<string, string> encounterSetNames = new Dictionary<string, string>();
        private readonly Dictionary<string, Scenario> scenarios = new Dictionary<string, Scenario>();

        private readonly Dictionary<string, Scenario> scenariosByTitle = new Dictionary<string, Scenario>();
        
        private void AddScenario(Scenario scenario)
        {
            scenariosByTitle.Add(scenario.Title, scenario);

            foreach (var set in scenario.EncounterSets())
            {
                foreach (var card in cards.Where(x => x.EncounterSet == set.Name))
                {
                    var easyCount = scenario.EasyModeCount(card.Slug, card.Quantity);
                    var normalCount = scenario.NormalModeCount(card.Slug, card.Quantity);
                    var nightmareCount = scenario.NightmareModeCount(card.Slug, card.Quantity);

                    scenario.MapCardCount(card.Slug, easyCount, normalCount, nightmareCount);
                }
            }
        }

        private void AddProduct(Product product, IEnumerable<Card> cards)
        {
            foreach (var cardSet in product.CardSets())
            {
                AddSet(product, cardSet, cards);
            }

            foreach (var scenario in product.Scenarios())
            {
                AddScenario(scenario);
            }
        }

        private void AddSet(Product product, CardSet cardSet, IEnumerable<Card> cards)
        {
            sets.Add(cardSet);

            if (!string.IsNullOrEmpty(cardSet.Cycle) && !setNames.Contains(cardSet.Cycle.ToUpper()))
                setNames.Add(cardSet.Cycle.ToUpper());

            setNames.Add(cardSet.Name);

            var campaignMap = new Dictionary<string, Card>();

            foreach (var card in cardSet.Cards)
            {
                if (!string.IsNullOrEmpty(card.ScenarioTitle))
                {
                    var escapedTitle = card.ScenarioTitle.ToUrlSafeString();

                    if (card.CardType == CardType.Quest)
                    {
                        if (!scenarios.ContainsKey(escapedTitle))
                        {
                            var scenarioTitle = card.ScenarioTitle;
                            var scenarioNumber = card.ScenarioNumber;

                            var cycle = !string.IsNullOrEmpty(card.CardSet.Cycle) ? card.CardSet.Cycle : card.CardSet.Name;

                            if (cycle == "NIGHTMARE")
                            {
                                var encounterSet = card.EncounterSet.Replace(" Nightmare", string.Empty);
                                scenarioTitle = scenarioTitle.Replace(" Nightmare", string.Empty);
                                var original = cards.Where(x => x.CardType == CardType.Quest && x.EncounterSet == encounterSet && x.CardSet.Cycle != "NIGHTMARE").FirstOrDefault();
                                if (original != null)
                                {
                                    cycle = !string.IsNullOrEmpty(original.CardSet.Cycle) ? original.CardSet.Cycle : original.CardSet.Name;
                                }
                            }

                            var scenario = new Scenario { Title = scenarioTitle, GroupName = cycle, Number = scenarioNumber, RulesUrl = product.RulesUrl, ProductName = product.Name };
                            scenario.AddQuestCard(card);

                            scenarios.Add(escapedTitle, scenario);
                        }
                        else
                        {
                            scenarios[escapedTitle].AddQuestCard(card);
                        }
                    }
                    else if (card.CardType == CardType.Campaign)
                    {
                        campaignMap.Add(escapedTitle, card);
                    }
                }

                if (!string.IsNullOrEmpty(card.EncounterSet))
                {
                    if (!encounterSetNames.ContainsKey(card.EncounterSet))
                    {
                        encounterSetNames.Add(card.EncounterSet, cardSet.Name);
                    }
                }
            }

            if (campaignMap.Count > 0)
            {
                foreach (var campaignItem in campaignMap)
                {
                    if (scenarios.ContainsKey(campaignItem.Key))
                    {
                        scenarios[campaignItem.Key].SetCampaignCard(campaignItem.Value);
                    }
                }
            }
        }

        private void LoadScenarioCards(IEnumerable<Card> cards)
        {
            foreach (var card in cards.Where(x => !string.IsNullOrEmpty(x.ScenarioTitle)))
            {
                var escapedTitle = card.ScenarioTitle.ToUrlSafeString();

                if (card.CardType == CardType.Location || card.CardType == CardType.Enemy || card.CardType == CardType.Treachery || card.CardType == CardType.Objective || card.CardType == CardType.Objective_Ally || card.CardType == CardType.Objective_Location || card.CardType == CardType.Encounter_Side_Quest)
                {
                    if (scenarios.ContainsKey(escapedTitle) && !card.ScenarioTitle.EndsWith(" Nightmare"))
                    {
                        scenarios[escapedTitle].AddScenarioCard(card);
                    }
                    else
                    {
                        if (card.ScenarioTitle.EndsWith(" Nightmare"))
                        {
                            var originalTitle = card.ScenarioTitle.Replace(" Nightmare", string.Empty).ToUrlSafeString();

                            if (scenarios.ContainsKey(originalTitle))
                            {
                                scenarios[originalTitle].AddScenarioCard(card);
                            }
                        }
                    }

                    foreach (var otherScenario in scenarios.Values.Where(x => x.IncludesEncounterSet(card.ScenarioTitle)).ToList())
                    {
                        otherScenario.AddScenarioCard(card);
                    }
                }
            }

            //Adds cards which comprise their own eponymous encounter set, but are included in multiple quests. (e.g. Iarion)
            foreach (var card in cards.Where(x => !string.IsNullOrEmpty(x.ScenarioTitle) && x.Title == x.EncounterSet && x.CardType == CardType.Objective_Ally))
            {
                foreach (var scenario in scenarios.Values)
                {
                    if (scenario.QuestCards.Any(x => x.IncludedEncounterSets.Any(y => y.Name == card.EncounterSet)))
                    {
                        scenario.AddScenarioCard(card);
                    }
                }
            }

            //load nightmare setup cards
            foreach (var setupCard in cards.Where(x => x.CardType == CardType.Nightmare_Setup))
            {
                if (setupCard.UpdateScenarioCards != null)
                {
                    setupCard.UpdateScenarioCards(ScenarioGroups());
                }
            }
        }

        public IEnumerable<string> SetNames()
        {
            return setNames;
        }

        public IEnumerable<CardSet> CardSets()
        {
            return sets;
        }

        public IEnumerable<string> EncounterSetNames()
        {
            return encounterSetNames.Keys;
        }

        public IEnumerable<ScenarioGroup> ScenarioGroups()
        {
            var scenarioGroups = new Dictionary<string, ScenarioGroup>();

            foreach (var scenario in scenarios)
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
            return scenarios.Values.Select(x => x.Title).ToList();
        }

        public Scenario GetScenario(string scenarioTitle)
        {
            return scenarios.ContainsKey(scenarioTitle) ?
                scenarios[scenarioTitle]
                : null;
        }
    }
}
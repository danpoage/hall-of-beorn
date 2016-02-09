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
        }

        private readonly CardRepository cardRepository;
        private readonly IList<Card> cards;
        private readonly Dictionary<string, Scenario> scenariosByAlternateTitle = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, Scenario> scenariosByTitle = new Dictionary<string, Scenario>();
        
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
                foreach (var card in cards.Where(x => x.CardType != CardType.Quest && x.EncounterSet == set.Name))
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
                var releaseQuantity = questCard.CardSet.IsNightmare ? (byte)0 : (byte)1;
                var easyQuantity = scenario.EasyModeCount(questId, releaseQuantity); 
                var normalQuantity = scenario.NormalModeCount(questId, releaseQuantity); 
                var nightmareQuantity = scenario.NightmareModeCount(questId, 1);

                scenario.AddQuestCard(questCard, easyQuantity, normalQuantity, nightmareQuantity);
            }
        }

        private void AddProduct(Product product, IEnumerable<Card> cards)
        {
            foreach (var scenario in product.Scenarios())
            {
                AddScenario(scenario);
            }
        }

        public IEnumerable<string> SetNames()
        {
            return CardSet.All().Select(x => x.Name).ToList();

            /*
            var setNames = new List<string>();

            CardSet previous = null;
            foreach (var set in CardSet.All())
            {
                if (previous != null && set.Cycle != previous.Cycle)
                {
                    setNames.Add(Extensions.SelectListSeparator);
                }

                setNames.Add(set.Name);

                previous = set;
            }

            return setNames;
            */
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

            return scenariosByTitle.ContainsKey(scenarioTitle) ?
                scenariosByTitle[scenarioTitle]
                : null;
        }
    }
}
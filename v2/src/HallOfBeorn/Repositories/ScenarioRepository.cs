using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Repositories
{
    public class ScenarioRepository
    {
        public ScenarioRepository(ProductRepository productRepository)
        {
            this.productRepository = productRepository;

            Initialize();
        }

        private readonly ProductRepository productRepository;
        private readonly Dictionary<string, Scenario> scenarioMap = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, CardSet> standardCardSetMap = new Dictionary<string, CardSet>();
        private readonly Dictionary<string, CardSet> nightmareCardSetMap = new Dictionary<string, CardSet>();

        private void Initialize()
        {
            foreach (var product in productRepository.All())
            {
                foreach (var cardSet in product.CardSets)
                {
                    var key = cardSet.Name.Text;
                    if (cardSet.SetType == SetType.Nightmare_Expansion)
                    {
                        var norm = key.Replace(" Nightmare", string.Empty);

                        nightmareCardSetMap[norm] = cardSet;
                    }
                    else
                    {
                        standardCardSetMap[key] = cardSet;
                    }
                }
            }

            foreach (var (setName, cardSet) in standardCardSetMap)
            {
                byte number = 1;
                var encounterSetMap = cardSet.EncounterSets
                    .ToDictionary(es => es.Name.Text);

                Dictionary<string, EncounterSet> parentEncounerSetMap = null;

                var product = productRepository.GetProduct(cardSet.Product.Name.Text);
                if (product.Cycle != null)
                {
                    parentEncounerSetMap = product.Cycle.Parent.CardSets.First().EncounterSets.ToDictionary(es => es.Name.Text);
                }

                foreach (var encounterSet in standardCardSetMap[setName].EncounterSets)
                {
                    var quests = encounterSet.Cards.Where(card => card.CardType == CardType.Quest);
                    if (quests.Any())
                    {
                        var includedNames = quests.SelectMany(q => q.IncludedEncounterSets);
                        var includedEncounterSets = new List<EncounterSet>();
                        includedEncounterSets.AddRange(
                            includedNames.Where(name => encounterSetMap.ContainsKey(name))
                            .Select(name => encounterSetMap[name]));

                        if (parentEncounerSetMap != null)
                        {
                            includedEncounterSets.AddRange(
                                includedNames.Where(name => parentEncounerSetMap.ContainsKey(name))
                                .Select(name => parentEncounerSetMap[name]));
                        }

                        if (nightmareCardSetMap.ContainsKey(setName))
                        {
                            includedEncounterSets.AddRange(nightmareCardSetMap[setName].EncounterSets);
                        }

                        scenarioMap[setName] = new Scenario(number, encounterSet, includedEncounterSets);
                        number++;
                    }
                }
            }
        }

        public IReadOnlyList<Scenario> All()
        {
            return scenarioMap.Values.ToListSafe();
        }

        public Scenario GetScenario(string name)
        {
            var key = name.NormalizeCaseSensitiveString();

            return scenarioMap.ContainsKey(key)
                ? scenarioMap[key]
                : null;
        }
    }
}

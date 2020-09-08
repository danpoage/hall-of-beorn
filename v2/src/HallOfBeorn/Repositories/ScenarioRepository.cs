using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Repositories
{
    public class ScenarioRepository
    {
        public ScenarioRepository(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        private readonly ProductRepository productRepository;
        private readonly Dictionary<string, Scenario> all = new Dictionary<string, Scenario>();
        private readonly Dictionary<string, Scenario> allNormalized = new Dictionary<string, Scenario>();

        public IReadOnlyList<Scenario> All()
        {
            return all.Values.ToListSafe();
        }

        public Scenario GetScenario(string name)
        {
            if (all.ContainsKey(name))
            {
                return all[name];
            }

            if (allNormalized.ContainsKey(name))
            {
                return allNormalized[name];
            }

            return null;
        }
    }
}

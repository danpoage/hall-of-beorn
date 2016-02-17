using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioGroup
    {
        public ScenarioGroup()
        {
        }

        public ScenarioGroup(string name, IEnumerable<Scenario> scenarios)
        {
            this.Name = name;

            foreach (var scenario in scenarios)
            {
                AddScenario(scenario);
            }
        }

        private readonly List<Scenario> scenarios = new List<Scenario>();

        public string Name { get; set; }
        public IEnumerable<Scenario> Scenarios
        {
            get
            {
                return scenarios.OrderBy(x => x.Number).ToList();
            }
        }

        public void AddScenario(Scenario scenario)
        {
            scenarios.Add(scenario);
        }
    }
}
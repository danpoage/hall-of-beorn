using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioGroupViewModel
    {
        public ScenarioGroupViewModel(ScenarioGroup scenarioGroup, Func<string, Card> lookupCard)
        {
            Name = scenarioGroup.Name;
            Scenarios = new List<ScenarioViewModel>();

            foreach (var scenario in scenarioGroup.Scenarios)
            {
                Scenarios.Add(new ScenarioViewModel(scenario, lookupCard));
            }
        }

        public string Name { get; set; }
        public List<ScenarioViewModel> Scenarios { get; private set; }
    }
}
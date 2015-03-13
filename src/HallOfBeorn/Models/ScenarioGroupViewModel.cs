using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioGroupViewModel
    {
        public ScenarioGroupViewModel(ScenarioGroup scenarioGroup)
        {
            Name = scenarioGroup.Name;
            Scenarios = new List<ScenarioViewModel>();

            foreach (var scenario in scenarioGroup.Scenarios)
            {
                Scenarios.Add(new ScenarioViewModel(scenario));
            }
        }

        public string Name { get; set; }
        public List<ScenarioViewModel> Scenarios { get; private set; }
    }
}
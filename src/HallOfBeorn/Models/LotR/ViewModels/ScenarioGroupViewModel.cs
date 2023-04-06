using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ScenarioGroupViewModel
    {
        public ScenarioGroupViewModel(ScenarioGroup scenarioGroup, Func<string, LotRCard> lookupCard, 
            Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, 
            Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, 
            Func<string, IEnumerable<QuestCategory>> getQuestCategories,
            Func<string, IEnumerable<Region>> getRegions,
            Func<string, IEnumerable<Archetype>> getArchetypes,
            Func<string, string> translateTitle)
        {
            Name = scenarioGroup.Name;
            Scenarios = new List<ScenarioViewModel>();

            foreach (var scenario in scenarioGroup.Scenarios)
            {
                Scenarios.Add(new ScenarioViewModel(scenario, lookupCard, 
                    getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, translateTitle));
            }
        }

        public string Name { get; private set; }
        public List<ScenarioViewModel> Scenarios { get; private set; }
    }
}
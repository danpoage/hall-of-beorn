using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ScenarioListViewModel
    {
        public ScenarioListViewModel()
        {
            ScenarioGroups = new List<ScenarioGroupViewModel>();
        }

        public ScenarioView? View { get; set; }
        public ScenarioViewModel Detail { get; set; }
        public List<ScenarioGroupViewModel> ScenarioGroups { get; set; }

        private HashSet<string> sagaGroups = new HashSet<string>
        {
            ScenarioGroup.TheHobbit,
            ScenarioGroup.TheLordOfTheRings,
            ScenarioGroup.GenConDecks,
            ScenarioGroup.FellowshipDecks,
            ScenarioGroup.ScenarioPacks,
            ScenarioGroup.FirstAge,
            ScenarioGroup.DoomMastered,
        };

        public IEnumerable<ScenarioGroupViewModel> ScenarioStandardGroups()
        {
            return ScenarioGroups.Where(sg => !sagaGroups.Contains(sg.Name));
        }

        public IEnumerable<ScenarioGroupViewModel> ScenarioSagaGroups()
        {
            return ScenarioGroups.Where(sg => sagaGroups.Contains(sg.Name));
        }

        public string QuestMapUrl
        {
            get
            {
                return "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Maps/Quest-Map.png";
            }
        }
    }
}
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

        public IEnumerable<ScenarioGroupViewModel> ScenarioStandardGroups()
        {
            return ScenarioGroups.Where(sg =>
                sg.Name != "The Hobbit" &&
                sg.Name != "The Lord of the Rings" &&
                sg.Name != "Gen Con & Fellowship" &&
                sg.Name != "First Age" &&
                sg.Name != "Doom Mastered");
        }

        public IEnumerable<ScenarioGroupViewModel> ScenarioSagaGroups()
        {
            return ScenarioGroups.Where(sg =>
                sg.Name == "The Hobbit" ||
                sg.Name == "The Lord of the Rings" ||
                sg.Name == "Gen Con & Fellowship" ||
                sg.Name == "First Age" ||
                sg.Name == "Doom Mastered");
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
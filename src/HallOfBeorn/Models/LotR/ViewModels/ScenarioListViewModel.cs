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

        public ScenarioViewModel Detail { get; set; }
        public List<ScenarioGroupViewModel> ScenarioGroups { get; set; }

        public string QuestMapUrl
        {
            get
            {
                return "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Maps/Middle-earth-Quest-Map.png";
            }
        }
    }
}
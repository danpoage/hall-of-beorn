using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioListViewModel
    {
        public ScenarioListViewModel()
        {
            ScenarioGroups = new List<ScenarioGroupViewModel>();
        }

        public ScenarioViewModel Detail { get; set; }
        public List<ScenarioGroupViewModel> ScenarioGroups { get; set; }
    }
}
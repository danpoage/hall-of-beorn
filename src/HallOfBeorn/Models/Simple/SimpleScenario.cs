using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Simple
{
    public class SimpleScenario
    {
        public SimpleScenario()
        {
            QuestCards = new List<SimpleCard>();
            ScenarioCards = new List<SimpleScenarioCard>();
        }

        public string Title { get; set; }
        public uint Number { get; set; }
        public List<SimpleCard> QuestCards { get; private set; }
        public List<SimpleScenarioCard> ScenarioCards { get; private set; }
    }
}
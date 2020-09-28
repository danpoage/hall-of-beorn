using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.FirstAge
{
    public class AmongTheOutlawsScenario
        : Scenario
    {
        public AmongTheOutlawsScenario()
            : base(false)
        {
            Title = "Among the Outlaws";
            ProductName = "Among the Outlaws";
            GroupName = "First Age";
            Number = 5;

            AddEncounterSet(EncounterSet.AmongTheOutlaws);

            AddQuestCardId("An-Evil-and-Dangerous-Way-AtO");
            AddQuestCardId("To-Govern-the-Fellowship-AtO");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DoomMastered
{
    public class AmongTheOutlawsScenario
        : Scenario
    {
        public AmongTheOutlawsScenario()
            : base(false)
        {
            Title = "Among the Outlaws";
            ProductName = "Among the Outlaws";
            GroupName = "Doom Mastered";
            Number = 2;

            AddEncounterSet(EncounterSet.AmongTheOutlaws);

            AddQuestCardId("An-Evil-and-Dangerous-Way-AtO");
            AddQuestCardId("To-Govern-the-Fellowship-AtO");
        }
    }
}
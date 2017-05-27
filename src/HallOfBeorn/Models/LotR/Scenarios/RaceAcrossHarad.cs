using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class RaceAcrossHarad : TheSandsOfHarad
    {
        public RaceAcrossHarad()
        {
            Title = "Race Across Harad";
            ProductName = "Race Across Harad";
            GroupName = "Haradrim";
            Number = 2;

            //QuestCompanionUrl = "";

            AddEncounterSet(EncounterSet.RaceAcrossHarad);
            AddEncounterSet(EncounterSet.MordorOrcs);
            AddEncounterSet(EncounterSet.DesertSands);

            AddQuestCardId("Setting-Out-RaH");
            AddQuestCardId("Racing-North-RaH");
            AddQuestCardId("Hunted-in-Harad-RaH");
            AddQuestCardId("The-Ford-of-Harnen-RaH");
            AddQuestCardId("Setting-Out-C-RaH");
            AddQuestCardId("Racing-North-C-RaH");
            AddQuestCardId("Hunted-in-Harad-C-RaH");
            AddQuestCardId("The-Ford-of-Harnen-C-RaH");

            excludeMordorOrcs();
            excludeDesertSands();
        }
    }
}
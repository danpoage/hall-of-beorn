using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class TheMumakil : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public TheMumakil()
        {
            Title = "The Mûmakil";
            ProductName = "The Mûmakil";
            GroupName = "Haradrim";
            Number = 1;

            //QuestCompanionUrl = "";

            AddEncounterSet(EncounterSet.TheMumakil);
            AddEncounterSet(EncounterSet.JungleForest);

            AddQuestCardId("Welcome-to-the-Jungle-TMk");
            AddQuestCardId("Capture-the-Oliphaunts-TMk");

            excludeJungleForest();

            ExcludeFromEasyMode("Harad-Tiger-TMk", 1);
            ExcludeFromEasyMode("Strangling-Python-TMk", 1);
            ExcludeFromEasyMode("Terrible-Fever-TMk", 1);
            ExcludeFromEasyMode("Biting-Insects-TMk", 1);
        }
    }
}
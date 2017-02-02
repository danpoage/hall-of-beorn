using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheLongArmOfMordor : TheSandsOfHarad
    {
        public TheLongArmOfMordor()
        {
            Title = "The Long Arm of Mordor";
            ProductName = "The Sands of Harad";
            GroupName = "The Sands of Harad";
            Number = 3;

            //QuestCompanionUrl = "";

            AddEncounterSet(EncounterSet.TheLongArmOfMordor);
            AddEncounterSet(EncounterSet.MordorOrcs);
            AddEncounterSet(EncounterSet.JungleForest);
            
            AddQuestCardId("Surprise-Attack-TSoH");
            AddQuestCardId("Find-the-Others-TSoH");
            AddQuestCardId("Free-the-Captives-TSoH");
            AddQuestCardId("Escape-into-the-Jungle-TSoH");

            excludeTheLongArmOfMordor();
            excludeMordorOrcs();
            excludeJungleForest();
        }
    }
}
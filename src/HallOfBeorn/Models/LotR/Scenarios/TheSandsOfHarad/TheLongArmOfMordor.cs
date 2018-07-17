using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad
{
    public class TheLongArmOfMordor : TheSandsOfHaradScenario
    {
        public TheLongArmOfMordor()
        {
            Title = "The Long Arm of Mordor";
            ProductName = "The Sands of Harad";
            GroupName = "The Sands of Harad";
            Number = 3;

            QuestCompanionSlug = "sands-of-harad-quest-the-long-arm-of-mordor";
            DifficultyRating = 6.9f;
            Votes = 8;

            AddPlayLink(LinkType.Path_Less_Traveled, "https://darklingdoor.wordpress.com/2018/01/01/path-less-traveled-the-long-arm-of-mordor/", "The Long Arm of Mordor");

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad
{
    public class DesertCrossingScenario : TheSandsOfHaradScenario
    {
        public DesertCrossingScenario()
        {
            Title = "Desert Crossing";
            ProductName = "The Sands of Harad";
            GroupName = "The Sands of Harad";
            Number = 2;

            QuestCompanionSlug = "sands-of-harad-quest-desert-crossing";
            DifficultyRating = 5.4f;
            Votes = 8;

            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/12/14/path-less-traveled-desert-crossing/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/08/17/desert-crossing/");

            AddEncounterSet(EncounterSet.DesertCrossing);
            AddEncounterSet(EncounterSet.DesertCreatures);
            AddEncounterSet(EncounterSet.DesertSands);
            
            AddQuestCardId("The-Desert-of-Harad-TSoH");
            AddQuestCardId("Under-the-Merciless-Sun-TSoH");
            AddQuestCardId("Beasts-of-Legend-TSoH");

            excludeDesertCrossing();
            excludeDesertCreatures();
            excludeDesertSands();
        }
    }
}
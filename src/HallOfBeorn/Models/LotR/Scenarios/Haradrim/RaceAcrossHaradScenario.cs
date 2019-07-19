using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class RaceAcrossHaradScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public RaceAcrossHaradScenario()
        {
            Title = "Race Across Harad";
            ProductName = "Race Across Harad";
            GroupName = "Haradrim";
            Number = 2;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/e6/68/e66896e0-6e11-49f4-901c-724ad64cd173/mec57_web_race_across_harad-rules.pdf";
            QuestCompanionSlug = "haradrim-cycle-quest-race-across-harad";
            DifficultyRating = 6.3f;
            Votes = 3;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/07/09/race-across-harad/");

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
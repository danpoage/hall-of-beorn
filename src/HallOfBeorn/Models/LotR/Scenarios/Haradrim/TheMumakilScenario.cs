using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class TheMumakilScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public TheMumakilScenario()
        {
            Title = "The Mûmakil";
            ProductName = "The Mûmakil";
            GroupName = "Haradrim";
            Number = 1;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/03/0a/030a4e90-544d-4d24-a160-c5e05f34c778/mec56_rule_set.pdf";
            QuestCompanionSlug = "haradrim-cycle-quest-the-mumakil";
            DifficultyRating = 5.4f;
            Votes = 8;

            AddLotRDeckTechLink("Boromir Catches a Mumak", "FX3_k2doCVM");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/03/27/the-mumakil/");

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
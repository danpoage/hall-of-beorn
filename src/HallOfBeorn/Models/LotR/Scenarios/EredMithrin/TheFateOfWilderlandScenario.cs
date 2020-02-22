using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class TheFateOfWilderlandScenario : EredMithrinScenario
    {
        private const string name = "The Fate of Wilderland";

        public TheFateOfWilderlandScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 9;

            RulesImageCount = 3;

            QuestCompanionSlug = "ered-mithrin-quest-the-fate-of-wilderland";
            DifficultyRating = 5.5f;
            Votes = 8;

            AddEncounterSet(EncounterSet.TheFateOfWilderland);
            AddEncounterSet(EncounterSet.GreyMountainGoblins);
            AddEncounterSet(EncounterSet.GatheringGloom);
            AddEncounterSet(EncounterSet.HillsOfWilderland);

            AddQuestCardId("Urdug's-Assault-TFoW");
            AddQuestCardId("Outflanked-TFoW");
            AddQuestCardId("The-Final-Push-TFoW");

            ExcludeGreyMountainGoblinsFromEasyMode();
            ExcludeGatheringGloomFromEasyMode();
            ExcludeHillsOfWilderlandFromEasyMode();

            ExcludeFromEasyMode("Urdug's-Elite-TFoW", 1);
            ExcludeFromEasyMode("Fierce-Vanguard-TFoW", 1);
            ExcludeFromEasyMode("Slopes-of-Gundabad-TFoW", 2);
            ExcludeFromEasyMode("Fierce-Attack-TFoW", 1);
            ExcludeFromEasyMode("Urdug's-Command-TFoW", 1);
        }
    }
}
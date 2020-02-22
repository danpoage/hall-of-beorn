using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class RoamAcrossRhovanionScenario : EredMithrinScenario
    {
        private const string name = "Roam Across Rhovanion";

        public RoamAcrossRhovanionScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 5;

            RulesImageCount = 2;

            QuestCompanionSlug = "ered-mithrin-quest-roam-across-rhovanion";
            DifficultyRating = 6f;
            Votes = 10;

            AddEncounterSet(EncounterSet.RoamAcrossRhovanion);
            AddEncounterSet(EncounterSet.FellBeasts);
            AddEncounterSet(EncounterSet.LostInWilderland);
            AddEncounterSet(EncounterSet.HillsOfWilderland);

            AddQuestCardId("The-Goblin's-Task-RAR");
            AddQuestCardId("Rescue-Tiny-RAR");
            AddQuestCardId("Retrieve-Urdug's-Horn-RAR");
            AddQuestCardId("Find-Durin's-Key-RAR");
            AddQuestCardId("Urdug's-Gambit-RAR");

            ExcludeFromEasyMode("Grey-Mountain-Giant-RAR", 1);
            ExcludeFromEasyMode("Hunting-Eagle-RAR", 1);
            ExcludeFromEasyMode("Grey-Moorland-RAR", 1);
            ExcludeFromEasyMode("Deep-Ravine-RAR", 1);
            ExcludeFromEasyMode("Sneaking-Off-RAR", 2);

            ExcludeFellBeastsFromEasyMode();
            ExcludeLostInWilderlandFromEasyMode();
            ExcludeHillsOfWilderlandFromEasyMode();
        }
    }
}
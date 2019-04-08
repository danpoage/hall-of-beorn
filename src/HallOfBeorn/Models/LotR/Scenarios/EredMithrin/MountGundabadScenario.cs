﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class MountGundabadScenario : EredMithrinScenario
    {
        private const string name = "Mount Gundabad";

        public MountGundabadScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 8;

            QuestCompanionSlug = "ered-mithrin-quest-mount-gundabad";
            DifficultyRating = 6.0f;
            Votes = 1;

            AddEncounterSet(EncounterSet.MountGundabad);
            AddEncounterSet(EncounterSet.FellBeasts); 
            AddEncounterSet(EncounterSet.DeepUnderground);
            AddEncounterSet(EncounterSet.AfraidOfTheDark);
            AddEncounterSet(EncounterSet.LostCaves);
            AddEncounterSet(EncounterSet.DragonMight);

            AddQuestCardId("The-Side-Door-MG");
            AddQuestCardId("Exploring-Gundabad-The-Upper-Levels-MG");
            AddQuestCardId("Exploring-Gundabad-The-Lower-Deeps-MG");
            AddQuestCardId("Exploring-Gundabad-Frenzied-Warrens-MG");
            AddQuestCardId("Exploring-Gundabad-Dagnir's-Wrath-MG");
            AddQuestCardId("Exploring-Gundabad-Foreboding-Darkness-MG");
            AddQuestCardId("Exploring-Gundabad-Imminent-Pursuit-MG");
            AddQuestCardId("Exploring-Gundabad-The-Great-Worm-MG");

            ExcludeFromEasyMode("Dagnir's-Slave-MG", 1);
            ExcludeFromEasyMode("Deep-dweller-MG", 1);
            ExcludeFromEasyMode("Mines-of-Gundabad-MG", 1);
            ExcludeFromEasyMode("Narrow-Stair-MG", 1);
            ExcludeFromEasyMode("Wilderland's-Bane", 2);

            ExcludeFellBeastsFromEasyMode();
            ExcludeDeepUndergroundFromEasyMode();
            ExcludeAfraidOfTheDarkFromEasyMode();
            ExcludeDragonMightFromEasyMode();
        }
    }
}
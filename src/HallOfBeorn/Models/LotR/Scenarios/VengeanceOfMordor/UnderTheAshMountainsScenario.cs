﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class UnderTheAshMountainsScenario
        : AShadowInTheEastScenario
    {
        public const string name = "Under the Ash Mountains";

        public UnderTheAshMountainsScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 4;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC81.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-under-the-ash-mountains";
            DifficultyRating = 9.0f;
            Votes = 5;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2021/02/13/under-the-ash-mountains/");

            AddEncounterSet(EncounterSet.UnderTheAshMountains);
            AddEncounterSet(EncounterSet.TwistedTunnels);

            AddQuestCardId("Passage-into-Mordor-UtAM");
            AddQuestCardId("An-Evil-Place-UtAM");

            ExcludeTwistedTunnelsFromEasyMode();
            ExcludeFromEasyMode("Mordor-Cave-Troll-UtAM", 1);
            ExcludeFromEasyMode("Spawn-of-Shelob-UtAM", 1);
            ExcludeFromEasyMode("Torech-Gorgor-Patrol-UtAM", 1);
            ExcludeFromEasyMode("Fiery-Chasm-UtAM", 1);
            ExcludeFromEasyMode("Orc-Passage-UtAM", 1);
            ExcludeFromEasyMode("Burning-Reek-UtAM", 1);
            ExcludeFromEasyMode("Writhing-Shadows-UtAM", 1);
        }
    }
}
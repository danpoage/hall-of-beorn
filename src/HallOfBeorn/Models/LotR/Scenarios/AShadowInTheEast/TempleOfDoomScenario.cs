﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public class TempleOfDoomScenario : AShadowInTheEastScenario
    {
        private const string name = "Temple of Doom";

        public TempleOfDoomScenario()
        {
            Title = name;
            ProductName = "A Shadow in the East";
            GroupName = "A Shadow in the East";
            Number = 3;

            RulesImageCount = 10;

            QuestCompanionSlug = "a-shadow-in-the-east-deluxe-expansion-quest-the-temple-of-doom";
            DifficultyRating = 8.2f;
            Votes = 12;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/11/19/the-temple-of-doom/");

            AddEncounterSet(EncounterSet.TempleOfDoom);
            AddEncounterSet(EncounterSet.UlchorsGuard);
            AddEncounterSet(EncounterSet.TwistedTunnels);
            AddEncounterSet(EncounterSet.EasterlingRaiders);
            AddEncounterSet(EncounterSet.ThePowerOfMordor);

            AddQuestCardId("The-Forgotten-Temple-ASitE");
            AddQuestCardId("The-Legacy-of-Mordor-ASitE");
            AddQuestCardId("Memory-of-the-Dark-Years-ASitE");
            AddQuestCardId("Shrine-to-Sauron-ASitE");
            AddQuestCardId("The-Lord-of-Middle-earth-ASitE");

            ExcludeTempleOfDoomFromEasyMode();
            ExcludeUlchorsGuardFromEasyMode();
            ExcludeTwistedTunnelsFromEasyMode();
            ExcludeEasterlingRaidersFromEasyMode();
        }
    }
}

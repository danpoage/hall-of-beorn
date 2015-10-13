using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class OverTheMistyMountainsGrim : TheHobbitOverHillScenario
    {
        public OverTheMistyMountainsGrim()
        {
            SagaExpansion("Over the Misty Mountains Grim", "The Hobbit: Over Hill and Under Hill", 2);

            AddQuestCardId("A-Short-Rest-THOHaUH");
            AddQuestCardId("The-Mountain-Pass-THOHaUH");
            AddQuestCardId("Down-Down-to-Goblin-Town-THOHaUH");

            AddEncounterSet(EncounterSet.OverTheMistyMountainsGrim);
            AddEncounterSet(EncounterSet.MistyMountainGoblins);
            AddEncounterSet(EncounterSet.TheGreatGoblin);
            AddEncounterSet(EncounterSet.TheGreatGoblinNightmare);
            AddEncounterSet(EncounterSet.WesternLands);
            AddEncounterSet(EncounterSet.OverTheMistyMountainsGrimNightmare);

            RemoveMistyMountainGoblinsForEasyMode();
            RemoveWesternLandsForEasyMode();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class DungeonsDeepAndCavernsDim : TheHobbitOverHillScenario
    {
        public DungeonsDeepAndCavernsDim()
        {
            SagaExpansion("Dungeons Deep and Caverns Dim", "The Hobbit: Over Hill and Under Hill", 3);

            AddQuestCardId("Out-of-the-Frying-Pan-THOHaUH");
            AddQuestCardId("Riddles-in-the-Dark-THOHaUH");
            AddQuestCardId("Into-the-Fire-THOHaUH");

            AddEncounterSet(EncounterSet.DungeonsDeepAndCavernsDim);
            AddEncounterSet(EncounterSet.MistyMountainGoblins);
            AddEncounterSet(EncounterSet.DungeonsDeepAndCavernsDimNightmare);

            RemoveMistyMountainGoblinsForEasyMode();
        }
    }
}
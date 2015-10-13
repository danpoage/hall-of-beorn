using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class WeMustAwayEreBreakOfDay : TheHobbitOverHillScenario
    {
        public WeMustAwayEreBreakOfDay()
        {
            SagaExpansion("We Must Away Ere Break of Day", "The Hobbit: Over Hill and Under Hills", 1);

            AddQuestCardId("An-Unexpected-Party-THOHaUH");
            AddQuestCardId("Roast-Mutton-THOHaUH");
            AddQuestCardId("Dawn-Take-You-All-THOHaUH");

            AddEncounterSet(EncounterSet.WeMustAwayEreBreakOfDay);
            AddEncounterSet(EncounterSet.WesternLands);
            AddEncounterSet(EncounterSet.WeMustAwayEreBreakOfDayNightmare);

            RemoveWesternLandsForEasyMode();
        }
    }
}
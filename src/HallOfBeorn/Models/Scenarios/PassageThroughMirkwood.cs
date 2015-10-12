using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class PassageThroughMirkwood : CoreSetScenario
    {
        public PassageThroughMirkwood()
            : base("Passage Through Mirkwood", 1)
        {
            AddEncounterSet(EncounterSet.PassageThroughMirkwood);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.PassageThroughMirkwoodNightmare);

            AddQuestCardId("Flies-and-Spiders-Core");
            AddQuestCardId("A-Fork-in-the-Road");
            AddQuestCardId("A-Chosen-Path-Don't-Leave-the-Path-Core");
            AddQuestCardId("A-Chosen-Path-Beorn's-Path-Core");

            ExcludeDolGuldurOrcsForEasyMode();
            ExcludeSpidersOfMirkwoodForEasyMode();

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 3);
            ExcludeFromNightmareMode("Black-Forest-Bats-Core", 1);
            ExcludeFromNightmareMode("Forest-Gate-Core", 2);
            ExcludeFromNightmareMode("Forest-Spider-Core", 3);
            ExcludeFromNightmareMode("Old-Forest-Road-Core", 1);
            ExcludeFromNightmareMode("Caught-in-a-Web-Core", 2);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
            ExcludeFromNightmareMode("Ungoliant's-Spawn-Core", 1);
        }
    }
}
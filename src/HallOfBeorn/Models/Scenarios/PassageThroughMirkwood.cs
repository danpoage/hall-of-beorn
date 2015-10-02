using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class PassageThroughMirkwood : CoreSetScenario
    {
        public PassageThroughMirkwood()
        {
            Number = 1;
            Title = "Passage Through Mirkwood";

            AddQuestCardId("Flies-and-Spiders-Core");
            AddQuestCardId("A-Fork-in-the-Road");
            AddQuestCardId("A-Chosen-Path-Don't-Leave-the-Path-Core");
            AddQuestCardId("A-Chosen-Path-Beorn's-Path-Core");

            ExcludeDolGuldurOrcsForEasyMode();
            ExcludeSpidersOfMirkwoodForEasyMode();

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Core", 3);
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
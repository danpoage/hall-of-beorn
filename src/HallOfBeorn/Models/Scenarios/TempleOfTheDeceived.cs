using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TempleOfTheDeceived : DreamChaserScenario
    {
        public TempleOfTheDeceived()
        {
            Title = "Temple of the Deceived";
            ProductName = "Temple of the Deceived";
            GroupName = "Dream-chaser";
            Number = 3;

            AddEncounterSet(EncounterSet.TempleOfTheDeceived);
            AddEncounterSet(EncounterSet.RuinsOfNumenor);
            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            
            AddQuestCardId("Searching-the-Island-TotD");
            
            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromEasyMode("Island-Watcher-TotD", 2);
            ExcludeFromEasyMode("Furious-Rainstorm-TotD", 1);
        }
    }
}
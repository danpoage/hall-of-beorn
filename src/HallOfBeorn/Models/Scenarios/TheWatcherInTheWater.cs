using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheWatcherInTheWater : KhazadDumScenario
    {
        public TheWatcherInTheWater()
        {
            AdventurePack("The Watcher in the Water", "Dwarrowdelf", 3);

            AddEncounterSet(EncounterSet.TheWatcherInTheWater);
            AddEncounterSet(EncounterSet.MistyMountains);
            AddEncounterSet(EncounterSet.TheWatcherInTheWaterNightmare);
        }
    }
}
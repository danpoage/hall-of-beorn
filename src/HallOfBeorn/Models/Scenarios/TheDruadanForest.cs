using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheDruadanForest : HeirsOfNumenorScenario
    {
        public TheDruadanForest()
        {
            AdventurePack("The Drúadan Forest", "Against the Shadow", 2);

            AddEncounterSet(EncounterSet.TheDruadanForest);
            AddEncounterSet(EncounterSet.BroodingForest);
            AddEncounterSet(EncounterSet.TheDruadanForestNightmare);
        }
    }
}
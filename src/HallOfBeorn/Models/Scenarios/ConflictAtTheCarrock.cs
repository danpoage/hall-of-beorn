using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class ConflictAtTheCarrock : CoreSetScenario
    {
        public ConflictAtTheCarrock()
        {
            AdventurePack("Conflict at the Carrock", "Shadows of Mirkwood", 2);

            AddEncounterSet(EncounterSet.ConflictAtTheCarrock);
            AddEncounterSet(EncounterSet.Wilderlands);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.ConflictAtTheCarrockNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class ReturnToMirkwood : CoreSetScenario
    {
        public ReturnToMirkwood()
        {
            AdventurePack("Return to Mirkwood", "Shadows of Mirkwood", 6);

            AddEncounterSet(EncounterSet.ReturnToMirkwood);
            AddEncounterSet(EncounterSet.Wilderlands);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.ReturnToMirkwoodNightmare);
        }
    }
}
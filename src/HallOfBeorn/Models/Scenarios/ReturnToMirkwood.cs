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
            Title = "Return to Mirkwood";
            ProductName = "Return to Mirkwood";
            GroupName = "Shadows of Mirkwood";
            Number = 6;

            AddEncounterSet(EncounterSet.ReturnToMirkwood);
            AddEncounterSet(EncounterSet.Wilderlands);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.ReturnToMirkwoodNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheDeadMarshes : CoreSetScenario
    {
        public TheDeadMarshes()
        {
            AdventurePack("The Dead Marshes", "Shadows of Mirkwood", 5);

            AddEncounterSet(EncounterSet.TheDeadMarshes);
            AddEncounterSet(EncounterSet.Wilderlands);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheDeadMarshesNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class PerilInPelargir : HeirsOfNumenorScenario
    {
        public PerilInPelargir()
        {
            DeluxeExpansion("Peril in Pelargir", "Heirs of Númenor", 1);

            AddEncounterSet(EncounterSet.PerilInPelargir);
            AddEncounterSet(EncounterSet.StreetsOfGondor);
            AddEncounterSet(EncounterSet.Brigands);
            AddEncounterSet(EncounterSet.PerilInPelargirNightmare);
        }
    }
}
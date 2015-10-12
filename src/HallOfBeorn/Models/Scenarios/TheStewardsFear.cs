using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheStewardsFear : HeirsOfNumenorScenario
    {
        public TheStewardsFear()
        {
            AdventurePack("The Steward's Fear", "Against the Shadow", 1);

            AddEncounterSet(EncounterSet.TheStewardsFear);
            AddEncounterSet(EncounterSet.Brigands);
            AddEncounterSet(EncounterSet.StreetsOfGondor);
            AddEncounterSet(EncounterSet.TheStewardsFearNightmare);
        }
    }
}
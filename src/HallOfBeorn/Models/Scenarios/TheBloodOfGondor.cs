using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheBloodOfGondor : HeirsOfNumenorScenario
    {
        public TheBloodOfGondor()
        {
            AdventurePack("The Blood of Gondor", "Against the Shadow", 5);

            AddEncounterSet(EncounterSet.TheBloodOfGondor);
            AddEncounterSet(EncounterSet.RavagingOrcs);
            AddEncounterSet(EncounterSet.TheBloodOfGondorNightmare);
        }
    }
}
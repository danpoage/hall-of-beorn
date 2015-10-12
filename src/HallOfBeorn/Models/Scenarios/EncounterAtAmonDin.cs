using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class EncounterAtAmonDin : HeirsOfNumenorScenario
    {
        public EncounterAtAmonDin()
        {
            AdventurePack("Encounter at Amon Dîn", "Against the Shadow", 3);

            AddEncounterSet(EncounterSet.EncounterAtAmonDin);
            AddEncounterSet(EncounterSet.RavagingOrcs);
            AddEncounterSet(EncounterSet.EncounterAtAmonDinNightmare);
        }
    }
}
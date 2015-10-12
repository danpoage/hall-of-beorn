using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class IntrudersInChetwood : TheLostRealmScenario
    {
        public IntrudersInChetwood()
        {
            DeluxeExpansion("Intruders in Chetwood", "The Lost Realm", 1);

            AddQuestCardId("Stop-the-War-Party-TLR");

            AddEncounterSet(EncounterSet.IntrudersInChetwood);
            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.Iarion);
        }
    }
}
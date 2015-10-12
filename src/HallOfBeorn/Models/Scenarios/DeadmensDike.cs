using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class DeadmensDike : TheLostRealmScenario
    {
        public DeadmensDike()
        {
            DeluxeExpansion("Deadmen's Dike", "The Lost Realm", 3);

            AddQuestCardId("The-Shades-of-Angmar-TLR");
            AddQuestCardId("A-Fell-Wraith-TLR");

            AddEncounterSet(EncounterSet.DeadmensDike);
            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.DarkSorcery);
            AddEncounterSet(EncounterSet.Iarion);
        }
    }
}
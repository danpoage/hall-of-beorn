using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheFordsOfIsen : TheVoiceOfIsengardScenario
    {
        public TheFordsOfIsen()
            : base(true)
        {
            DeluxeExpansion("The Fords of Isen", "The Voice of Isengard", 1);

            AddEncounterSet(EncounterSet.TheFordsOfIsen);
            AddEncounterSet(EncounterSet.DunlandRaiders);
            AddEncounterSet(EncounterSet.DunlandWarriors);
            AddEncounterSet(EncounterSet.TheFordsOfIsenNightmare);
        }
    }
}
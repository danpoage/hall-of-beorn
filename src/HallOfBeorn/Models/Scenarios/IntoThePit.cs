using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class IntoThePit : KhazadDumScenario
    {
        public IntoThePit()
        {
            DeluxeExpansion("Into the Pit", "Khazad-dûm", 1);
            
            AddEncounterSet(EncounterSet.IntoThePit);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.TwistsAndTurns);
            AddEncounterSet(EncounterSet.IntoThePitNightmare);
        }
    }
}
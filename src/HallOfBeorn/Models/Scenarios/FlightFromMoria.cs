using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class FlightFromMoria : KhazadDumScenario
    {
        public FlightFromMoria()
        {
            Title = "Flight from Moria";
            Number = 3;

            AddEncounterSet(EncounterSet.FlightFromMoria);
            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.PlunderingGoblins);
            AddEncounterSet(EncounterSet.FlightFromMoriaNightmare);
        }
    }
}
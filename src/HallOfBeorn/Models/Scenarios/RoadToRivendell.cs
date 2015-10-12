using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class RoadToRivendell : KhazadDumScenario
    {
        public RoadToRivendell()
        {
            AdventurePack("Road to Rivendell", "Dwarrowdelf", 2);
            
            AddEncounterSet(EncounterSet.RoadToRivendell);
            AddEncounterSet(EncounterSet.MistyMountains);
            AddEncounterSet(EncounterSet.PlunderingGoblins);
            AddEncounterSet(EncounterSet.RoadToRivendellNightmare);
        }
    }
}
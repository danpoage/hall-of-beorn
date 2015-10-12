using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheRedhornGate : KhazadDumScenario
    {
        public TheRedhornGate()
        {
            AdventurePack("The Redhorn Gate", "Dwarrowdelf", 1);
            
            AddEncounterSet(EncounterSet.TheRedhornGate);
            AddEncounterSet(EncounterSet.MistyMountains);
        }
    }
}
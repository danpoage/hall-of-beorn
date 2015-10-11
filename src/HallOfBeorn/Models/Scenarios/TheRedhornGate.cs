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
            Title = "The Redhorn Gate";
            ProductName = "The Redhorn Gate";
            GroupName = "Dwarrowdelf";

            AddEncounterSet(EncounterSet.TheRedhornGate);
            AddEncounterSet(EncounterSet.MistyMountains);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class ShadowAndFlame : KhazadDumScenario
    {
        public ShadowAndFlame()
        {
            AdventurePack("Shadow and Flame", "Dwarrowdelf", 6);

            AddEncounterSet(EncounterSet.ShadowAndFlame);
            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.ShadowAndFlameNightmare);
        }
    }
}
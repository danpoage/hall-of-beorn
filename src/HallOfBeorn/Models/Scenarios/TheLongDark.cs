using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheLongDark : KhazadDumScenario
    {
        public TheLongDark()
        {
            AdventurePack("The Long Dark", "Dwarrowdelf", 4);

            AddEncounterSet(EncounterSet.TheLongDark);
            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.TwistsAndTurns);
            AddEncounterSet(EncounterSet.TheLongDarkNightmare);
        }
    }
}
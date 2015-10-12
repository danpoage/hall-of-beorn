using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheHillsOfEmynMuil : CoreSetScenario
    {
        public TheHillsOfEmynMuil()
        {
            AdventurePack("The Hills of Emyn Muil", "Shadows of Mirkwood", 4);

            AddEncounterSet(EncounterSet.TheHillsOfEmynMuil);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuilNightmare);
        }
    }
}
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
            Title = "The Hills of Emyn Muil";
            ProductName = "The Hills of Emyn Muil";
            GroupName = "Shadows of Mirkwood";
            Number = 4;

            AddEncounterSet(EncounterSet.TheHillsOfEmynMuil);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuilNightmare);
        }
    }
}
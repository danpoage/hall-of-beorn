using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class AssaultOnOsgiliath : HeirsOfNumenorScenario
    {
        public AssaultOnOsgiliath()
        {
            AdventurePack("Assault on Osgiliath", "Against the Shadow", 4);

            AddEncounterSet(EncounterSet.AssaultOnOsgiliath);
            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.Southrons);
            AddEncounterSet(EncounterSet.AssaultOnOsgiliathNightmare);
        }
    }
}
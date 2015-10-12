using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheMorgulVale : HeirsOfNumenorScenario
    {
        public TheMorgulVale()
        {
            AdventurePack("The Morgul Vale", "Against the Shadow", 6);

            AddEncounterSet(EncounterSet.TheMorgulVale);
            AddEncounterSet(EncounterSet.CreaturesOfTheForest);
            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.TheMorgulValeNightmare);
        }
    }
}
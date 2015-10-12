using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class IntoFangorn : TheVoiceOfIsengardScenario
    {
        public IntoFangorn()
            : base(true)
        {
            DeluxeExpansion("Into Fangorn", "The Voice of Isengard", 3);

            AddEncounterSet(EncounterSet.IntoFangorn);
            AddEncounterSet(EncounterSet.AncientForest);
            AddEncounterSet(EncounterSet.WearyTravelers);
            AddEncounterSet(EncounterSet.IntoFangornNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class ToCatchAnOrc : TheVoiceOfIsengardScenario
    {
        public ToCatchAnOrc()
            : base(true)
        {
            DeluxeExpansion("To Catch an Orc", "The Voice of Isengard", 2);

            AddEncounterSet(EncounterSet.ToCatchAnOrc);
            AddEncounterSet(EncounterSet.BrokenLands);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);
            AddEncounterSet(EncounterSet.ToCatchAnOrcNightmare);
        }
    }
}
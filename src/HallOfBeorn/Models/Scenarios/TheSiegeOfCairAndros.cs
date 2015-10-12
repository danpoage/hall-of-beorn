using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheSiegeOfCairAndros : HeirsOfNumenorScenario
    {
        public TheSiegeOfCairAndros()
        {
            DeluxeExpansion("The Siege of Cair Andros", "Heirs of Númenor", 3);

            AddEncounterSet(EncounterSet.TheSiegeOfCairAndros);
            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.RavagingOrcs);
            AddEncounterSet(EncounterSet.Southrons);
            AddEncounterSet(EncounterSet.TheSiegeOfCairAndrosNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheSeventhLevel : KhazadDumScenario
    {
        public TheSeventhLevel()
        {
            DeluxeExpansion("The Seventh Level", "Khazad-dûm", 2);

            AddEncounterSet(EncounterSet.TheSeventhLevel);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.PlunderingGoblins);
            AddEncounterSet(EncounterSet.TheSeventhLevelNightmare);
        }
    }
}
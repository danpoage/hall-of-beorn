using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class FoundationsOfStone : KhazadDumScenario
    {
        public FoundationsOfStone()
        {
            AdventurePack("Foundations of Stone", "Dwarrowdelf", 5);

            AddEncounterSet(EncounterSet.FoundationsOfStone);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeepNightmare);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.TwistsAndTurns);
            AddEncounterSet(EncounterSet.FoundationsOfStoneNightmare);
        }
    }
}
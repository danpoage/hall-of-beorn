using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class IntoIthilien : HeirsOfNumenorScenario
    {
        public IntoIthilien()
        {
            DeluxeExpansion("Into Ithilien", "Heirs of Númenor", 2);

            AddEncounterSet(EncounterSet.IntoIthilien);
            AddEncounterSet(EncounterSet.BroodingForest);
            AddEncounterSet(EncounterSet.CreaturesOfTheForest);
            AddEncounterSet(EncounterSet.Southrons);
            AddEncounterSet(EncounterSet.IntoIthilienNightmare);
        }
    }
}
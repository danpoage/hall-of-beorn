using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class AJourneyToRhosgobel : CoreSetScenario
    {
        public AJourneyToRhosgobel()
        {
            AdventurePack("A Journey to Rhosgobel", "Shadows of Mirkwood", 3);

            AddEncounterSet(EncounterSet.AJourneyToRhosgobel);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.AJourneyToRhosgobelNightmare);
        }
    }
}
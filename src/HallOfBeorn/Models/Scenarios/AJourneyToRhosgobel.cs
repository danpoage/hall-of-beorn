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
            Title = "A Journey to Rhosgobel";
            ProductName = "A Journey to Rhosgobel";
            GroupName = "Shadows of Mirkwood";
            Number = 3;

            AddEncounterSet(EncounterSet.AJourneyToRhosgobel);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.AJourneyToRhosgobelNightmare);
        }
    }
}
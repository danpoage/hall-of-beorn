using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class EscapeFromMountGram : TheLostRealmScenario
    {
        public EscapeFromMountGram()
        {
            AdventurePack("Escape from Mount Gram", "Angmar Awakened", 2);

            AddQuestCardId("Unexpected-Rescue-EfMG");
            AddQuestCardId("Gornakh's-Dungeons-EfMG");
            AddQuestCardId("Flight-from-Mount-Gram-EfMG");

            AddEncounterSet(EncounterSet.EscapeFromMountGram);
            AddEncounterSet(EncounterSet.AngmarOrcs);
        }
    }
}
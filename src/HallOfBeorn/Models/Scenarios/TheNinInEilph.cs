using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheNinInEilph : TheVoiceOfIsengardScenario
    {
        public TheNinInEilph()
        {
            AdventurePack("The Nîn-in-Eilph", "The Ring-maker", 4);

            AddQuestCardId("Fleeing-from-Tharbad-NiE");
            AddQuestCardId("Through-the-Marsh-No-End-in-Sight-NiE");
            AddQuestCardId("Through-the-Marsh-A-Weary-Passage-NiE");
            AddQuestCardId("Through-the-Marsh-A-Forgotten-Land-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Impassable-Marshland-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-A-Treacherous-Swamp-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Creatures-of-a-Forgotten-Age-NiE");
            AddQuestCardId("Out-of-the-Swamp-NiE");

            AddEncounterSet(EncounterSet.TheNinInEilph);
            AddEncounterSet(EncounterSet.WearyTravelers);
        }
    }
}
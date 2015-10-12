using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TroubleInTharbad : TheVoiceOfIsengardScenario
    {
        public TroubleInTharbad()
        {
            AdventurePack("Trouble in Tharbad", "The Ring-maker", 3);

            AddQuestCardId("Double-Dealings-TiT");
            AddQuestCardId("Escape-from-Tharbad-TiT");

            AddEncounterSet(EncounterSet.TroubleInTharbad);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class JourneyAlongTheAnduin : CoreSetScenario
    {
        public JourneyAlongTheAnduin()
            : base("Journey Along the Anduin", 2)
        {
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.Wilderlands);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinNightmare);

            AddQuestCardId("To-the-River-Core");
            AddQuestCardId("Anduin-Passage-Core");
            AddQuestCardId("Ambush-on-the-Shore");

            ExcludeDolGuldurOrcsForEasyMode();
            ExcludeSauronsReachForEasyMode();
            ExcludeWilderlandsForEasyMode();

            ExcludeFromEasyMode("Gladden-Fields", 2);
            ExcludeFromEasyMode("Massing-at-Night", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Core", 3);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 3);
            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("Despair-Core", 2);
        }
    }
}
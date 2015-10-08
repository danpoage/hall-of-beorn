using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class EscapeFromDolGuldur : CoreSetScenario
    {
        public EscapeFromDolGuldur()
        {
            Number = 3;
            Title = "Escape from Dol Guldur";

            AddEncounterSet(EncounterSet.EscapeFromDolGuldur);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.EscapeFromDolGuldurNightmare);

            AddQuestCardId("The-Necromancer's-Tower-Core");
            AddQuestCardId("Through-the-Caverns-Core");
            AddQuestCardId("Out-of-the-Dungeons-Core");

            ExcludeSpidersOfMirkwoodForEasyMode();
            ExcludeDolGuldurOrcsForEasyMode();

            ExcludeFromEasyMode("Dungeon-Jailor-Core", 2);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Core", 2);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 1);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-Core", 1);
            ExcludeFromNightmareMode("Iron-Shackles-Core", 1);
            ExcludeFromNightmareMode("Tower-Gate-Core", 2);
            ExcludeFromNightmareMode("Under-the-Shadow-Core", 2);
            ExcludeFromNightmareMode("Caught-in-a-Web-Core", 2);
            ExcludeFromNightmareMode("Great-Forest-Web-Core", 1);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
        }
    }
}
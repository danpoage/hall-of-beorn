using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class TheDreadRealm : AngmarAwakenedScenario
    {
        public TheDreadRealm()
        {
            Title = "The Dread Realm";
            ProductName = "The Dread Realm";
            GroupName = "Angmar Awakened";
            Number = 6;

            QuestCompanionSlug = "angmar-awakened-quest-the-dread-realm";
            DifficultyRating = 8.1f;
            Votes = 16;

            AddTheLineUnbrokenLink("51", "3tYbgyWscpU");
            AddMrUnderhillLink(Title + " Nightmare Mode", "IzE6Gd5-lhg");

            AddEncounterSet(EncounterSet.TheDreadRealm);
            AddEncounterSet(EncounterSet.TheDreadRealmNightmare);
            AddEncounterSet(EncounterSet.DarkSorcery);
            AddEncounterSet(EncounterSet.CursedDead);

            AddQuestCardId("The-Catacombs-of-Carn-Dum-TDR");
            AddQuestCardId("Angmar-Awakened-TDR");
            AddQuestCardId("Daechanar's-Fall-TDR");

            ExcludeDarkSorceryFromEasyMode();
            ExcludeCursedDeadFromEasyMode();

            ExcludeFromEasyMode("Dwimmerlaik-TDR", 2);
            ExcludeFromEasyMode("Witch-of-Angmar-TDR", 1);
            ExcludeFromEasyMode("Tombs-of-Carn-Dum-TDR", 3);
            ExcludeFromEasyMode("Possession-TDR", 2);
            ExcludeFromEasyMode("Death-and-Calamity-TDR", 2);

            ExcludeFromNightmareMode("Witch-of-Angmar-TDR", 3);
            ExcludeFromNightmareMode("A-Fell-Dread-TDR", 2);
            ExcludeFromNightmareMode("Unholy-Crypt-TDR", 1);
            ExcludeFromNightmareMode("Sinister-Dungeon-TDR", 1);
            ExcludeFromNightmareMode("Dead-Lord-TLR", 2);
            ExcludeFromNightmareMode("Terror-of-the-North-TLR", 3);
        }
    }
}
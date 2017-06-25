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

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/angmar-awakened-quest-the-dread-realm.html";

            AddEncounterSet(EncounterSet.TheDreadRealm);
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
        }
    }
}
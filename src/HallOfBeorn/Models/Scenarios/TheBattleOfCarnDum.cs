using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheBattleOfCarnDum : AngmarAwakenedScenario
    {
        public TheBattleOfCarnDum()
        {
            Title = "The Battle of Carn Dûm";
            ProductName = "The Battle of Carn Dûm";
            GroupName = "Angmar Awakened";
            Number = 5;

            AddEncounterSet(EncounterSet.TheBattleOfCarnDum);
            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.DarkSorcery);

            AddQuestCardId("The-Clutches-of-Carn-Dum-TBoCD");
            AddQuestCardId("Midwinter's-Crux-TBoCD");

            ExcludeAngmarOrcsFromEasyMode();
            ExcludeDarkSorceryFromEasyMode();

            ExcludeFromEasyMode("Carn-Dum-Garrison-TBoCD", 1);
            ExcludeFromEasyMode("Orc-Grunts-TBoCD", 2);
            ExcludeFromEasyMode("Werewolf-of-Angmar-TBoCD", 2);
            ExcludeFromEasyMode("Fortress-Walls-TBoCD", 2);
            ExcludeFromEasyMode("The-Sky-Darkens-TBoCD", 2);
            ExcludeFromEasyMode("Daechanar's-Will-TBoCD", 1);
        }
    }
}
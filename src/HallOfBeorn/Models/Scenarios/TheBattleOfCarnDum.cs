using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheBattleOfCarnDum : Scenario
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

            ExcludeFromEasyMode("Carn-Dum-Garrison-TBoCD", 1);
            ExcludeFromEasyMode("Orc-Grunts-TBoCD", 2);
            ExcludeFromEasyMode("Werewolf-of-Angmar-TBoCD", 2);
        }
    }
}
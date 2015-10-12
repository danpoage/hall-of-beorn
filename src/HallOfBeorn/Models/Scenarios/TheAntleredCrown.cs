using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheAntleredCrown : TheVoiceOfIsengardScenario
    {
        public TheAntleredCrown()
        {
            AdventurePack("The Antlered Crown", "The Ring-maker", 6);

            AddQuestCardId("Battle-for-Dunland-TAC");
            AddQuestCardId("The-Raven-Clan-TAC");
            AddQuestCardId("The-Last-Stage-TAC");

            AddEncounterSet(EncounterSet.TheAntleredCrown);
            AddEncounterSet(EncounterSet.DunlandRaiders);
            AddEncounterSet(EncounterSet.DunlandWarriors);
        }
    }
}
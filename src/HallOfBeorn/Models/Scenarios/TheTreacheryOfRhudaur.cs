using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheTreacheryOfRhudaur : TheLostRealmScenario
    {
        public TheTreacheryOfRhudaur()
        {
            AdventurePack("The Threachery of Rhudaur", "Angmar Awakened", 4);

            AddQuestCardId("Secret's-of-Rhudaur-TToR");
            AddQuestCardId("Thaurdir's-Pursuit-TToR");

            AddEncounterSet(EncounterSet.TheTreacheryOfRhudaur);
            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
        }
    }
}
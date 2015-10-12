using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class CelebrimborsSecret : TheVoiceOfIsengardScenario
    {
        public CelebrimborsSecret()
        {
            AdventurePack("Celebrimbor's Secret", "The Ring-maker", 5);

            AddQuestCardId("The-Ruins-of-Ost-in-Edhil-CS");
            AddQuestCardId("The-Enemy's-Servant-CS");

            AddEncounterSet(EncounterSet.CelebrimborsSecret);
            AddEncounterSet(EncounterSet.BrokenLands);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);
        }
    }
}
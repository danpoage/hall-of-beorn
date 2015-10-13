using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheWastesOfEriador : TheLostRealmScenario
    {
        public TheWastesOfEriador()
        {
            AdventurePack("The Wastes of Eriador", "Angmar Awakened", 1);

            AddQuestCardId("Across-the-Wastes-TWoE");
            AddQuestCardId("Howling-at-Night-TWoE");
            AddQuestCardId("Battle-with-the-Pack-TWoE");

            AddEncounterSet(EncounterSet.TheWastesOfEriador);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class AcrossTheEttenmoors : TheLostRealmScenario
    {
        public AcrossTheEttenmoors()
        {
            AdventurePack("Across the Ettenmoors", "Angmar Awakened", 3);

            AddQuestCardId("Into-the-Ettenmoors-AtE");
            AddQuestCardId("A-Miserable-Journey-AtE");
            AddQuestCardId("Journey's-End-AtE");

            AddEncounterSet(EncounterSet.AcrossTheEttenmoors);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);
        }
    }
}
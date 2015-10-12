using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheWeatherHills : TheLostRealmScenario
    {
        public TheWeatherHills()
        {
            DeluxeExpansion("The Weather Hills", "The Lost Realm", 2);

            AddQuestCardId("Scattered-Among-the-Hills-TLR");
            AddQuestCardId("Cornered-Animals-TLR");

            AddEncounterSet(EncounterSet.TheWeatherHills);
            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.FoulWeather);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
        }
    }
}
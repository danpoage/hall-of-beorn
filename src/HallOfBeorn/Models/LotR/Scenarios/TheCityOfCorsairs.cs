using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheCityOfCorsairs : DreamChaserScenario
    {
        public TheCityOfCorsairs()
        {
            Title = "The City of Corsairs";
            ProductName = "The City of Corsairs";
            GroupName = "Dream-chaser";
            Number = 6;

            AddEncounterSet(EncounterSet.TheCityOfCorsairs);
            AddEncounterSet(EncounterSet.CoastOfUmbar);
            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.StormyWeather);
            AddEncounterSet(EncounterSet.UmbarFleet);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaer);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);

            AddQuestCardId("The-Coast-of-Umbar-TCoC");
            AddQuestCardId("Fate-of-the-Dream-chaser-TCoC");
            AddQuestCardId("The-Haven-of-Umbar-TCoC");
            AddQuestCardId("Final-Confrontation-TCoC");

            ExcludeCorsairRaidersFromEasyMode();
            ExcludeStormyWeatherFromEasyMode();;
            ExcludeUmbarFleetFromEasyMode();

            //ExcludeFromEasyMode("Cave-Eel-TDRu", 1);
            //ExcludeFromEasyMode("Powerful-Undertow-TDRu", 2);
            //ExcludeFromEasyMode("Ancient-Depths-TDRu", 2);
        }
    }
}
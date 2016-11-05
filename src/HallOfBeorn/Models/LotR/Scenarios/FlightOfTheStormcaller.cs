using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class FlightOfTheStormcaller : DreamChaserScenario
    {
        public FlightOfTheStormcaller()
        {
            Title = "Flight of the Stormcaller";
            ProductName = "Flight of the Stormcaller";
            GroupName = "Dream-chaser";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-dream-chaser-quest-flight-of-the-stormcaller.html";

            AddEncounterSet(EncounterSet.VastOceans);
            AddEncounterSet(EncounterSet.StormyWeather);
            AddEncounterSet(EncounterSet.CorsairPirates);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);
            AddEncounterSet(EncounterSet.FlightOfTheStormcaller);

            AddQuestCardId("Swift-Departure-FotS");
            AddQuestCardId("Full-Sail-Ahead-AB-FotS");
            AddQuestCardId("Full-Sail-Ahead-CD-FotS");
            AddQuestCardId("The-Weather-Turns-Foul-AB-FotS");
            AddQuestCardId("The-Weather-Turns-Foul-CD-FotS");
            AddQuestCardId("The-Cape-of-Andrast-AB-FotS");
            AddQuestCardId("The-Cape-of-Andrast-CD-FotS");

            ExcludeVastOceansFromEasyMode();
            ExcludeStormyWeatherFromEasyMode();
            ExcludeCorsairPiratesFromEasyMode();

            ExcludeFromEasyMode("Sahir's-Escort-FotS", 1);
            ExcludeFromEasyMode("Swift-Raider-FotS", 1);
            ExcludeFromEasyMode("Serpent's-Blade-FotS", 1);
            ExcludeFromEasyMode("Vast-Coastland-FotS", 1);
            ExcludeFromEasyMode("Raging-Squall-FotS", 1);
        }
    }
}
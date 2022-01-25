using System;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class FlightOfTheStormcallerScenario : DreamChaserScenarioScenario
    {
        public FlightOfTheStormcallerScenario()
        {
            Title = "Flight of the Stormcaller";
            ProductName = "Flight of the Stormcaller";
            GroupName = "Dream-chaser";
            Number = 1;

            QuestCompanionSlug = "the-dream-chaser-quest-flight-of-the-stormcaller";
            DifficultyRating = 6.1f;
            Votes = 17;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/06/08/flight-of-the-stormcaller/");

            AddEncounterSet(EncounterSet.VastOceans);
            AddEncounterSet(EncounterSet.StormyWeather);
            AddEncounterSet(EncounterSet.CorsairPirates);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);
            AddEncounterSet(EncounterSet.FlightOfTheStormcaller);
            AddEncounterSet(EncounterSet.FlightOfTheStormcallerNightmare);

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

            ExcludeFromNightmareMode("Calm-Waters-TGH", 2);
            ExcludeFromNightmareMode("Corsair-Skiff-FotS", 2);
            ExcludeFromNightmareMode("Southron-Sailors-TGH", 2);
            ExcludeFromNightmareMode("Serpent's-Blade-FotS", 2);
            ExcludeFromNightmareMode("Hidden-Cove-FotS", 1);
            ExcludeFromNightmareMode("Jagged-Reef-FotS", 2);
        }
    }
}
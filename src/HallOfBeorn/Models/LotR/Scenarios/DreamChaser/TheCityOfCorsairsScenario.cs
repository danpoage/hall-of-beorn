﻿using System;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class TheCityOfCorsairsScenario : DreamChaserScenarioScenario
    {
        public TheCityOfCorsairsScenario()
        {
            Title = "The City of Corsairs";
            ProductName = "The City of Corsairs";
            GroupName = "Dream-chaser";
            Number = 6;

            QuestCompanionSlug = "the-dream-chaser-quest-the-city-of-corsairs";
            DifficultyRating = 7.2f;
            Votes = 12;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/07/23/the-city-of-corsairs/");

            AddEncounterSet(EncounterSet.TheCityOfCorsairs);
            AddEncounterSet(EncounterSet.CoastOfUmbar);
            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.StormyWeather);
            AddEncounterSet(EncounterSet.UmbarFleet);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaer);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);
            AddEncounterSet(EncounterSet.TheCityOfCorsairsNightmare);
            AddEncounterSet(EncounterSet.CoastOfUmbarNightmare);

            AddQuestCardId("The-Coast-of-Umbar-TCoC");
            AddQuestCardId("Fate-of-the-Dream-chaser-TCoC");
            AddQuestCardId("The-Haven-of-Umbar-TCoC");
            AddQuestCardId("Final-Confrontation-TCoC");

            ExcludeCorsairRaidersFromEasyMode();
            ExcludeStormyWeatherFromEasyMode();;
            ExcludeUmbarFleetFromEasyMode();

            ExcludeFromEasyMode("Slave-Ship-TCoC", 1);
            ExcludeFromEasyMode("Umbar-Slaver-TCoC", 2);
            ExcludeFromEasyMode("Corsair-Waters-TCoC", 1);
            ExcludeFromEasyMode("Watch-Tower-TCoC", 1);
            ExcludeFromEasyMode("City-of-Corsairs-TCoC", 1);
            ExcludeFromEasyMode("Umbar-Harbor-TCoC", 1);
            ExcludeFromEasyMode("Foes-of-Ecthelion-TCoC", 1);
            ExcludeFromEasyMode("Fury-and-Malice-TCoC", 1);

            ExcludeFromNightmareMode("Corsair-Infiltrator-TGH", 2);
            ExcludeFromNightmareMode("Fog-Bank-TGH", 2);
            ExcludeFromNightmareMode("Starlit-Sea-TGH", 2);
            ExcludeFromNightmareMode("Scouting-Ship-TGH", 2);
            ExcludeFromNightmareMode("Serpent's-Tail-TCoC", 2);
            ExcludeFromNightmareMode("Streets-of-Umbar-TCoC", 1);
        }
    }
}
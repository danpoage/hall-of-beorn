using System;
using System.Collections.Generic;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class WrathAndRuinScenario
        : AShadowInTheEastScenario
    {
        private const string name = "Wrath and Ruin";

        public WrathAndRuinScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 1;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC78.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-wrath-and-ruin";
            DifficultyRating = 6.9f;
            Votes = 10;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2021/04/17/wrath-and-ruin/");

            AddEncounterSet(EncounterSet.WrathAndRuin);
            AddEncounterSet(EncounterSet.EasterlingRaiders);
            AddEncounterSet(EncounterSet.CityOfRhun);

            AddQuestCardId("Inside-the-Walls-WaR");
            AddQuestCardId("Drive-them-Out-WaR");

            ExcludeEasterlingRaidersFromEasyMode();
            ExcludeCityOfRhunFromEasyMode();

            ExcludeFromEasyMode("Easterling-Skirmisher-WaR", 2);
            ExcludeFromEasyMode("Contested-Square-WaR", 1);
            ExcludeFromEasyMode("Makeshift-Fortification-WaR", 1);
            ExcludeFromEasyMode("Captured-Tower-WaR", 1);
            ExcludeFromEasyMode("Fury-WaR", 1);
            ExcludeFromEasyMode("Caught-Off-Guard-WaR", 1);
            ExcludeFromEasyMode("Ulchor's-Revenge-WaR", 1);
        }
    }
}

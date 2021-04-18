using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class TheLandOfSorrowScenario
        : AShadowInTheEastScenario
    {
        private const string name = "The Land of Sorrow";

        public TheLandOfSorrowScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 5;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC82.pdf";
            //RulesImageCount = 2;

            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-the-land-of-sorrow";
            DifficultyRating = 6.7f;
            Votes = 3;

            AddEncounterSet(EncounterSet.TheLandOfSorrow);
            AddEncounterSet(EncounterSet.EasterlingRaiders);
            AddEncounterSet(EncounterSet.RollingPlains);

            AddQuestCardId("Slaves-of-the-Dark-Lord-TLoSo");
            AddQuestCardId("Lead-the-Revolt-TLoSo");

            ExcludeEasterlingRaidersFromEasyMode();
            ExcludeRollingPlainsFromEasyMode();
            ExcludeFromEasyMode("Easterling-Guard-TLoSo", 1);
            ExcludeFromEasyMode("Nurn-Slaver-TLoSo", 1);
            ExcludeFromEasyMode("Watch-Tower-TLoSo", 2);
            ExcludeFromEasyMode("Overseer's-Whip-TLoSo", 1);
            ExcludeFromEasyMode("Cruelty-of-Mordor-TLoSo", 1);
            ExcludeFromEasyMode("Broken-Captives-TLoSo", 1);
        }
    }
}
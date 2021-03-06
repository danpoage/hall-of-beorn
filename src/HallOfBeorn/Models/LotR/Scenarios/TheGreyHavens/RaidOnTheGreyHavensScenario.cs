﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens
{
    public class RaidOnTheGreyHavensScenario : Scenarios.DreamChaser.DreamChaserScenarioScenario
    {
        public RaidOnTheGreyHavensScenario()
        {
            Title = "Raid on the Grey Havens";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 3;

            QuestCompanionSlug = "the-grey-havens-quest-raid-on-the-grey-havens";
            DifficultyRating = 7.6f;
            Votes = 17;

            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/06/27/path-less-traveled-raid-on-the-grey-havens/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/22/warriors-of-the-west-raid-on-the-grey-havens/", Title);

            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            AddEncounterSet(EncounterSet.RaidOnTheGreyHavens);
            AddEncounterSet(EncounterSet.RaidOnTheGreyHavensNightmare);

            AddQuestCardId("The-Corsairs'-Assault-TGH");
            AddQuestCardId("Sahir's-Advance-TGH");

            ExcludeFromEasyMode("Sahir's-Ravager-TGH", 2);
            ExcludeFromEasyMode("Mithlond-Harbor-TGH", 1);
            ExcludeFromEasyMode("White-Ship-TGH", 1);
            ExcludeFromEasyMode("Elven-Caravel-TGH", 1);

            ExcludeCorsairRaidersFromEasyMode();
            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromNightmareMode("Sahir's-Advance-TGH", 1);
            ExcludeFromNightmareMode("Corsair-Arsonist-TGH", 3);
            ExcludeFromNightmareMode("Elven-Wave-runner-TGH", 2);
            ExcludeFromNightmareMode("Umbar-Raider-TGH", 1);
        }
    }
}
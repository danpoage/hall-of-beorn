﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens
{
    public class TheFateOfNumenorScenario : Scenarios.DreamChaser.DreamChaserScenarioScenario
    {
        public TheFateOfNumenorScenario()
        {
            Title = "The Fate of Númenor";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 2;

            QuestCompanionSlug = "the-grey-havens-quest-the-fate-of-numenor";
            DifficultyRating = 4.2f;
            Votes = 19;

            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/06/17/path-less-traveled-the-fate-of-numenor/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/09/warriors-of-the-west-the-fate-of-numenor/", Title);
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2017/10/12/nightmare-review-the-fate-of-numenor/", "Nightmare " + Title);
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/03/07/the-fate-of-numenor/");

            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.RuinsOfNumenor);
            AddEncounterSet(EncounterSet.TheFateOfNumenor);
            AddEncounterSet(EncounterSet.TheFateOfNumenorNightmare);

            AddQuestCardId("Explore-the-Island-TGH");
            AddQuestCardId("A-Fateful-Discovery-TGH");

            ExcludeFromEasyMode("Servant-of-the-Deceiver-TGH", 1);
            ExcludeFromEasyMode("Lingering-Malevolence-TGH", 1);
            ExcludeFromEasyMode("Ruins-of-Ages-Past-TGH", 1);

            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromNightmareMode("Forbidden-Coast-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Cursed-Temple-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Flooded-Ruins-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Drowned-Graves-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Lush-Jungle-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Shrine-of-Morgoth-Lost-Island-TGH", 1);
            ExcludeFromNightmareMode("Steep-Plateau-TGH", 3);
            ExcludeFromNightmareMode("Aimless-Wandering-TGH", 3);
            ExcludeFromNightmareMode("Mysterious-Fog-TGH", 1);
            ExcludeFromNightmareMode("Servant-of-the-Deceiver-TGH", 1);
            ExcludeFromNightmareMode("Lingering-Malevolence-TGH", 1);
            ExcludeFromNightmareMode("Drowned-Dead-TGH", 1);
        }
    }
}
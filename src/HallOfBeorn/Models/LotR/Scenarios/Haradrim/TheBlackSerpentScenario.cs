﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class TheBlackSerpentScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public TheBlackSerpentScenario()
        {
            Title = "The Black Serpent";
            ProductName = "The Black Serpent";
            GroupName = "Haradrim";
            Number = 4;

            QuestCompanionSlug = "haradrim-cycle-quest-the-black-serpent";
            DifficultyRating = 7.3f;
            Votes = 3;

            AddMrUnderhillLink(Title + " - Fasted / Dúnhere Deck", "6RK7db0rgwY");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2017/09/03/turn-by-turn-report-the-black-serpent/", Title);

            AddEncounterSet(EncounterSet.TheBlackSerpent);
            AddEncounterSet(EncounterSet.HaradSoldiers);

            AddQuestCardId("The-Crossroads-Fort-TBS");
            AddQuestCardId("Battle-in-the-Camp-TBS");
            AddQuestCardId("Defeat-the-Serpent-TBS");

            excludeHaradSoldiers();

            ExcludeFromEasyMode("The-Serpent's-Redoubt-TBS", 1);
            ExcludeFromEasyMode("Roofless-Tower-TBS", 1);
            ExcludeFromEasyMode("Broken-Courtyard-TBS", 1);
            ExcludeFromEasyMode("Bold-and-Grim-TBS", 1);
            ExcludeFromEasyMode("No-Quarter-TBS", 1);
        }
    }
}
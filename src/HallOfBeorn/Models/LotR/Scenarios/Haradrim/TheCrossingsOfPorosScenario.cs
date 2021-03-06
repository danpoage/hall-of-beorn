﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class TheCrossingsOfPorosScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public TheCrossingsOfPorosScenario()
        {
            Title = "The Crossings of Poros";
            ProductName = "The Crossings of Poros";
            GroupName = "Haradrim";
            Number = 6;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/32/39/3239576b-d63a-4b52-a07c-a66453424f63/mec61_web_the_crossing_of_poros-rules.pdf";
            QuestCompanionSlug = "haradrim-cycle-quest-the-crossing-of-poros";
            DifficultyRating = 8.0f;
            Votes = 5;

            AddEncounterSet(EncounterSet.TheCrossingsOfPoros);
            AddEncounterSet(EncounterSet.MountainsOfShadow);
            AddEncounterSet(EncounterSet.DesertSands);
            AddEncounterSet(EncounterSet.DesertCreatures);
            AddEncounterSet(EncounterSet.HaradSoldiers);
            AddEncounterSet(EncounterSet.MordorOrcs);

            AddQuestCardId("Flight-to-Gondor-CoP");
            AddQuestCardId("The-Desert-Path-CoP");
            AddQuestCardId("The-Ephel-Duath-CoP");
            AddQuestCardId("Deadly-Creatures-CoP");
            AddQuestCardId("Southron-Pursuit-CoP");
            AddQuestCardId("Orc-Patrols-CoP");
            AddQuestCardId("Battle-at-the-Crossings-CoP");

            ExcludeFromEasyMode("Desolate-Land-CoP", 2);
            ExcludeFromEasyMode("Danger-Close-Behind-CoP", 1);
            ExcludeFromEasyMode("Foothills-of-Mordor-CoP", 1);
            ExcludeFromEasyMode("Shadowy-Vale-CoP", 1);
            ExcludeFromEasyMode("Mountains-of-Shadow-CoP", 1);

            excludeDesertSands();
            excludeDesertCreatures();
            excludeHaradSoldiers();
            excludeMordorOrcs();

        }
    }
}
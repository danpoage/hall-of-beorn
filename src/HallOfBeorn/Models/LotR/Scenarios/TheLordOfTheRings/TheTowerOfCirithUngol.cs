﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheTowerOfCirithUngol : Scenario
    {
        public TheTowerOfCirithUngol()
        {
            Title = "The Tower of Cirith Ungol";
            ProductName = "The Mountain of Fire";
            GroupName = "The Lord of the Rings";
            Number = 16;

            //QuestCompanionSlug = "http://lotr-lcg-quest-companion.com/.html";

            AddEncounterSet(EncounterSet.TheTowerOfCirithUngol);
            AddEncounterSet(EncounterSet.OrcsOfMordor);
            AddEncounterSet(EncounterSet.DeepShadows);

            AddQuestCardId("Pass-the-Two-Watchers-TMoF");
            AddQuestCardId("Fighting-in-the-Tower-TMoF");
            AddQuestCardId("Escape-from-Cirith-Ungol-TMoF");

            //The Tower of Cirith Ungol
            ExcludeFromEasyMode("Echoing-Passage-TMoF", 2);
            ExcludeFromEasyMode("Gorbag-TMoF", 1);

            //Orcs of Mordor
            ExcludeFromEasyMode("Orc-of-Mordor-TMoF", 1);
            
            //Deep Shadows
            ExcludeFromEasyMode("Drawn-to-the-Ring-TMoF", 1);
            ExcludeFromEasyMode("Deep-Shadows-TMoF", 1);
        }
    }
}
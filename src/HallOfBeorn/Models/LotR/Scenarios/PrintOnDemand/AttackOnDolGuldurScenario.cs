﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class AttackOnDolGuldurScenario : Scenario
    {
        private const string setName = "Attack on Dol Guldur";

        public AttackOnDolGuldurScenario()
        {
            Title = setName;
            AlternateTitle = "Assault on Dol Guldur";
            ProductName = "2017";
            GroupName = ScenarioGroup.FellowshipDecks;
            IsSubGroup = true;
            Number = 8;

            QuestCompanionSlug = "print-on-demand-quest-the-massing-at-osgiliath";
            DifficultyRating = 9.5f;
            Votes = 15;

            AddEncounterSet(EncounterSet.AttackOnDolGuldur);

            AddQuestCardId("Assault-on-the-Golden-Wood-AoDG");
            AddQuestCardId("Crossing-the-Anduin-AoDG");
            AddQuestCardId("The-Siege-of-Dol-Guldur-AoDG");
            AddQuestCardId("The-Tower-of-Sorcery-C-AoDG");
            AddQuestCardId("Battle-Under-the-Trees-E-AoDG");
            AddQuestCardId("Dungeons-of-the-Necromancer-G-AoDG");
        }
    }
}
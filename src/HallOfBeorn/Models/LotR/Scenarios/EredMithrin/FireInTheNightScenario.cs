using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class FireInTheNightScenario : EredMithrinScenario
    {
        private const string name = "Fire in the Night";

        public FireInTheNightScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 6;

            QuestCompanionSlug = "ered-mithrin-quest-fire-in-the-night";
            DifficultyRating = 6.7f;
            Votes = 1;

            AddEncounterSet(EncounterSet.FireInTheNight);
            AddEncounterSet(EncounterSet.GreyMountainGoblins);
            AddEncounterSet(EncounterSet.DarkWoods);
            AddEncounterSet(EncounterSet.GatheringGloom);

            AddQuestCardId("Hrogar's-Hill-FitN");

            ExcludeFromEasyMode("Dragon's-Thrall-FitN", 2);
            ExcludeFromEasyMode("Town-Gate-FitN", 1);
            ExcludeFromEasyMode("Burning-Watchtower-FitN", 2);
            ExcludeFromEasyMode("The-Dragon's-Fury-FitN", 2);
            ExcludeFromEasyMode("Bright-Flames-FitN", 1);

            ExcludeGreyMountainGoblinsFromEasyMode();
            ExcludeDarkWoodsFromEasyMode();
            ExcludeGatheringGloomFromEasyMode();
        }
    }
}
using System;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class TheFortressOfNurnScenario
        : AShadowInTheEastScenario
    {
        private const string name = "The Fortress of Nurn";

        public TheFortressOfNurnScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 6;

            //RulesImageCount = 2;
            //QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-the-fortress-of-nurn";
            DifficultyRating = 9.0f;
            Votes = 1;
            AddEncounterSet(EncounterSet.TheFortressOfNurn);
            AddEncounterSet(EncounterSet.UlchorsGuard);
            AddEncounterSet(EncounterSet.UnderGuard);
            AddEncounterSet(EncounterSet.ThePowerOfMordor);

            AddQuestCardId("Assault-on-Dol-Rhugar-TFoN");
            AddQuestCardId("The-Final-Confrontation-TFoN");

            ExcludeUlchorsGuardFromEasyMode();
            ExcludeUnderGuardFromEasyMode();
            ExcludeFromEasyMode("Easterling-Mercenary-TFoN", 1);
            ExcludeFromEasyMode("Mordor-Olog-hai-TFoN", 1);
            ExcludeFromEasyMode("Guard-Dogs-TFoN", 2);
            ExcludeFromEasyMode("Fortress-Walls-TFoN", 1);
            ExcludeFromEasyMode("Plaza-of-Nurn-TFoN", 1);
            ExcludeFromEasyMode("The-Dark-Lord's-Reach-TFoN", 1);
        }
    }
}
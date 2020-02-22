using System;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public class TheRiverRunningScenario : AShadowInTheEastScenario
    {
        private const string name = "The River Running";

        public TheRiverRunningScenario()
        {
            Title = name;
            ProductName = "A Shadow in the East";
            GroupName = "A Shadow in the East";
            Number = 1;

            RulesImageCount = 10;

            QuestCompanionSlug = "a-shadow-in-the-east-deluxe-expansion-quest-the-river-running";
            DifficultyRating = 7.0f;
            Votes = 6;

            AddEncounterSet(EncounterSet.TheRiverRunning);
            AddEncounterSet(EncounterSet.RidersOfRhun);
            AddEncounterSet(EncounterSet.EasterlingRaiders);
            AddEncounterSet(EncounterSet.RollingPlains);

            AddQuestCardId("Chased-by-Easterlings-ASitE");
            AddQuestCardId("The-Crossing-of-Araw-ASitE");

            ExcludeTheRiverRunningFromEasyMode();
            ExcludeRidersOfRhunFromEasyMode();
            ExcludeEasterlingRaidersFromEasyMode();
            ExcludeRollingPlainsFromEasyMode();
        }
    }
}
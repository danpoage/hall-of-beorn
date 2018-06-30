namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class BreakingOfTheFellowship : Scenario
    {
        public BreakingOfTheFellowship()
        {
            Title = "Breaking of the Fellowship";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 6;

            QuestCompanionSlug = "lotr-the-road-darkens-quest-breaking-of-the-fellowship";
            DifficultyRating = 7.0f;
            Votes = 22;

            AddEncounterSet(EncounterSet.BreakingOfTheFellowship);
            AddEncounterSet(EncounterSet.BreakingOfTheFellowshipNightmare);

            AddQuestCardId("The-Great-River-RD");
            AddQuestCardId("The-Company-Divided-RD");
            AddQuestCardId("Searching-the-Woods-RD");
            AddQuestCardId("Guard-the-Hobbits-RD");
            AddQuestCardId("The-Seat-of-Amon-Hen-RD");
            AddQuestCardId("Orc-Hunting-RD");
            AddQuestCardId("The-Ring-bearer-Sets-Out-RD");

            ExcludeFromEasyMode("Fallen-Into-Evil-RD", 1);
            ExcludeFromEasyMode("Uruk-hai-Archer-RD", 1);
            ExcludeFromEasyMode("Uruk-hai-Captain-RD", 1);
            ExcludeFromEasyMode("Uruk-hai-Hunter-RD", 1);
            ExcludeFromEasyMode("Uruk-hai-Tracker-RD", 1);
            ExcludeFromEasyMode("Wooded-Shoreline-RD", 2);

            ExcludeFromNightmareMode("Uruk-hai-Archer-RD", 4);
            ExcludeFromNightmareMode("River-Anduin-RD", 2);
            ExcludeFromNightmareMode("Slopes-of-Amon-Hen-RD", 1);
            ExcludeFromNightmareMode("Black-Feathered-Arrows-RD", 2);
        }
    }
}

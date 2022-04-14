namespace HallOfBeorn.Models.LotR.Scenarios.ScenarioPack
{
    public class TheHuntForTheDreadnaughtScenario
        : Scenario
    {
        private const string name = "The Hunt for the Dreadnaught";

        public TheHuntForTheDreadnaughtScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = ScenarioGroup.ScenarioPacks;
            IsSubGroup = false;
            Number = 1;

            RulesImageCount = 4;

            QuestCompanionSlug = "standalone-quests-quest-the-hunt-for-the-dreadnaught";
            DifficultyRating = 6.3f;
            Votes = 3;

            AddEncounterSet(EncounterSet.TheHuntForTheDreadnaught);

            AddQuestCardId("Searching-the-High-Seas-THftD");
            AddQuestCardId("Destroy-the-Dreadnaught-THftD");
        }
    }
}
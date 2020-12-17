namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
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

            //QuestCompanionSlug = "print-on-demand-quest-the-stone-of-erech";
            DifficultyRating = 6f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheHuntForTheDreadnaught);

            AddQuestCardId("Searching-the-High-Seas-THftD");
            AddQuestCardId("Destroy-the-Dreadnaught-THftD");
        }
    }
}
namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheBattleOfLakeTownScenario : Scenario
    {
        public TheBattleOfLakeTownScenario()
        {
            Title = "The Battle of Lake-town";
            AlternateTitle = "The Battle of Lake-Town";
            ProductName = "2012";
            GroupName = ScenarioGroup.GenConDecks;
            IsSubGroup = true;
            Number = 2;

            QuestCompanionSlug = "print-on-demand-quest-the-battle-of-laketown";
            DifficultyRating = 8.9f;
            Votes = 44;

            AddTheLineUnbrokenLink("G2", "-m0eaSiyhcQ");

            AddEncounterSet(EncounterSet.TheBattleOfLakeTown);

            AddQuestCardId("Terror-from-the-Mountain-TBoLT");
            AddQuestCardId("Fire-and-Water-TBoLT");
            AddQuestCardId("The-Dragon's-Wrath-TBoLT");
        }
    }
}

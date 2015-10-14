namespace HallOfBeorn.Models.Scenarios
{
    public class TheBattleOfLakeTown : Scenario
    {
        public TheBattleOfLakeTown()
        {
            Title = "The Battle of Lake-town";
            AlternateTitle = "The Battle of Lake-Town";
            ProductName = "The Battle of Lake-town GenCon 2012";
            GroupName = "GenCon";
            Number = 2;

            AddEncounterSet(EncounterSet.TheBattleOfLakeTown);

            AddQuestCardId("Terror-from-the-Mountain-TBoLT");
            AddQuestCardId("Fire-and-Water-TBoLT");
            AddQuestCardId("The-Dragon's-Wrath-TBoLT");
        }
    }
}

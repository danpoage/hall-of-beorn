namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheBattleOfLakeTown : Scenario
    {
        public TheBattleOfLakeTown()
        {
            Title = "The Battle of Lake-town";
            AlternateTitle = "The Battle of Lake-Town";
            ProductName = "2012";
            GroupName = "Gen Con & Fellowship";
            IsSubGroup = true;
            Number = 2;

            QuestCompanionSlug = "print-on-demand-quest-the-battle-of-laketown";

            AddEncounterSet(EncounterSet.TheBattleOfLakeTown);

            AddQuestCardId("Terror-from-the-Mountain-TBoLT");
            AddQuestCardId("Fire-and-Water-TBoLT");
            AddQuestCardId("The-Dragon's-Wrath-TBoLT");
        }
    }
}

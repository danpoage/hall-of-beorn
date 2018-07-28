namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheStoneOfErech : Scenario
    {
        public TheStoneOfErech()
        {
            Title = "The Stone of Erech";
            ProductName = "2013";
            GroupName = "Gen Con & Fellowship";
            IsSubGroup = true;
            Number = 3;

            QuestCompanionSlug = "print-on-demand-quest-the-stone-of-erech";
            DifficultyRating = 6.5f;
            Votes = 27;

            AddTheLineUnbrokenLink("G3", "uEJrbal-c3A");

            AddEncounterSet(EncounterSet.TheStoneOfErech);

            AddQuestCardId("The-Disappearance-TSoE");
            AddQuestCardId("Terror-of-the-Dead-TSoE");
            AddQuestCardId("The-Shadow-Host-TSoE");
        }
    }
}

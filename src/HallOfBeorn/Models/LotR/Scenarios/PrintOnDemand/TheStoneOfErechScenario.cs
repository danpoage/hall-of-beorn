namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheStoneOfErechScenario : Scenario
    {
        public TheStoneOfErechScenario()
        {
            Title = "The Stone of Erech";
            ProductName = "2013";
            GroupName = ScenarioGroup.GenConDecks;
            IsSubGroup = true;
            Number = 3;

            QuestCompanionSlug = "print-on-demand-quest-the-stone-of-erech";
            DifficultyRating = 6.5f;
            Votes = 27;

            AddTheLineUnbrokenLink("G3", "uEJrbal-c3A");
            AddLotRDeckTechLink("Rosie's Spectral Vacation", "4bV5l9g0CO8");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/07/17/the-stone-of-erech/");

            AddEncounterSet(EncounterSet.TheStoneOfErech);

            AddQuestCardId("The-Disappearance-TSoE");
            AddQuestCardId("Terror-of-the-Dead-TSoE");
            AddQuestCardId("The-Shadow-Host-TSoE");
        }
    }
}

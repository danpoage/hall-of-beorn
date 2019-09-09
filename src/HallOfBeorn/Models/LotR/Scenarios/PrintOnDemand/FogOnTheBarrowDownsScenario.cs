namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class FogOnTheBarrowDownsScenario : Scenario
    {
        public FogOnTheBarrowDownsScenario()
        {
            Title = "Fog on the Barrow-downs";
            ProductName = "2014";
            GroupName = "Gen Con & Fellowship";
            Number = 5;

            QuestCompanionSlug = "print-on-demand-quest-fog-on-the-barrow-downs";
            DifficultyRating = 7.8f;
            Votes = 28;

            AddTheLineUnbrokenLink("C1.2/G5", "xXjwG5zCr1g");
            AddTheRoadLink(3, "https://theroadlotr.wordpress.com/fog-on-the-barrow-downs/");

            AddEncounterSet(EncounterSet.FogOnTheBarrowDowns);

            AddQuestCardId("The-House-of-Tom-Bombadil-FotBD");
            AddQuestCardId("Across-the-Downs-FotBD");
            AddQuestCardId("Lost-in-the-Fog-FotBD");
            AddQuestCardId("Trapped-Inside-a-Barrow-FotBD");

            ExcludeFromEasyMode("Ancient-Barrow-FotBD", 1);
            ExcludeFromEasyMode("Barrow-wight-FotBD", 1);
            ExcludeFromEasyMode("Dreadful-Song-FotBD", 1);
            ExcludeFromEasyMode("Frozen-by-Fear-FotBD", 1);
            ExcludeFromEasyMode("Great-Barrow-FotBD", 2);
            ExcludeFromEasyMode("I'm-Waiting-for-You-FotBD", 2);
            ExcludeFromEasyMode("Stone-Ring-FotBD", 1);

        }
    }
}

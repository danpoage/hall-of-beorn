namespace HallOfBeorn.Models.Scenarios
{
    public class FogOnTheBarrowDowns : Scenario
    {
        public FogOnTheBarrowDowns()
        {
            Title = "Fog on the Barrow-downs";
            ProductName = "Fog on the Barrow-downs";
            GroupName = "GenCon";
            Number = 5;

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

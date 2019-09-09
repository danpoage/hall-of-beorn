namespace HallOfBeorn.Models.LotR.Scenarios.FirstAge
{
    public class HuntingOfTheWolfScenario : Scenario
    {
        public HuntingOfTheWolfScenario()
        {
            Title = "Hunting of the Wolf";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 0;

            AddTheLineUnbrokenLink("F8", "q4oabLrlNw4");

            AddEncounterSet(EncounterSet.HuntingOfTheWolf);

            AddQuestCardId("Ride-Forth-in-the-Morning-FA");
            AddQuestCardId("At-Last-Upon-the-Wolf-FA");
            AddQuestCardId("Ruin-Upon-the-World-FA");
        }
    }
}

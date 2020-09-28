namespace HallOfBeorn.Models.LotR.Scenarios.FirstAge
{
    public class TheIsleOfWerewolvesScenario : Scenario
    {
        public TheIsleOfWerewolvesScenario()
        {
            Title = "The Isle of Werewolves";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 2;

            AddTheLineUnbrokenLink("F6", "A8FYpUvo9BY");

            AddEncounterSet(EncounterSet.TheIsleOfWerewolves);

            AddQuestCardId("Upon-the-Bridge-FA");
            AddQuestCardId("The-Pits-of-Sauron-FA");
            AddQuestCardId("Tol-in-Gaurhoth-FA");
        }
    }
}

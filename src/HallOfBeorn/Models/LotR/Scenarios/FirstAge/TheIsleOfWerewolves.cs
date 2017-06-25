namespace HallOfBeorn.Models.LotR.Scenarios.FirstAge
{
    public class TheIsleOfWerewolves : Scenario
    {
        public TheIsleOfWerewolves()
        {
            Title = "The Isle of Werewolves";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 0;

            AddEncounterSet(EncounterSet.TheIsleOfWerewolves);

            AddQuestCardId("Upon-the-Bridge-FA");
            AddQuestCardId("The-Pits-of-Sauron-FA");
            AddQuestCardId("Tol-in-Gaurhoth-FA");


        }
    }
}

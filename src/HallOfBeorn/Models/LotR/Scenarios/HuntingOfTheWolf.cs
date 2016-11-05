namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class HuntingOfTheWolf : Scenario
    {
        public HuntingOfTheWolf()
        {
            Title = "Hunting of the Wolf";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 0;

            AddEncounterSet(EncounterSet.HuntingOfTheWolf);

            AddQuestCardId("Ride-Forth-in-the-Morning-FA");
            AddQuestCardId("At-Last-Upon-the-Wolf-FA");
            AddQuestCardId("Ruin-Upon-the-World-FA");


        }
    }
}

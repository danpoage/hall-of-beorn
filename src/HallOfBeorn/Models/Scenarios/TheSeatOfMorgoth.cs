namespace HallOfBeorn.Models.Scenarios
{
    public class TheSeatOfMorgoth : Scenario
    {
        public TheSeatOfMorgoth()
        {
            Title = "The Seat of Morgoth";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 0;

            AddEncounterSet(EncounterSet.TheSeatOfMorgoth);

            AddQuestCardId("Doors-of-Angband-FA");
            AddQuestCardId("Descent-into-Darkness-FA");
            AddQuestCardId("The-Greatest-Deed-FA");
            AddQuestCardId("To-See-the-Light-FA");


        }
    }
}

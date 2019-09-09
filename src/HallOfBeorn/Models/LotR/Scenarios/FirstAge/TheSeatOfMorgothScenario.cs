namespace HallOfBeorn.Models.LotR.Scenarios.FirstAge
{
    public class TheSeatOfMorgothScenario : Scenario
    {
        public TheSeatOfMorgothScenario()
        {
            Title = "The Seat of Morgoth";
            ProductName = "First Age";
            GroupName = "First Age";
            Number = 0;

            AddTheLineUnbrokenLink("F7", "PcJbybgSb10");

            AddEncounterSet(EncounterSet.TheSeatOfMorgoth);

            AddQuestCardId("Doors-of-Angband-FA");
            AddQuestCardId("Descent-into-Darkness-FA");
            AddQuestCardId("The-Greatest-Deed-FA");
            AddQuestCardId("To-See-the-Light-FA");
        }
    }
}

namespace HallOfBeorn.Models.Scenarios
{
    public class TheMassingAtOsgiliath : Scenario
    {
        public TheMassingAtOsgiliath()
        {
            Title = "The Massing at Osgiliath";
            ProductName = "The Massing at Osgiliath GenCon 2011";
            GroupName = "GenCon";
            Number = 1;

            AddEncounterSet(EncounterSet.TheMassingAtOsgiliath);

            AddQuestCardId("Beyond-Expectations-TMaO");
            AddQuestCardId("Through-the-Ruins-TMaO");
            AddQuestCardId("Anduin-Crossing-TMaO");
            AddQuestCardId("Race-to-Minas-Tirith-TMaO");


        }
    }
}

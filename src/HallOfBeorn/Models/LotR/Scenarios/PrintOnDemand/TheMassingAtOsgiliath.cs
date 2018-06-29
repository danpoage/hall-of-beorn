namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheMassingAtOsgiliath : Scenario
    {
        public TheMassingAtOsgiliath()
        {
            Title = "The Massing at Osgiliath";
            ProductName = "2011";
            GroupName = "Gen Con & Fellowship";
            IsSubGroup = true;
            Number = 1;

            QuestCompanionSlug = "print-on-demand-quest-the-massing-at-osgiliath";

            AddEncounterSet(EncounterSet.TheMassingAtOsgiliath);

            AddQuestCardId("Beyond-Expectations-TMaO");
            AddQuestCardId("Through-the-Ruins-TMaO");
            AddQuestCardId("Anduin-Crossing-TMaO");
            AddQuestCardId("Race-to-Minas-Tirith-TMaO");


        }
    }
}

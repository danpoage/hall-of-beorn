namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheMassingAtOsgiliathScenario : Scenario
    {
        public TheMassingAtOsgiliathScenario()
        {
            Title = "The Massing at Osgiliath";
            ProductName = "2011";
            GroupName = "Gen Con & Fellowship";
            IsSubGroup = true;
            Number = 1;

            QuestCompanionSlug = "print-on-demand-quest-the-massing-at-osgiliath";
            DifficultyRating = 7.5f;
            Votes = 52;

            AddProgressionSeriesLink("10", "ggTyUxpfq8o");
            AddTheLineUnbrokenLink("G1", "QiDrBJOv3EE");
            AddTheLineUnbrokenLink("G1.1", "of9GMF__rJ0");
            AddLotRDeckTechLink("Songs vs Captured Watchtower", "EyHf7WQCTJ4");
            AddLotRDeckTechLink("Boromir vs the Witch-king", "LYRoJ7K52xg");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/01/29/the-massing-at-osgiliath/", Title);

            AddEncounterSet(EncounterSet.TheMassingAtOsgiliath);

            AddQuestCardId("Beyond-Expectations-TMaO");
            AddQuestCardId("Through-the-Ruins-TMaO");
            AddQuestCardId("Anduin-Crossing-TMaO");
            AddQuestCardId("Race-to-Minas-Tirith-TMaO");


        }
    }
}

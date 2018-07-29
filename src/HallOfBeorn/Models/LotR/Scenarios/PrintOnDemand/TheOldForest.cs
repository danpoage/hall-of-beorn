namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheOldForest : Scenario
    {
        public TheOldForest()
        {
            Title = "The Old Forest";
            ProductName = "2014";
            GroupName = "Gen Con & Fellowship";
            IsSubGroup = true;
            Number = 4;

            QuestCompanionSlug = "print-on-demand-quest-the-old-forest";
            DifficultyRating = 5.7f;
            Votes = 17;

            AddTheGreyCompanyLink("https://www.youtube.com/watch?v=_uUyMjiLA4U", "The Old Forest", "https://i.ytimg.com/vi/_uUyMjiLA4U/hqdefault.jpg");
            AddTheLineUnbrokenLink("C1.1/G4", "3lbiFMKqVY8");
            AddTheRoadLink(2, "https://theroadlotr.wordpress.com/the-old-forest/");

            AddEncounterSet(EncounterSet.TheOldForest);

            AddQuestCardId("Farewell-to-the-Shire-TOF");
            AddQuestCardId("The-Living-Forest-Dark-Bad-Place-TOF");
            AddQuestCardId("The-Living-Forest-Choked-with-Brambles-TOF");
            AddQuestCardId("The-Living-Forest-Shifting-Trees-TOF");
            AddQuestCardId("The-Living-Forest-Closing-in-Around-Them-TOF");
            AddQuestCardId("The-Wicked-Willow-TOF");

            ExcludeFromEasyMode("Falling-Branches-TOF", 2);
            ExcludeFromEasyMode("Long-Trailer-TOF", 2);
            ExcludeFromEasyMode("Misleading-Path-TOF", 1);
            ExcludeFromEasyMode("Oppressive-Forest-TOF", 1);
            ExcludeFromEasyMode("Song-of-Sleep-TOF", 1);

        }
    }
}

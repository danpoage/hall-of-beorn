namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheOldForest : Scenario
    {
        public TheOldForest()
        {
            Title = "The Old Forest";
            ProductName = "The Old Forest";
            GroupName = "GenCon";
            Number = 4;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/print-on-demand-quest-the-old-forest.html";
            
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

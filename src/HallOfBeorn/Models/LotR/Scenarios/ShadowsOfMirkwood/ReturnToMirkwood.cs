namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class ReturnToMirkwood : Scenario
    {
        public ReturnToMirkwood()
        {
            Title = "Return to Mirkwood";
            ProductName = "Return to Mirkwood";
            GroupName = "Shadows of Mirkwood";
            Number = 6;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-return-to-mirkwood";

            DifficultyRating = 7.2f;
            Votes = 71;

            AddProgressionSeriesLink("9", "pWJZO1oZ9_k");
            AddTheLineUnbrokenLink("9", "40hlQhpPmvk");
            AddTheLineUnbrokenLink("N9", "Sva47T3B52A");
            AddTheLineUnbrokenLink("N9.2", "IHJExMbmgAo");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/09/22/beorns-path-part-13-return-to-mirkwood/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/01/08/return-to-mirkwood/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/01/12/return-to-mirkwood-play-report/", "Play Report: " + Title);

            AddEncounterSet(EncounterSet.ReturnToMirkwood);
            AddEncounterSet(EncounterSet.ReturnToMirkwoodNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Through-the-Forest-RtM");
            AddQuestCardId("Escape-Attempt-RtM");
            AddQuestCardId("To-the-Elvin-King's-Halls-RtM");
            AddQuestCardId("Ambush-RtM");

            ExcludeFromEasyMode("Attercop-Attercop-RtM", 3);
            ExcludeFromEasyMode("Gollum's-Anguish-RtM", 1);
            ExcludeFromEasyMode("Gollum's-Bite-RtM", 1);
            ExcludeFromEasyMode("Mirkwood-Bats-RtM", 2);
            ExcludeFromEasyMode("The-Spiders'-Ring-RtM", 2);
            ExcludeFromEasyMode("Wasted-Provisions-RtM", 1);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Wood-Elf-Path-RtM", 3);
            ExcludeFromNightmareMode("Woodman's-Glade-RtM", 3);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Goblin-Sniper-Core", 2);
            ExcludeFromNightmareMode("Marsh-Adder-Core", 1);
            ExcludeFromNightmareMode("The-Brown-Lands-Core", 2);
            ExcludeFromNightmareMode("The-East-Bight-Core", 2);
            ExcludeFromNightmareMode("Wargs-Core", 2);
        }
    }
}

namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class PassageThroughMirkwoodScenario : Scenario
    {
        public PassageThroughMirkwoodScenario()
        {
            Title = "Passage Through Mirkwood";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 1;

            QuestCompanionSlug = "core-set-quest-passage-through-mirkwood";
            DifficultyRating = 2.2f;
            Votes = 222;

            AddProgressionSeriesLink("1", "aJ242SoRyVQ");
            AddTheLineUnbrokenLink("1", "bF3H-ekuwEI");
            AddTheLineUnbrokenLink("N1", "2Tb3YiRSyQE");
            AddLotRDeckTechLink("Just One Core vs Too Many Spiders", "Pyk_PrY58g8");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/01/25/beorns-path-part-2-playtesting/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/10/28/passage-through-mirkwood/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/20/ptm/");

            AddRelatedDeck("7299", "Just One Core vs Too Many Spiders",
                "https://www.youtube.com/watch?v=Pyk_PrY58g8");
            AddRelatedDeck("293", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/01/25/beorns-path-part-2-playtesting/");
            AddRelatedDeck("3415", "People of the Golden Wood",
                "https://darklingdoor.wordpress.com/2016/10/28/passage-through-mirkwood/");

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.PassageThroughMirkwood);
            AddEncounterSet(EncounterSet.PassageThroughMirkwoodNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);

            AddQuestCardId("Flies-and-Spiders-Core");
            AddQuestCardId("A-Fork-in-the-Road-Core");
            AddQuestCardId("A-Chosen-Path-Don't-Leave-the-Path-Core");
            AddQuestCardId("A-Chosen-Path-Beorn's-Path-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 1);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 3);
            ExcludeFromNightmareMode("Black-Forest-Bats-Core", 1);
            ExcludeFromNightmareMode("Forest-Gate-Core", 2);
            ExcludeFromNightmareMode("Forest-Spider-Core", 3);
            ExcludeFromNightmareMode("Old-Forest-Road-Core", 1);
            ExcludeFromNightmareMode("Caught-in-a-Web-Core", 2);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
            ExcludeFromNightmareMode("Ungoliant's-Spawn-Core", 1);
        }
    }
}

namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class PassageThroughMirkwoodCampaignScenario : Scenario
    {
        public PassageThroughMirkwoodCampaignScenario()
            : base(true)
        {
            Title = "Passage Through Mirkwood (Campaign)";
            ProductName = "Revised Core Set";
            GroupName = "Revised Core Set";
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

            AddEncounterSet(EncounterSet.DolGuldurOrcsCampaign);
            AddEncounterSet(EncounterSet.PassageThroughMirkwoodCampaign);
            AddEncounterSet(EncounterSet.PassageThroughMirkwoodNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwoodCampaign);

            AddQuestCardId("Flies-and-Spiders-RevCore");
            AddQuestCardId("A-Fork-in-the-Road-RevCore");
            AddQuestCardId("A-Chosen-Path-Don't-Leave-the-Path-RevCore");
            AddQuestCardId("A-Chosen-Path-Beorn's-Path-RevCore");

            ExcludeFromEasyMode("Chieftan-Ufthak-RevCore", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-RevCore", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-RevCore", 1);
            ExcludeFromEasyMode("The-Necromancer's-Reach-RevCore", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-RevCore", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-RevCore", 1);
            ExcludeFromEasyMode("Hummerhorns-RevCore", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-RevCore", 3);
            ExcludeFromNightmareMode("Black-Forest-Bats-RevCore", 1);
            ExcludeFromNightmareMode("Forest-Gate-RevCore", 2);
            ExcludeFromNightmareMode("Forest-Spider-RevCore", 3);
            ExcludeFromNightmareMode("Old-Forest-Road-RevCore", 1);
            ExcludeFromNightmareMode("Caught-in-a-Web-RevCore", 2);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-RevCore", 3);
            ExcludeFromNightmareMode("Ungoliant's-Spawn-RevCore", 1);
        }
    }
}

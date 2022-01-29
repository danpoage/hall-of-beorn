namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class JourneyAlongTheAnduinCampaignScenario : Scenario
    {
        public JourneyAlongTheAnduinCampaignScenario()
            : base(true)
        {
            Title = "Journey Along the Anduin Campaign";
            ProductName = "Revised Core Set";
            GroupName = "Revised Core Set";
            Number = 2;

            QuestCompanionSlug = "core-set-quest-journey-down-the-anduin";
            DifficultyRating = 5.3f;
            Votes = 160;

            AddProgressionSeriesLink("2", "Lx5RL9_0yBA");
            AddTheLineUnbrokenLink("2.1", "Fpv3YJAoHNk");
            AddTheLineUnbrokenLink("N2", "k84HvCq6uRo");
            AddMrUnderhillLink(Title + " Nightmare Mode, Attempt One", "IaO8wJmLt_I");
            AddMrUnderhillLink(Title + " Nightmare Mode, Attempt Two", "LwsqbhhOA1c");
            AddLotRDeckTechLink("Rossiel, Keen as Lances vs The Anduin", "PlQrthtPULc");
            AddLotRDeckTechLink("Argalad Along the Anduin", "bICTQO1uVUo");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/02/04/beorns-path-part-4-journey-along-the-anduin/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/11/06/journey-along-the-anduin/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/20/journey-along-the-anduin/");

            AddRelatedDeck("5524", "Flawless Victory",
                "https://www.youtube.com/watch?v=IaO8wJmLt_I",
                "https://www.youtube.com/watch?v=LwsqbhhOA1c");
            
            AddRelatedDeck("1871", "The Line Unbroken - Core Set Deck 1",
                "https://www.youtube.com/watch?v=Fpv3YJAoHNk");
            AddRelatedDeck("1872", "The Line Unbroken - Core Set Deck 2",
                "https://www.youtube.com/watch?v=Fpv3YJAoHNk");
            AddRelatedDeck("5935", "The Line Unbroken - NM Journey Down the Anduin Deck 1",
                "https://www.youtube.com/watch?v=k84HvCq6uRo");
            AddRelatedDeck("5936", "The Line Unbroken - NM Journey Down the Anduin Deck 2",
                "https://www.youtube.com/watch?v=k84HvCq6uRo");
            AddRelatedDeck("7155", "Rossiel Rides to Victory",
                "https://www.youtube.com/watch?v=PlQrthtPULc");
            AddRelatedDeck("7534", "Argalad, Double Daggers",
                "https://www.youtube.com/watch?v=bICTQO1uVUo");
            AddRelatedDeck("305", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/02/04/beorns-path-part-4-journey-along-the-anduin/");
            AddRelatedDeck("3529", "[Thematic Nightmare] Green and Gold",
                "https://darklingdoor.wordpress.com/2016/11/06/journey-along-the-anduin/");

            AddRelatedDeck("9005", "Deck Tech: Dale Starter Deck",
                "https://visionofthepalantir.wordpress.com/2018/01/20/journey-along-the-anduin/",
                "https://www.youtube.com/watch?v=8mKOOq9t-7w");

            AddEncounterSet(EncounterSet.DolGuldurOrcsCampaign);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinCampaign);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinNightmare);
            AddEncounterSet(EncounterSet.SauronsReachCampaign);
            AddEncounterSet(EncounterSet.WilderlandsCampaign);

            AddQuestCardId("To-the-River-RevCore");
            AddQuestCardId("Anduin-Passage-RevCore");
            AddQuestCardId("Ambush-on-the-Shore-RevCore");

            ExcludeFromEasyMode("Chieftan-Ufthak-RevCore", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-RevCore", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-RevCore", 1);
            ExcludeFromEasyMode("The-Necromancer's-Reach-RevCore", 2);
            ExcludeFromEasyMode("Gladden-Fields-RevCore", 2);
            ExcludeFromEasyMode("Massing-at-Night-RevCore", 1);
            ExcludeFromEasyMode("Eastern-Crows-RevCore", 2);
            ExcludeFromEasyMode("Evil-Storm-RevCore", 1);
            ExcludeFromEasyMode("Despair-RevCore", 2);
            ExcludeFromEasyMode("Hill-Troll-RevCore", 1);
            ExcludeFromEasyMode("Marsh-Adder-RevCore", 1);

            ExcludeFromNightmareMode("Evil-Storm-RevCore", 3);
            ExcludeFromNightmareMode("Treacherous-Fog-RevCore", 2);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-RevCore", 2);
            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-RevCore", 3);
            ExcludeFromNightmareMode("Enchanted-Stream-RevCore", 2);
            ExcludeFromNightmareMode("Despair-RevCore", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-RevCore", 3);
            ExcludeFromNightmareMode("Necromancer's-Pass-RevCore", 2);
        }
    }
}

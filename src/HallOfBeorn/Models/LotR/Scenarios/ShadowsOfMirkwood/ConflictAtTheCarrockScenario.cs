namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class ConflictAtTheCarrockScenario : Scenario
    {
        public ConflictAtTheCarrockScenario()
        {
            Title = "Conflict at the Carrock";
            ProductName = "Conflict at the Carrock";
            GroupName = "Shadows of Mirkwood";
            Number = 2;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-conflict-at-the-carrock";

            DifficultyRating = 6.2f;
            Votes = 101;

            AddProgressionSeriesLink("5", "AIYN9M7uSwQ");
            AddTheLineUnbrokenLink("5", "Vl8BF2LnhIk");
            AddTheLineUnbrokenLink("N5", "khCcnI734Hk");
            AddMrUnderhillLink(Title + " Nightmare Mode", "6KYfOj43Vmg");
            AddWarriorsOfTheWestLink("Twitch Recast: " + Title, "bsPThUukTa8");
            AddLotRDeckTechLink("Gamgees at the Carrock", "TFQlivqlaaY");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/07/22/beorns-path-part-9-conflict-at-the-carrock/");
            AddTheWhiteTowerLink("https://thewhitetower.wordpress.com/2018/07/16/conflict-at-the-carrock-quest-analysis/", "Conflict at the Carrock - Quest Analysis");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/12/09/conflict-at-the-carrock/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/12/01/turn-by-turn-report-conflict-at-the-carrock/", Title);
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/25/conflict-at-the-carrock/");
            AddTheBookOfElessarLink("https://bookofelessar.com/decks/shadows-of-mirkwood-decks/conflict-at-the-carrock/");
            AddYouTubeLink(LinkType.The_Book_of_Elessar, Title, "GDlieGGihL8");

            AddRelatedDeck("732", "Beorn's Path 5 - Conflict at the Carrock (Leadership/Lore)",
                "https://hallofbeorn.wordpress.com/2013/07/22/beorns-path-part-9-conflict-at-the-carrock/");

            //Chrsjxn
            AddRelatedDeck("7942", "Gamgees at the Carrock",
                "https://www.youtube.com/watch?v=TFQlivqlaaY");

            //Authraw
            AddRelatedDeck("3833", "[Thematic Nightmare] The Birds and the Beasts", 
                "https://darklingdoor.wordpress.com/2016/12/09/conflict-at-the-carrock/");

            //Psychorocka
            AddRelatedDeck("3840", "An Unlikely Friendship",
                "https://warriorsofthewestblog.wordpress.com/2016/12/01/turn-by-turn-report-conflict-at-the-carrock/");
            AddRelatedDeck("3841", "Vilya+Nenya",
                "https://warriorsofthewestblog.wordpress.com/2016/12/01/turn-by-turn-report-conflict-at-the-carrock/");

            //BGamerJoe
            AddRelatedDeck("961", "Seastan's Single Core Set Solo",
                "https://visionofthepalantir.wordpress.com/2018/01/25/conflict-at-the-carrock/");
            AddRelatedDeck("3011", "Smoke Yourself Thin",
                "https://visionofthepalantir.wordpress.com/2018/01/25/conflict-at-the-carrock/");
            AddRelatedDeck("6675", "The Swords of the Noldor",
                "https://visionofthepalantir.wordpress.com/2018/01/25/conflict-at-the-carrock/");

            AddEncounterSet(EncounterSet.ConflictAtTheCarrock);
            AddEncounterSet(EncounterSet.ConflictAtTheCarrockNightmare);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Grimbeorn's-Quest-CatC");
            AddQuestCardId("Against-the-Trolls-CatC");
            AddQuestCardId("Grimbeorn's-Folly-CatCN");

            ExcludeFromEasyMode("A-Frightened-Beast-CatC", 2);
            ExcludeFromEasyMode("Muck-Adder-CatC", 2);
            ExcludeFromEasyMode("River-Langflood-CatC", 2);
            ExcludeFromEasyMode("Roasted-Slowly-CatC", 2);
            ExcludeFromEasyMode("Sacked-CatC", 1);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Bee-Pastures-CatC", 3);
            ExcludeFromNightmareMode("Grimbeorn-the-Old-CatC", 1);
            ExcludeFromNightmareMode("Louis-CatC", 1);
            ExcludeFromNightmareMode("Morris-CatC", 1);
            ExcludeFromNightmareMode("Oak-wood-Grove-CatC", 3);
            ExcludeFromNightmareMode("Roasted-Slowly-CatC", 1);
            ExcludeFromNightmareMode("Rupert-CatC", 1);
            ExcludeFromNightmareMode("Stuart-CatC", 1);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 3);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Goblin-Sniper-Core", 2);
            ExcludeFromNightmareMode("The-Brown-Lands-Core", 2);
            ExcludeFromNightmareMode("The-East-Bight-Core", 2);
            ExcludeFromNightmareMode("Wargs-Core", 2);
            ExcludeFromNightmareMode("Wolf-Rider-Core", 1);
        }
    }
}

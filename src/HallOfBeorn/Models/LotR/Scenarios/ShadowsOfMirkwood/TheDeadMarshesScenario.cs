namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class TheDeadMarshesScenario : Scenario
    {
        public TheDeadMarshesScenario()
        {
            Title = "The Dead Marshes";
            ProductName = "The Dead Marshes";
            GroupName = "Shadows of Mirkwood";
            Number = 5;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-the-dead-marshes";

            DifficultyRating = 3.8f;
            Votes = 84;

            AddProgressionSeriesLink("8", "iK5XcHJxV8w");
            AddTheLineUnbrokenLink("8", "ST0570g_QQc");
            AddTheLineUnbrokenLink("N8", "MnSeSciaiPk");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/09/12/beorns-path-part-12-the-dead-marshes/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/01/02/the-dead-marshes/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/02/02/the-dead-marshes/");
            AddTheBookOfElessarLink("https://bookofelessar.com/decks/shadows-of-mirkwood-decks/the-dead-marshes/");
            AddYouTubeLink(LinkType.The_Book_of_Elessar, Title, "MY6OT6OfSzU");

            //The Line Unbroken
            AddRelatedDeck("2918", "The Line Unbroken - The Dead Marshes Deck 1",
                "https://www.youtube.com/watch?v=ST0570g_QQc",
                "https://wardenofarnor.wordpress.com/2015/04/21/the-line-unbroken-8-the-dead-marshes/");
            AddRelatedDeck("2919", "The Line Unbroken - The Dead Marshes Deck 2",
                "https://www.youtube.com/watch?v=ST0570g_QQc",
                "https://wardenofarnor.wordpress.com/2015/04/21/the-line-unbroken-8-the-dead-marshes/");

            //The Line Unbroken Nightmare
            AddRelatedDeck("5948", "The Line Unbroken - NM The Dead Marshes Deck 1",
                "https://www.youtube.com/watch?v=MnSeSciaiPk",
                "https://wardenofarnor.wordpress.com/2017/01/18/the-line-unbroken-n8-nightmare-the-dead-marshes/");
            AddRelatedDeck("5949", "The Line Unbroken - NM The Dead Marshes Deck 2",
                "https://www.youtube.com/watch?v=MnSeSciaiPk",
                "https://wardenofarnor.wordpress.com/2017/01/18/the-line-unbroken-n8-nightmare-the-dead-marshes/");

            //Hall of Beorn
            AddRelatedDeck("736", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/09/12/beorns-path-part-12-the-dead-marshes/");

            //Darkling Door
            AddRelatedDeck("4055", "By Sheer Force of Will",
                "https://darklingdoor.wordpress.com/2017/01/02/the-dead-marshes/");

            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheDeadMarshes);
            AddEncounterSet(EncounterSet.TheDeadMarshesNightmare);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Into-the-Marshes-TDM");
            AddQuestCardId("The-Capture-TDM");

            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("A-Wisp-of-Pale-Sheen-TDM", 2);
            ExcludeFromEasyMode("Giant-Marsh-Worm-TDM", 2);
            ExcludeFromEasyMode("Impassable-Bog-TDM", 2);
            ExcludeFromEasyMode("The-Heart-of-the-Marshes-TDM", 2);
            ExcludeFromEasyMode("The-Lights-of-the-Dead-TDM", 2);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Eastern-Crows-Core", 3);
            ExcludeFromNightmareMode("Pursued-by-Shadow-Core", 2);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("A-Wisp-of-Pale-Sheen-TDM", 1);
            ExcludeFromNightmareMode("Fens-and-Mires-TDM", 4);
            ExcludeFromNightmareMode("Giant-Marsh-Worm-TDM", 2);
            ExcludeFromNightmareMode("Through-the-Mist-TDM", 1);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Goblin-Sniper-Core", 2);
            ExcludeFromNightmareMode("Hill-Troll-Core", 2);
            ExcludeFromNightmareMode("The-Brown-Lands-Core", 2);
            ExcludeFromNightmareMode("The-East-Bight-Core", 2);
            ExcludeFromNightmareMode("Wargs-Core", 2);
            ExcludeFromNightmareMode("Wolf-Rider-Core", 1);
        }
    }
}

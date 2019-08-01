namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class TheHuntForGollum : Scenario
    {
        public TheHuntForGollum()
        {
            Title = "The Hunt for Gollum";
            ProductName = "The Hunt for Gollum";
            GroupName = "Shadows of Mirkwood";
            Number = 1;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-the-hunt-for-gollum";

            DifficultyRating = 4.1f;
            Votes = 109;

            AddProgressionSeriesLink("4", "B8Hq1LLxWtU");
            AddTheLineUnbrokenLink("4", "CwBfByFcSFM");
            AddTheLineUnbrokenLink("N4", "-lezqJk4gqs");
            AddMrUnderhillLink(Title + " Nightmare Mode", "9XwrbNac2xI");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "K_HsURLhM5U");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/04/08/beorns-path-part-8-playtesting-the-hunt-for-gollum/");
            AddTheWhiteTowerLink("https://thewhitetower.wordpress.com/2018/05/29/the-hunt-for-gollum-quest-analysis/", "The Hunt for Gollum - Quest Analysis");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/11/24/the-hunt-for-gollum/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/24/the-hunt-for-gollum/");

            AddRelatedDeck("306", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/04/08/beorns-path-part-8-playtesting-the-hunt-for-gollum/");
            AddRelatedDeck("2890", "The Line Unbroken - Hunt for Gollum Deck 1",
                "https://www.youtube.com/watch?v=CwBfByFcSFM",
                "https://wardenofarnor.wordpress.com/2015/03/25/the-line-unbroken-4-hunt-for-gollum/");
            AddRelatedDeck("2891", "The Line Unbroken - Hunt for Gollum Deck 2",
                "https://www.youtube.com/watch?v=CwBfByFcSFM",
                "https://wardenofarnor.wordpress.com/2015/03/25/the-line-unbroken-4-hunt-for-gollum/");
            AddRelatedDeck("5939", "The Line Unbroken - NM Hunt for Gollum Deck 1",
                "https://wardenofarnor.wordpress.com/2016/12/18/the-line-unbroken-n4-nightmare-hunt-for-gollum/",
                "https://www.youtube.com/watch?v=-lezqJk4gqs");
            AddRelatedDeck("5940", "The Line Unbroken - NM Hunt for Gollum Deck 1",
                "https://wardenofarnor.wordpress.com/2016/12/18/the-line-unbroken-n4-nightmare-hunt-for-gollum/",
                "https://www.youtube.com/watch?v=-lezqJk4gqs");
            AddRelatedDeck("3703", "In Pursuit of Gollum",
                "https://darklingdoor.wordpress.com/2016/11/24/the-hunt-for-gollum/");

            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheHuntForGollum);
            AddEncounterSet(EncounterSet.TheHuntForGollumNightmare);

            AddQuestCardId("The-Hunt-Begins-THfG");
            AddQuestCardId("A-New-Terror-Abroad-THfG");
            AddQuestCardId("On-the-Trail-THfG");

            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Goblintown-Scavengers-THfG", 1);
            ExcludeFromEasyMode("Hunters-from-Mordor-THfG", 3);
            ExcludeFromEasyMode("Old-Wives'-Tales-THfG", 2);
            ExcludeFromEasyMode("The-Old-Ford-THfG", 2);

            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Gladden-Fields-Core", 3);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 2);
            ExcludeFromNightmareMode("Eastern-Crows-Core", 3);
            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("False-Lead-THfG", 2);
            ExcludeFromNightmareMode("River-Ninglor-THfG", 2);
            ExcludeFromNightmareMode("The-Eaves-of-Mirkwood-THfG", 1);
        }
    }
}

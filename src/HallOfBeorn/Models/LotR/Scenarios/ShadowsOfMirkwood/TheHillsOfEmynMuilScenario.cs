namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class TheHillsOfEmynMuilScenario : Scenario
    {
        public TheHillsOfEmynMuilScenario()
        {
            Title = "The Hills of Emyn Muil";
            ProductName = "The Hills of Emyn Muil";
            GroupName = "Shadows of Mirkwood";
            Number = 4;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-the-hills-of-emyn-muil";

            DifficultyRating = 2.7f;
            Votes = 81;

            AddProgressionSeriesLink("7", "7VejBJcRwJ0");
            AddTheLineUnbrokenLink("7", "hngSYXX6X94");
            AddTheLineUnbrokenLink("N7", "YBuqRpJ8-ps");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/09/01/beorns-path-part-11-the-hills-of-emyn-muil/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/12/24/the-hills-of-emyn-muil/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/28/the-hills-of-emyn-muil/");

            //The Line Unbroken
            AddRelatedDeck("2896", "The Line Unbroken - Hills of Emyn Muil Deck 1",
                "https://www.youtube.com/watch?v=hngSYXX6X94",
                "https://wardenofarnor.wordpress.com/2015/04/14/the-line-unbroken-7-hills-of-emyn-muil/");
            AddRelatedDeck("2897", "The Line Unbroken - Hills of Emyn Muil Deck 2",
                "https://www.youtube.com/watch?v=hngSYXX6X94",
                "https://wardenofarnor.wordpress.com/2015/04/14/the-line-unbroken-7-hills-of-emyn-muil/");

            //The Line Unbroken Nightmare
            AddRelatedDeck("5946", "The Line Unbroken - NM Hills of Emyn Muil Deck 1",
                "https://www.youtube.com/watch?v=YBuqRpJ8-ps",
                "https://wardenofarnor.wordpress.com/2017/01/13/the-line-unbroken-n7-nightmare-hills-of-emyn-muil/");
            AddRelatedDeck("5947", "The Line Unbroken - NM Hills of Emyn Muil Deck 2",
                "https://www.youtube.com/watch?v=YBuqRpJ8-ps",
                "https://wardenofarnor.wordpress.com/2017/01/13/the-line-unbroken-n7-nightmare-hills-of-emyn-muil/");

            AddRelatedDeck("734", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/09/01/beorns-path-part-11-the-hills-of-emyn-muil/");

            AddRelatedDeck("4005", "Counsel of Elves",
                "https://darklingdoor.wordpress.com/2016/12/24/the-hills-of-emyn-muil/");

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuil);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuilNightmare);

            AddQuestCardId("The-Hills-of-Emyn-Muil-THoEM");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Impassable-Chasm-THoEM", 2);
            ExcludeFromEasyMode("Orc-Horse-Thieves-THoEM", 1);
            ExcludeFromEasyMode("Rockslide-THoEM", 2);
            ExcludeFromEasyMode("The-East-Wall-of-Rohan-THoEM", 2);

            ExcludeFromNightmareMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromNightmareMode("Dol-Guldur-Beastmaster-Core", 2);
            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 2);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Pursued-by-Shadow-Core", 2);
            ExcludeFromNightmareMode("Impassable-Chasm-THoEM", 2);
            ExcludeFromNightmareMode("Slick-Footing-THoEM", 2);
            ExcludeFromNightmareMode("The-East-Wall-of-Rohan-THoEM", 1);
            ExcludeFromNightmareMode("The-Highlands-THoEM", 4);
            ExcludeFromNightmareMode("The-North-Stair-THoEM", 1);
            ExcludeFromNightmareMode("The-Shores-of-Nen-Hithoel-THoEM", 2);
        }
    }
}

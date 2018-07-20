namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class AShadowOfThePast : Scenario
    {
        public AShadowOfThePast()
        {
            Title = "A Shadow of the Past";
            ProductName = "The Black Riders";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 1;

            QuestCompanionSlug = "lotr-the-black-riders-quest-a-shadow-of-the-past";
            DifficultyRating = 6.3f;
            Votes = 53;

            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/09/19/path-less-traveled-a-shadow-of-the-past/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/11/12/nightmare-review-a-shadow-of-the-pastnightmare-campaign-part-1/", "Nightmare " + Title);
            AddTheRoadLink(1, "https://theroadlotr.wordpress.com/a-shadow-of-the-past/");

            AddEncounterSet(EncounterSet.AShadowOfThePast);
            AddEncounterSet(EncounterSet.AShadowOfThePastNightmare);
            AddEncounterSet(EncounterSet.Hunted);
            AddEncounterSet(EncounterSet.TheBlackRiders);
            AddEncounterSet(EncounterSet.TheRing);

            AddQuestCardId("Three-is-Company-TBR");
            AddQuestCardId("A-Shortcut-to-Mushrooms-TBR");
            AddQuestCardId("Escape-to-Buckland-TBR");

            ExcludeFromEasyMode("Black-Rider-TBR", 2);
            ExcludeFromEasyMode("Crawling-Towards-Him-TBR", 1);
            ExcludeFromEasyMode("Have-You-Seen-Baggins-TBR", 2);
            ExcludeFromEasyMode("Stock-Road-TBR", 2);
            ExcludeFromEasyMode("The-Marish-TBR", 1);
            ExcludeFromEasyMode("Piercing-Cry-TBR", 2);
            ExcludeFromEasyMode("Black-Steed-TBR", 2);

            ExcludeFromNightmareMode("Bamfurlong-TBR", 1);
            ExcludeFromNightmareMode("Evil-Crow-TBR", 3);
            ExcludeFromNightmareMode("Green-Hill-Country-TBR", 3);
            ExcludeFromNightmareMode("Woody-End-TBR", 1);
            ExcludeFromNightmareMode("Pathless-Country-TBR", 3);
            ExcludeFromNightmareMode("Rode-Like-a-Gale-TBR", 2);
        }
    }
}

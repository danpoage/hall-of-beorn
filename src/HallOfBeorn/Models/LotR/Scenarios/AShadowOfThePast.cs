namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class AShadowOfThePast : Scenario
    {
        public AShadowOfThePast()
        {
            Title = "A Shadow of the Past";
            ProductName = "The Black Riders";
            GroupName = "The Lord of the Rings";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-black-riders-quest-a-shadow-of-the-past.html";

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

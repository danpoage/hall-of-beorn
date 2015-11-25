namespace HallOfBeorn.Models.Scenarios
{
    public class AcrossTheEttenmoors : Scenario
    {
        public AcrossTheEttenmoors()
        {
            Title = "Across the Ettenmoors";
            ProductName = "Across the Ettenmoors";
            GroupName = "Angmar Awakened";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/angmar-awakened-quest-across-the-ettenmoors.html";

            AddEncounterSet(EncounterSet.AcrossTheEttenmoors);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);

            AddQuestCardId("Into-the-Ettenmoors-AtE");
            AddQuestCardId("A-Miserable-Journey-AtE");
            AddQuestCardId("Journey's-End-AtE");

            ExcludeFromEasyMode("Arador's-Bane-AtE", 1);
            ExcludeFromEasyMode("Barren-Moorland-AtE", 2);
            ExcludeFromEasyMode("Coldfell-Giant-AtE", 2);
            ExcludeFromEasyMode("Cruel-Mountain-troll-AtE", 2);
            ExcludeFromEasyMode("Pressing-Needs-TLR", 1);
            ExcludeFromEasyMode("Shrouded-Hills-TLR", 1);
            ExcludeFromEasyMode("Weight-of-Responsibility-TLR", 1);
            ExcludeFromEasyMode("Biting-Wind-TLR", 1);
            ExcludeFromEasyMode("Cold-from-Angmar-TLR", 1);
            ExcludeFromEasyMode("Freezing-Blast-TLR", 1);

        }
    }
}

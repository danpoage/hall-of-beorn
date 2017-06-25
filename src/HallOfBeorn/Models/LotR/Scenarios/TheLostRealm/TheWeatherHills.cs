namespace HallOfBeorn.Models.LotR.Scenarios.TheLostRealm
{
    public class TheWeatherHills : Scenario
    {
        public TheWeatherHills()
        {
            Title = "The Weather Hills";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 2;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-lost-realm-quest-the-weather-hills.html";

            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.FoulWeather);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
            AddEncounterSet(EncounterSet.TheWeatherHills);

            AddQuestCardId("Scattered-Among-the-Hills-TLR");
            AddQuestCardId("Cornered-Animals-TLR");

            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
            ExcludeFromEasyMode("Biting-Wind-TLR", 1);
            ExcludeFromEasyMode("Cold-from-Angmar-TLR", 1);
            ExcludeFromEasyMode("Freezing-Blast-TLR", 1);
            ExcludeFromEasyMode("Ruins-of-Arnor-TLR", 1);
            ExcludeFromEasyMode("Exposed-Ridge-TLR", 1);
            ExcludeFromEasyMode("Ice-Storm-TLR", 1);

        }
    }
}

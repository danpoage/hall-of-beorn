namespace HallOfBeorn.Models.LotR.Scenarios.TheLostRealm
{
    public class TheWeatherHillsScenario : Scenario
    {
        public TheWeatherHillsScenario()
        {
            Title = "The Weather Hills";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 2;

            QuestCompanionSlug = "the-lost-realm-quest-the-weather-hills";
            DifficultyRating = 6.3f;
            Votes = 28;

            AddTheGreyCompanyLink(Title, "b-cCXvTTtcU");
            AddTheLineUnbrokenLink("44", "EuznH6_k0UE");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "npyK3djn7tQ");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/08/08/path-less-traveled-the-weather-hills/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/11/07/nightmare-review-the-weather-hills/", "Nightmare " + Title);
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/09/20/the-weather-hills/");

            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.FoulWeather);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
            AddEncounterSet(EncounterSet.TheWeatherHills);
            AddEncounterSet(EncounterSet.TheWeatherHillsNightmare);

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

            ExcludeFromNightmareMode("Cornered-Orc-TLR", 3);
            ExcludeFromNightmareMode("Sheltered-Valley-TLR", 2);
            ExcludeFromNightmareMode("Concealed-Orc-camp-TLR", 1);
            ExcludeFromNightmareMode("Angmar-Marauder-TLR", 1);
            ExcludeFromNightmareMode("Angmar-Orc-TLR", 2);
            ExcludeFromNightmareMode("Ruins-of-Arnor-TLR", 3);
            ExcludeFromNightmareMode("Tragic-Discovery-TLR", 2);
        }
    }
}

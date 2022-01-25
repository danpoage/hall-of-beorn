namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class FlightToTheFordScenario : Scenario
    {
        public FlightToTheFordScenario()
            : base(true)
        {
            Title = "Flight to the Ford";
            ProductName = "The Black Riders";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 3;

            QuestCompanionSlug = "lotr-the-black-riders-quest-flight-to-the-ford";
            DifficultyRating = 5.6f;
            Votes = 38;

            AddTheGreyCompanyLink(Title, "-IU2yhbqRDk");
            AddTheLineUnbrokenLink("C3", "CE8Iyzk4P4Y");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/10/24/path-less-traveled-flight-to-the-ford/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/11/28/nightmare-review-flight-to-the-fordnightmare-campaign-part-3/", "Nightmare " + Title);
            AddTheRoadLink(5, "https://theroadlotr.wordpress.com/flight-to-the-ford/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/06/13/flight-to-the-ford/");

            AddEncounterSet(EncounterSet.FlightToTheFord);
            AddEncounterSet(EncounterSet.FlightToTheFordNightmare);
            AddEncounterSet(EncounterSet.Hunted);
            AddEncounterSet(EncounterSet.TheBlackRiders);
            AddEncounterSet(EncounterSet.TheNazgul);

            AddQuestCardId("Pursued-by-the-Enemy-TBR");
            AddQuestCardId("Race-To-Rivendell-TBR");

            ExcludeFromEasyMode("The-Enemy-is-Upon-Us-TBR", 2);
            ExcludeFromEasyMode("The-Nine-are-Abroad-TBR", 1);
            ExcludeFromEasyMode("Piercing-Cry-TBR", 2);
            ExcludeFromEasyMode("Black-Steed-TBR", 2);
            ExcludeFromEasyMode("Pale-Blade-TBR", 2);
            ExcludeFromEasyMode("Power-In-Their-Terror-TBR", 2);
            ExcludeFromEasyMode("Ringwraith-TBR", 2);

            ExcludeFromNightmareMode("Fell-Rider-TBR", 4);
            ExcludeFromNightmareMode("Ford-of-Bruinen-TBR", 1);
            ExcludeFromNightmareMode("The-Troll's-Camp-TBR", 1);
            ExcludeFromNightmareMode("Ettenmoors-TBR", 3);
            ExcludeFromNightmareMode("Pain-Assailed-Him-TBR", 3);
            ExcludeFromNightmareMode("The-Old-Road-TBR", 3);
            ExcludeFromNightmareMode("Pathless-Country-TBR", 3);
            ExcludeFromNightmareMode("Stricken-Dumb-TBR", 3);
            ExcludeFromNightmareMode("Rode-Like-a-Gale-TBR", 2);
        }
    }
}

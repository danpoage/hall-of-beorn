namespace HallOfBeorn.Models.LotR.Scenarios.TheHobbit
{
    public class WeMustAwayEreBreakOfDayScenario : Scenario
    {
        public WeMustAwayEreBreakOfDayScenario()
        {
            Title = "We Must Away, Ere Break of Day";
            ProductName = "The Hobbit: Over Hill and Under Hill";
            GroupName = "The Hobbit";
            IsSubGroup = true;
            Number = 1;

            QuestCompanionSlug = "the-hobbit-over-hill-and-under-hill-quest-we-must-away-ere-break-of-day";
            DifficultyRating = 6.6f;
            Votes = 54;

            AddTheLineUnbrokenLink("19", "8GS-c0teAOs");
            AddTheLineUnbrokenLink("N19", "9q0suPxxjGg");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "97ls-LtzpRM");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/03/25/we-must-away-ere-break-of-day/");

            AddEncounterSet(EncounterSet.WeMustAwayEreBreakOfDay);
            AddEncounterSet(EncounterSet.WeMustAwayEreBreakOfDayNightmare);
            AddEncounterSet(EncounterSet.WesternLands);

            AddQuestCardId("An-Unexpected-Party-THOHaUH");
            AddQuestCardId("Roast-Mutton-THOHaUH");
            AddQuestCardId("Dawn-Take-You-All-THOHaUH");

            ExcludeFromEasyMode("Hungry-Troll-THOHaUH", 3);
            ExcludeFromEasyMode("Lots-or-None-at-All-THOHaUH", 2);
            ExcludeFromEasyMode("Roast-'Em-or-Boil-'Em-THOHaUH", 1);
            ExcludeFromEasyMode("Troll-Camp-THOHaUH", 2);
            ExcludeFromEasyMode("Dreary-Hills-THOHaUH", 1);
            ExcludeFromEasyMode("No-Campfire-THOHaUH", 2);
            ExcludeFromEasyMode("Wind-whipped-Rain-THOHaUH", 1);

            ExcludeFromNightmareMode("A-Nice-Pickle-THOHaUH", 2);
            ExcludeFromNightmareMode("Hobbit-lands-THOHaUH", 2);
            ExcludeFromNightmareMode("A-Suspicious-Crow-THOHaUH", 3);
            ExcludeFromNightmareMode("Dreary-Hills-THOHaUH", 1);
        }
    }
}

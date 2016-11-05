namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class WeMustAwayEreBreakOfDay : Scenario
    {
        public WeMustAwayEreBreakOfDay()
        {
            Title = "We Must Away, Ere Break of Day";
            ProductName = "The Hobbit: Over Hill and Under Hill";
            GroupName = "The Hobbit";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-hobbit-over-hill-and-under-hill-quest-we-must-away-ere-break-of-day.html";

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

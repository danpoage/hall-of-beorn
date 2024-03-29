namespace HallOfBeorn.Models.LotR.Scenarios.TheHobbit
{
    public class OverTheMistyMountainsGrimScenario : Scenario
    {
        public OverTheMistyMountainsGrimScenario()
            : base(true)
        {
            Title = "Over the Misty Mountains Grim";
            ProductName = "The Hobbit: Over Hill and Under Hill";
            GroupName = "The Hobbit";
            IsSubGroup = true;
            Number = 2;

            QuestCompanionSlug = "the-hobbit-over-hill-and-under-hill-quest-over-the-misty-mountains-grim";
            DifficultyRating = 5.3f;
            Votes = 42;

            AddTheLineUnbrokenLink("20", "MFzFrYAZe4Y");
            AddTheLineUnbrokenLink("N20", "79QVTxiU510");

            AddEncounterSet(EncounterSet.MistyMountainGoblins);
            AddEncounterSet(EncounterSet.OverTheMistyMountainsGrim);
            AddEncounterSet(EncounterSet.OverTheMistyMountainsGrimNightmare);
            AddEncounterSet(EncounterSet.TheGreatGoblin);
            AddEncounterSet(EncounterSet.TheGreatGoblinNightmare);
            AddEncounterSet(EncounterSet.WesternLands);

            AddQuestCardId("A-Short-Rest-THOHaUH");
            AddQuestCardId("The-Mountain-Pass-THOHaUH");
            AddQuestCardId("Down-Down-to-Goblin-Town-THOHaUH");

            ExcludeFromEasyMode("Goblin-Runners-THOHaUH", 2);
            ExcludeFromEasyMode("Grip-Grab-Pinch-Nab-THOHaUH", 3);
            ExcludeFromEasyMode("The-Goblins'-Caves-THOHaUH", 1);
            ExcludeFromEasyMode("Galloping-Boulders-THOHaUH", 3);
            ExcludeFromEasyMode("Stone-Giant-THOHaUH", 2);
            ExcludeFromEasyMode("Chaos-in-the-Cavern-THOHaUH", 2);
            ExcludeFromEasyMode("Front-Porch-THOHaUH", 1);
            ExcludeFromEasyMode("Dreary-Hills-THOHaUH", 1);
            ExcludeFromEasyMode("No-Campfire-THOHaUH", 2);
            ExcludeFromEasyMode("Wind-whipped-Rain-THOHaUH", 1);

            ExcludeFromNightmareMode("Goblin-Axeman-THOHaUH", 3);
            ExcludeFromNightmareMode("Goblin-Miners-THOHaUH", 3);
            ExcludeFromNightmareMode("Overhanging-Rock-THOHaUH", 2);
            ExcludeFromNightmareMode("Great-Cavern-Room-THOHaUH", 1);
            ExcludeFromNightmareMode("The-Great-Goblin-Enemy-THOHaUH", 1);
            ExcludeFromNightmareMode("Cave-Entrance-THOHaUH", 2);
            ExcludeFromNightmareMode("Dreary-Hills-THOHaUH", 2);
        }
    }
}

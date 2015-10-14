namespace HallOfBeorn.Models.Scenarios
{
    public class TheWatcherInTheWater : Scenario
    {
        public TheWatcherInTheWater()
        {
            Title = "The Watcher in the Water";
            ProductName = "The Watcher in the Water";
            GroupName = "Dwarrowdelf";
            Number = 0;

            AddEncounterSet(EncounterSet.MistyMountains);
            AddEncounterSet(EncounterSet.TheWatcherInTheWater);
            AddEncounterSet(EncounterSet.TheWatcherInTheWaterNightmare);

            AddQuestCardId("To-the-West-door-TWitW");
            AddQuestCardId("The-Seething-Lake-TWitW");

            ExcludeFromEasyMode("Mountain-Warg-KD", 1);
            ExcludeFromEasyMode("Turbulent-Waters-KD", 1);
            ExcludeFromEasyMode("Grasping-Tentacle-TWitW", 1);
            ExcludeFromEasyMode("Ill-Purpose-TWitW", 1);
            ExcludeFromEasyMode("Stagnant-Creek-TWitW", 2);
            ExcludeFromEasyMode("Striking-Tentacle-TWitW", 1);
            ExcludeFromEasyMode("Thrashing-Tentacle-TWitW", 1);
            ExcludeFromEasyMode("Wrapped-TWitW", 2);

            ExcludeFromNightmareMode("Black-Uruks-KD", 4);
            ExcludeFromNightmareMode("Mountain-Warg-KD", 3);
            ExcludeFromNightmareMode("Warg-Lair-KD", 2);
            ExcludeFromNightmareMode("Makeshift-Passage-TWitW", 2);
            ExcludeFromNightmareMode("The-Watcher-TWitW", 1);
        }
    }
}

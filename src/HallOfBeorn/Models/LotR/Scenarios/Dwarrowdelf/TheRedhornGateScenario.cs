namespace HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf
{
    public class TheRedhornGateScenario : Scenario
    {
        public TheRedhornGateScenario()
            : base(true)
        {
            Title = "The Redhorn Gate";
            ProductName = "The Redhorn Gate";
            GroupName = "Dwarrowdelf";
            Number = 1;

            QuestCompanionSlug = "dwarrowdelf-quest-the-redhorn-gate";
            DifficultyRating = 5.6f;
            Votes = 56;

            AddProgressionSeriesLink("14", "aqFGU0f7XBU");
            AddTheLineUnbrokenLink("13", "iTjMI97tsqA");
            AddTheLineUnbrokenLink("N13", "lkIGd0RNEK0");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/03/20/the-redhorn-gate/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/02/18/the-redhorn-gate/");

            AddEncounterSet(EncounterSet.MistyMountains);
            AddEncounterSet(EncounterSet.TheRedhornGate);
            AddEncounterSet(EncounterSet.TheRedhornGateNightmare);

            AddQuestCardId("Up-the-Pass-TRG");
            AddQuestCardId("Snowdrifts-TRG");
            AddQuestCardId("The-Mountains'-Peaks-TRG");

            ExcludeFromEasyMode("Mountain-Warg-KD", 1);
            ExcludeFromEasyMode("Turbulent-Waters-KD", 1);
            ExcludeFromEasyMode("Avalanche-TRG", 1);
            ExcludeFromEasyMode("Freezing-Cold-TRG", 2);
            ExcludeFromEasyMode("Mountain-Troll-TRG", 2);
            ExcludeFromEasyMode("Rocky-Crags-TRG", 2);

            ExcludeFromNightmareMode("Black-Uruks-KD", 1);
            ExcludeFromNightmareMode("Knees-of-the-Mountain-KD", 1);
            ExcludeFromNightmareMode("Mountain-Warg-KD", 3);
            ExcludeFromNightmareMode("Turbulent-Waters-KD", 2);
            ExcludeFromNightmareMode("Warg-Lair-KD", 2);
            ExcludeFromNightmareMode("Fallen-Stones-TRG", 2);
            ExcludeFromNightmareMode("Fell-Voices-TRG", 2);
            ExcludeFromNightmareMode("Mountain-Goblin-TRG", 3);
            ExcludeFromNightmareMode("The-Dimrill-Stair-TRG", 1);
        }
    }
}

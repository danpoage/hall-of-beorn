namespace HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf
{
    public class RoadToRivendellScenario : Scenario
    {
        public RoadToRivendellScenario()
        {
            Title = "Road to Rivendell";
            ProductName = "Road to Rivendell";
            GroupName = "Dwarrowdelf";
            Number = 2;

            QuestCompanionSlug = "dwarrowdelf-quest-road-to-rivendell";
            DifficultyRating = 5.2f;
            Votes = 53;

            AddProgressionSeriesLink("15", "Vp7MLcnEA6E");
            AddTheLineUnbrokenLink("14", "s_6mBCPPuuw");
            AddTheLineUnbrokenLink("N14", "gUGhtPi8X7I");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/04/02/road-to-rivendell/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/02/24/road-to-rivendell/");

            AddEncounterSet(EncounterSet.MistyMountains);
            AddEncounterSet(EncounterSet.PlunderingGoblins);
            AddEncounterSet(EncounterSet.RoadToRivendell);
            AddEncounterSet(EncounterSet.RoadToRivendellNightmare);

            AddQuestCardId("Along-the-Misty-Mountains-RtR");
            AddQuestCardId("Orc-Outpost-RtR");
            AddQuestCardId("Ambush-in-the-Night-RtRN");
            AddQuestCardId("Approaching-Rivendell-RtR");

            ExcludeFromEasyMode("Mountain-Warg-KD", 1);
            ExcludeFromEasyMode("Turbulent-Waters-KD", 1);
            ExcludeFromEasyMode("Chieftain-of-the-Pit-KD", 1);
            ExcludeFromEasyMode("Undisturbed-Bones-KD", 2);
            ExcludeFromEasyMode("Followed-by-Night-RtR", 2);
            ExcludeFromEasyMode("Orc-Ambush-RtR", 2);
            ExcludeFromEasyMode("Sleeping-Sentry-RtR", 2);

            ExcludeFromNightmareMode("Bitter-Wind-KD", 3);
            ExcludeFromNightmareMode("Black-Uruks-KD", 4);
            ExcludeFromNightmareMode("Mountain-Warg-KD", 3);
            ExcludeFromNightmareMode("Warg-Lair-KD", 2);
            ExcludeFromNightmareMode("Goblin-Archer-KD", 2);
            ExcludeFromNightmareMode("Goblin-Spearman-KD", 5);
            ExcludeFromNightmareMode("Plundered-Armoury-KD", 2);
            ExcludeFromNightmareMode("Barren-Hills-RtR", 2);
            ExcludeFromNightmareMode("Goblin-Taskmaster-RtR", 1);
            ExcludeFromNightmareMode("Ruined-Road-RtR", 2);
        }
    }
}

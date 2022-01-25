namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class TheNinInEilphScenario : Scenario
    {
        public TheNinInEilphScenario()
            : base(true)
        {
            Title = "The Nîn-in-Eilph";
            ProductName = "The Nîn-in-Eilph";
            GroupName = "The Ring-maker";
            Number = 4;

            QuestCompanionSlug = "the-ring-maker-quest-the-nin-in-eilph";
            DifficultyRating = 6.8f;
            Votes = 26;

            AddTheLineUnbrokenLink("40", "gf8OSXVfZ4M");

            AddEncounterSet(EncounterSet.TheNinInEilph);
            AddEncounterSet(EncounterSet.WearyTravelers);
            AddEncounterSet(EncounterSet.TheNinInEilphNightmare);

            AddQuestCardId("Fleeing-from-Tharbad-NiE");
            AddQuestCardId("Through-the-Marsh-No-End-in-Sight-NiE");
            AddQuestCardId("Through-the-Marsh-A-Weary-Passage-NiE");
            AddQuestCardId("Through-the-Marsh-A-Forgotten-Land-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Impassable-Marshland-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-A-Treacherous-Swamp-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Creatures-of-a-Forgotten-Age-NiE");
            AddQuestCardId("Out-of-the-Swamp-NiE");

            ExcludeFromEasyMode("Fen-of-Reeds-NiE", 1);
            ExcludeFromEasyMode("Giant-Swamp-Adder-NiE", 1);
            ExcludeFromEasyMode("Remnants-of-Elder-Days-NiE", 1);
            ExcludeFromEasyMode("Shifting-Marshland-NiE", 1);
            ExcludeFromEasyMode("In-Need-of-Rest-VoI", 1);
            ExcludeFromEasyMode("Low-on-Provisions-VoI", 1);

            ExcludeFromNightmareMode("Through-the-Marsh-A-Weary-Passage-NiE", 1);
            ExcludeFromNightmareMode("Lost-in-the-Swanfleet-Impassable-Marshland-NiE", 1);
            ExcludeFromNightmareMode("Neekerbreekers-NiE", 3);
            ExcludeFromNightmareMode("Hidden-Eyot-NiE", 1);
            ExcludeFromNightmareMode("Finger-of-Glanduin-NiE", 3);
            ExcludeFromNightmareMode("Off-Track-VoI", 2);
            ExcludeFromNightmareMode("Low-on-Provisions-VoI", 1);
        }
    }
}

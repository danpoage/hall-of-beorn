namespace HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf
{
    public class TheLongDark : Scenario
    {
        public TheLongDark()
        {
            Title = "The Long Dark";
            ProductName = "The Long Dark";
            GroupName = "Dwarrowdelf";
            Number = 4;

            QuestCompanionSlug = "dwarrowdelf-quest-the-long-dark";
            DifficultyRating = 3.7f;
            Votes = 47;

            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.TheLongDark);
            AddEncounterSet(EncounterSet.TheLongDarkNightmare);
            AddEncounterSet(EncounterSet.TwistsAndTurns);

            AddQuestCardId("Journey-in-the-Black-Pit-TLD");
            AddQuestCardId("Continuing-Eastward-TLD");

            ExcludeFromEasyMode("Great-Cave-troll-KD", 2);
            ExcludeFromEasyMode("Massing-in-the-Deep-KD", 2);
            ExcludeFromEasyMode("Orc-Drummer-KD", 1);
            ExcludeFromEasyMode("Foul-Air-TLD", 3);
            ExcludeFromEasyMode("Gathering-Ground-TLD", 1);
            ExcludeFromEasyMode("Goblin-Warlord-TLD", 1);
            ExcludeFromEasyMode("Vast-and-Intricate-TLD", 1);
            ExcludeFromEasyMode("Branching-Paths-KD", 2);
            ExcludeFromEasyMode("Lightless-Passage-KD", 1);
            ExcludeFromEasyMode("Zigil-Mineshaft-KD", 2);

            ExcludeFromNightmareMode("Chance-Encounter-KD", 2);
            ExcludeFromNightmareMode("Stray-Goblin-KD", 2);
            ExcludeFromNightmareMode("The-Mountains'-Roots-KD", 2);
            ExcludeFromNightmareMode("Abandoned-Mine-TLD", 1);
            ExcludeFromNightmareMode("Fatigue-TLD", 2);
            ExcludeFromNightmareMode("Goblin-Sneak-TLD", 4);
            ExcludeFromNightmareMode("Rock-Adder-TLD", 3);
            ExcludeFromNightmareMode("Branching-Paths-KD", 1);
            ExcludeFromNightmareMode("Burning-Low-KD", 3);
            ExcludeFromNightmareMode("Goblin-Follower-KD", 4);
        }
    }
}

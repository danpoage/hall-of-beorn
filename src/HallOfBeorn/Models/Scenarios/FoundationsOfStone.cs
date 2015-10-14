namespace HallOfBeorn.Models.Scenarios
{
    public class FoundationsOfStone : Scenario
    {
        public FoundationsOfStone()
        {
            Title = "Foundations of Stone";
            ProductName = "Foundations of Stone";
            GroupName = "Dwarrowdelf";
            Number = 0;

            AddEncounterSet(EncounterSet.FoundationsOfStone);
            AddEncounterSet(EncounterSet.FoundationsOfStoneNightmare);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeepNightmare);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.TwistsAndTurns);

            AddQuestCardId("The-Dripping-Walls-FoS");
            AddQuestCardId("The-Water's-Edge-FoS");
            AddQuestCardId("Washed-Away-FoS");
            AddQuestCardId("Below-the-Mines-Sheltered-Rocks-FoS");
            AddQuestCardId("Below-the-Mines-The-Endless-Caves-FoS");
            AddQuestCardId("Below-the-Mines-The-Shivering-Bank-FoS");
            AddQuestCardId("Below-the-Mines-Old-One-Lair-FoS");
            AddQuestCardId("Out-of-the-Depths-FoS");

            ExcludeFromEasyMode("Elder-Nameless-Thing-FoS", 2);
            ExcludeFromEasyMode("Lost-and-Alone-FoS", 2);
            ExcludeFromEasyMode("Nameless-Thing-FoS", 2);
            ExcludeFromEasyMode("Watchful-Eyes-KD", 3);
            ExcludeFromEasyMode("Crumbling-Ruin-KD", 2);
            ExcludeFromEasyMode("Dark-and-Dreadful-KD", 1);
            ExcludeFromEasyMode("Dreadful-Gap-KD", 1);
            ExcludeFromEasyMode("Sudden-Pitfall-KD", 1);
            ExcludeFromEasyMode("Branching-Paths-KD", 2);
            ExcludeFromEasyMode("Lightless-Passage-KD", 1);
            ExcludeFromEasyMode("Zigil-Mineshaft-KD", 2);

            ExcludeFromNightmareMode("Drowned-Treasury-FoS", 3);
            ExcludeFromNightmareMode("Mithril-Lode-FoS", 1);
            ExcludeFromNightmareMode("Moria-Bats-FoS", 4);
            ExcludeFromNightmareMode("Goblin-Scout-KD", 3);
            ExcludeFromNightmareMode("Goblin-Swordsman-KD", 2);
            ExcludeFromNightmareMode("Cave-In-KD", 3);
            ExcludeFromNightmareMode("Branching-Paths-KD", 1);
            ExcludeFromNightmareMode("Burning-Low-KD", 3);
            ExcludeFromNightmareMode("Goblin-Follower-KD", 1);
            ExcludeFromNightmareMode("Many-Roads-KD", 1);
        }
    }
}

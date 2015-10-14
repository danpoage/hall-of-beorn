namespace HallOfBeorn.Models.Scenarios
{
    public class IntoThePit : Scenario
    {
        public IntoThePit()
        {
            Title = "Into the Pit";
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
            Number = 1;

            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.IntoThePit);
            AddEncounterSet(EncounterSet.IntoThePitNightmare);
            AddEncounterSet(EncounterSet.TwistsAndTurns);

            AddQuestCardId("Entering-the-Mines-KD");
            AddQuestCardId("Goblin-Patrol-KD");
            AddQuestCardId("Goblin-Ambush-ItPN");
            AddQuestCardId("A-Way-Up-KD");

            ExcludeFromEasyMode("Watchful-Eyes-KD", 3);
            ExcludeFromEasyMode("Crumbling-Ruin-KD", 2);
            ExcludeFromEasyMode("Dark-and-Dreadful-KD", 1);
            ExcludeFromEasyMode("Dreadful-Gap-KD", 1);
            ExcludeFromEasyMode("Sudden-Pitfall-KD", 1);
            ExcludeFromEasyMode("Patrol-Leader-KD", 1);
            ExcludeFromEasyMode("Signs-of-Conflict-KD", 3);
            ExcludeFromEasyMode("Branching-Paths-KD", 2);
            ExcludeFromEasyMode("Lightless-Passage-KD", 1);
            ExcludeFromEasyMode("Zigil-Mineshaft-KD", 2);

            ExcludeFromNightmareMode("Goblin-Swordsman-KD", 5);
            ExcludeFromNightmareMode("Goblin-Tunnels-KD", 2);
            ExcludeFromNightmareMode("Cave-In-KD", 3);
            ExcludeFromNightmareMode("Crumbling-Ruin-KD", 2);
            ExcludeFromNightmareMode("Fouled-Well-KD", 2);
            ExcludeFromNightmareMode("Stairs-of-Nain-KD", 2);
            ExcludeFromNightmareMode("Goblin-Follower-KD", 2);
        }
    }
}

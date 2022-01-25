namespace HallOfBeorn.Models.LotR.Scenarios.KhazadDum
{
    public class IntoThePitScenario : Scenario
    {
        public IntoThePitScenario()
            : base(true)
        {
            Title = "Into the Pit";
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
            Number = 1;

            QuestCompanionSlug = "khazad-dum-quest-into-the-pit";
            DifficultyRating = 4.9f;
            Votes = 69;

            AddProgressionSeriesLink("11", "H2vbJgdBcdE");
            AddTheLineUnbrokenLink("10", "A0UX9vsSiw0");
            AddTheLineUnbrokenLink("N10", "LFPxWbCV6gA");
            AddMrUnderhillLink(Title + " Nightmare Mode - Dwarven Miners", "06n4scyR20Q");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2014/07/16/beorns-path-part-14-into-the-pit/");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/02/06/path-less-traveled-into-the-pit/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/02/12/into-the-pit/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/02/07/into-the-pit/");

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

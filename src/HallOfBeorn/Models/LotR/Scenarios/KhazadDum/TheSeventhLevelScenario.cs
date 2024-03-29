namespace HallOfBeorn.Models.LotR.Scenarios.KhazadDum
{
    public class TheSeventhLevelScenario : Scenario
    {
        public TheSeventhLevelScenario()
            : base(true)
        {
            Title = "The Seventh Level";
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
            Number = 2;

            QuestCompanionSlug = "khazad-dum-quest-the-seventh-level";
            DifficultyRating = 4.3f;
            Votes = 66;

            AddProgressionSeriesLink("12", "oD8BbrgztbA");
            AddTheLineUnbrokenLink("11", "Xo_SlBNrFgA");
            AddTheLineUnbrokenLink("N11", "-cPiaICZd2k");
            AddBeornsPathLink(Title, "oDfVi8SfOOY");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/02/19/path-less-traveled-the-seventh-level/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/02/27/the-seventh-level/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/17/nightmare-review-the-seventh-level/", "Nightmare " + Title);
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/02/10/the-seventh-level/");

            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.PlunderingGoblins);
            AddEncounterSet(EncounterSet.TheSeventhLevel);
            AddEncounterSet(EncounterSet.TheSeventhLevelNightmare);

            AddQuestCardId("Search-for-the-Chamber-KD");
            AddQuestCardId("The-Fate-of-Balin-KD");

            ExcludeFromEasyMode("Watchful-Eyes-KD", 3);
            ExcludeFromEasyMode("Chieftain-of-the-Pit-KD", 1);
            ExcludeFromEasyMode("Undisturbed-Bones-KD", 2);
            ExcludeFromEasyMode("Cave-troll-KD", 1);
            ExcludeFromEasyMode("Orc-Horn-Blower-KD", 1);

            ExcludeFromNightmareMode("Goblin-Scout-KD", 2);
            ExcludeFromNightmareMode("Goblin-Swordsman-KD", 2);
            ExcludeFromNightmareMode("Goblin-Spearman-KD", 2);
            ExcludeFromNightmareMode("Plundered-Armoury-KD", 2);
            ExcludeFromNightmareMode("Hidden-Threat-KD", 2);
            ExcludeFromNightmareMode("Upper-Hall-KD", 2);
        }
    }
}

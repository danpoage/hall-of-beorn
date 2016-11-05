namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheSeventhLevel : Scenario
    {
        public TheSeventhLevel()
        {
            Title = "The Seventh Level";
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
            Number = 2;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/khazad-dum-quest-the-seventh-level.html";

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

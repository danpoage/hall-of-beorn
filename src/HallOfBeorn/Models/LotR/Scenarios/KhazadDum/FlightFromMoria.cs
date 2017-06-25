namespace HallOfBeorn.Models.LotR.Scenarios.KhazadDum
{
    public class FlightFromMoria : Scenario
    {
        public FlightFromMoria()
        {
            Title = "Flight from Moria";
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/khazad-dum-quest-flight-from-moria.html";

            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.FlightFromMoria);
            AddEncounterSet(EncounterSet.FlightFromMoriaNightmare);
            AddEncounterSet(EncounterSet.HazardsOfThePit);
            AddEncounterSet(EncounterSet.PlunderingGoblins);

            AddQuestCardId("A-Presence-in-the-Dark-KD");
            AddQuestCardId("Search-for-an-Exit-Heading-Down-KD");
            AddQuestCardId("Search-for-an-Exit-Heading-Up-KD");
            AddQuestCardId("Search-for-an-Exit-A-Wrong-Turn-KD");
            AddQuestCardId("Search-for-an-Exit-Narrow-Paths-KD");
            AddQuestCardId("Search-for-an-Exit-Hasty-Council-KD");
            AddQuestCardId("Search-for-an-Exit-Blocked-By-Shadow-KD");
            AddQuestCardId("Search-for-an-Exit-Escape-from-Darkness-KD");
            AddQuestCardId("Search-for-an-Exit-Pursued-By-Shadow-FfMN");
            AddQuestCardId("Search-for-an-Exit-Blocked-by-Flame-FfMN");
            AddQuestCardId("Search-for-an-Exit-Ghâsh-FfMN");

            ExcludeFromEasyMode("Great-Cave-troll-KD", 2);
            ExcludeFromEasyMode("Massing-in-the-Deep-KD", 2);
            ExcludeFromEasyMode("Orc-Drummer-KD", 1);
            ExcludeFromEasyMode("A-Foe-Beyond-KD", 3);
            ExcludeFromEasyMode("Shadow-of-Fear-KD", 2);
            ExcludeFromEasyMode("Crumbling-Ruin-KD", 2);
            ExcludeFromEasyMode("Dark-and-Dreadful-KD", 1);
            ExcludeFromEasyMode("Dreadful-Gap-KD", 1);
            ExcludeFromEasyMode("Sudden-Pitfall-KD", 1);
            ExcludeFromEasyMode("Chieftain-of-the-Pit-KD", 1);
            ExcludeFromEasyMode("Undisturbed-Bones-KD", 2);

            ExcludeFromNightmareMode("Chance-Encounter-KD", 3);
            ExcludeFromNightmareMode("Stray-Goblin-KD", 3);
            ExcludeFromNightmareMode("The-Mountains'-Roots-KD", 2);
            ExcludeFromNightmareMode("New-Devilry-KD", 1);
            ExcludeFromNightmareMode("Cave-In-KD", 3);
            ExcludeFromNightmareMode("Dark-and-Dreadful-KD", 2);
            ExcludeFromNightmareMode("Goblin-Archer-KD", 2);
            ExcludeFromNightmareMode("Goblin-Spearman-KD", 1);
            ExcludeFromNightmareMode("Plundered-Armoury-KD", 2);
        }
    }
}

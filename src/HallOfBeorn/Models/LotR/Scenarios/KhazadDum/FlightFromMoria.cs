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

            QuestCompanionSlug = "khazad-dum-quest-flight-from-moria";
            DifficultyRating = 6.0f;
            Votes = 62;

            AddProgressionSeriesLink("13", "DYA9unwUn3I");
            AddTheLineUnbrokenLink("12", "26q9pMEgiok");
            AddTheLineUnbrokenLink("N12", "Fv-9gq3pvqs");
            AddBeornsPathLink(Title, "kG4CjacD1XE");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/03/20/path-less-traveled-flight-from-moria/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/03/06/flight-from-moria/");

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
            AddQuestCardId("Search-for-an-Exit-Ghash-FfMN");

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

namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class CelebrimborsSecret : Scenario
    {
        public CelebrimborsSecret()
        {
            Title = "Celebrimbor's Secret";
            ProductName = "Celebrimbor's Secret";
            GroupName = "The Ring-maker";
            Number = 5;

            QuestCompanionSlug = "the-ring-maker-quest-celebrimbors-secret";
            DifficultyRating = 5.7f;
            Votes = 19;

            AddEncounterSet(EncounterSet.BrokenLands);
            AddEncounterSet(EncounterSet.CelebrimborsSecret);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);
            AddEncounterSet(EncounterSet.CelebrimborsSecretNightmare);

            AddQuestCardId("The-Ruins-of-Ost-in-Edhil-CS");
            AddQuestCardId("The-Enemy's-Servant-CS");

            ExcludeFromEasyMode("Take-Cover-VoI", 1);
            ExcludeFromEasyMode("Bellach's-Scout-CS", 1);
            ExcludeFromEasyMode("City-Remains-CS", 2);
            ExcludeFromEasyMode("Discovered-CS", 2);
            ExcludeFromEasyMode("Prowling-Orc-CS", 1);
            ExcludeFromEasyMode("Orc-Hound-VoI", 1);
            ExcludeFromEasyMode("Orc-Hunter-VoI", 2);

            ExcludeFromNightmareMode("Orc-Skirmisher-VoI", 1);
            ExcludeFromNightmareMode("Orc-Hunter-VoI", 1);
            ExcludeFromNightmareMode("Prowling-Wolf-VoI", 3);
            ExcludeFromNightmareMode("Ruined-Plaza-CS", 1);
            ExcludeFromNightmareMode("City-Remains-CS", 1);
            ExcludeFromNightmareMode("Ancient-Foundation-CS", 1);
            ExcludeFromNightmareMode("Broken-Lands-Location-VoI", 3);
            ExcludeFromNightmareMode("Spies-from-Mordor-CS", 1);
            ExcludeFromNightmareMode("Orc-Hunting-Party-VoI", 2);
        }
    }
}

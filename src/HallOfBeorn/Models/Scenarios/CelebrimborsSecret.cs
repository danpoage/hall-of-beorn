namespace HallOfBeorn.Models.Scenarios
{
    public class CelebrimborsSecret : Scenario
    {
        public CelebrimborsSecret()
        {
            Title = "Celebrimbor's Secret";
            ProductName = "Celebrimbor's Secret";
            GroupName = "The Ring-maker";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-ring-maker-quest-celebrimbors-secret.html";

            AddEncounterSet(EncounterSet.BrokenLands);
            AddEncounterSet(EncounterSet.CelebrimborsSecret);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);

            AddQuestCardId("The-Ruins-of-Ost-in-Edhil-CS");
            AddQuestCardId("The-Enemy's-Servant-CS");

            ExcludeFromEasyMode("Take-Cover-VoI", 1);
            ExcludeFromEasyMode("Bellach's-Scout-CS", 1);
            ExcludeFromEasyMode("City-Remains-CS", 2);
            ExcludeFromEasyMode("Discovered-CS", 2);
            ExcludeFromEasyMode("Prowling-Orc-CS", 1);
            ExcludeFromEasyMode("Orc-Hound-VoI", 1);
            ExcludeFromEasyMode("Orc-Hunter-VoI", 2);

        }
    }
}

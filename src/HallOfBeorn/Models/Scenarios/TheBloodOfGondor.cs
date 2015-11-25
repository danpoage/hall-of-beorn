namespace HallOfBeorn.Models.Scenarios
{
    public class TheBloodOfGondor : Scenario
    {
        public TheBloodOfGondor()
        {
            Title = "The Blood of Gondor";
            ProductName = "The Blood of Gondor";
            GroupName = "Against the Shadow";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/against-the-shadow-quest-the-blood-of-gondor.html";

            AddEncounterSet(EncounterSet.RavagingOrcs);
            AddEncounterSet(EncounterSet.TheBloodOfGondor);
            AddEncounterSet(EncounterSet.TheBloodOfGondorNightmare);

            AddQuestCardId("The-Ambush-TBoG");
            AddQuestCardId("Captured-TBoG");

            ExcludeFromEasyMode("Orc-Rabble-HoN", 3);
            ExcludeFromEasyMode("Brutal-Uruk-TBoG", 2);
            ExcludeFromEasyMode("Conflict-at-the-Crossroads-TBoG", 2);
            ExcludeFromEasyMode("Orc-Ambusher-TBoG", 2);

            ExcludeFromNightmareMode("Orc-Arsonist-HoN", 1);
            ExcludeFromNightmareMode("Orc-Rabble-HoN", 1);
            ExcludeFromNightmareMode("Scourge-of-Mordor-HoN", 2);
            ExcludeFromNightmareMode("Black-Numenorean-TBoG", 1);
            ExcludeFromNightmareMode("Evil-Crow-TBoG", 2);
            ExcludeFromNightmareMode("Lying-in-Wait-TBoG", 2);
            ExcludeFromNightmareMode("The-Dark-Woods-TBoG", 4);
        }
    }
}

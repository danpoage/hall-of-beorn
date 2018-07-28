namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class TheBloodOfGondor : Scenario
    {
        public TheBloodOfGondor()
        {
            Title = "The Blood of Gondor";
            ProductName = "The Blood of Gondor";
            GroupName = "Against the Shadow";
            Number = 5;

            QuestCompanionSlug = "against-the-shadow-quest-the-blood-of-gondor";
            DifficultyRating = 5.7f;
            Votes = 43;

            AddTheLineUnbrokenLink("32", "n8DEB_iuF6M");

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

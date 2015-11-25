namespace HallOfBeorn.Models.Scenarios
{
    public class TheStewardsFear : Scenario
    {
        public TheStewardsFear()
        {
            Title = "The Steward's Fear";
            ProductName = "The Steward's Fear";
            GroupName = "Against the Shadow";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/against-the-shadow-quest-the-stewards-fear.html";

            AddEncounterSet(EncounterSet.Brigands);
            AddEncounterSet(EncounterSet.StreetsOfGondor);
            AddEncounterSet(EncounterSet.TheStewardsFear);
            AddEncounterSet(EncounterSet.TheStewardsFearNightmare);

            AddQuestCardId("Conspiracy-TSF");
            AddQuestCardId("The-Grand-Design-TSF");
            AddQuestCardId("The-Confrontation-TSF");

            ExcludeFromEasyMode("Umbar-Assassin-HoN", 1);
            ExcludeFromEasyMode("Local-Trouble-HoN", 1);
            ExcludeFromEasyMode("Lost-in-the-City-HoN", 1);
            ExcludeFromEasyMode("A-Knife-in-the-Back-TSF", 2);
            ExcludeFromEasyMode("Houses-of-the-Dead-TSF", 1);

            ExcludeFromNightmareMode("Market-Square-HoN", 2);
            ExcludeFromNightmareMode("Pickpocket-HoN", 3);
            ExcludeFromNightmareMode("Storehouse-TSF", 2);
            ExcludeFromNightmareMode("Underworld-Dissident-TSF", 3);
        }
    }
}

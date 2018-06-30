namespace HallOfBeorn.Models.LotR.Scenarios.HeirsOfNumenor
{
    public class PerilInPelargir : Scenario
    {
        public PerilInPelargir()
        {
            Title = "Peril in Pelargir";
            ProductName = "Heirs of Númenor";
            GroupName = "Heirs of Númenor";
            Number = 1;

            QuestCompanionSlug = "http://lotr-lcg-quest-companion.com/heirs-of-numenor-quest-peril-in-pelargir.html";
            DifficultyRating = 6.8f;
            Votes = 59;

            AddEncounterSet(EncounterSet.Brigands);
            AddEncounterSet(EncounterSet.PerilInPelargir);
            AddEncounterSet(EncounterSet.PerilInPelargirNightmare);
            AddEncounterSet(EncounterSet.StreetsOfGondor);

            AddQuestCardId("The-Leaping-Fish-Quest-HoN");
            AddQuestCardId("Fighting-in-the-Streets-HoN");
            AddQuestCardId("Escape-to-the-Quays-HoN");

            ExcludeFromEasyMode("Umbar-Assassin-HoN", 1);
            ExcludeFromEasyMode("Pelargir-Docks-HoN", 2);
            ExcludeFromEasyMode("Local-Trouble-HoN", 1);
            ExcludeFromEasyMode("Lost-in-the-City-HoN", 1);

            ExcludeFromNightmareMode("Collateral-Damage-HoN", 4);
            ExcludeFromNightmareMode("Harbor-Storehouse-HoN", 2);
            ExcludeFromNightmareMode("Harbor-Thug-HoN", 1);
            ExcludeFromNightmareMode("Pickpocket-HoN", 3);
        }
    }
}

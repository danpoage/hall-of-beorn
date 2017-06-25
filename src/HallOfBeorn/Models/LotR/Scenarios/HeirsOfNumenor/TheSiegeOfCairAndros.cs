namespace HallOfBeorn.Models.LotR.Scenarios.HeirsOfNumenor
{
    public class TheSiegeOfCairAndros : Scenario
    {
        public TheSiegeOfCairAndros()
        {
            Title = "The Siege of Cair Andros";
            ProductName = "Heirs of Númenor";
            GroupName = "Heirs of Númenor";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/heirs-of-numenor-quest-the-siege-of-cair-andros.html";

            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.RavagingOrcs);
            AddEncounterSet(EncounterSet.Southrons);
            AddEncounterSet(EncounterSet.TheSiegeOfCairAndros);
            AddEncounterSet(EncounterSet.TheSiegeOfCairAndrosNightmare);

            AddQuestCardId("The-Defense-HoN");
            AddQuestCardId("Reinforcing-the-Banks-HoN");
            AddQuestCardId("Breakthrough-at-the-Approach-HoN");
            AddQuestCardId("Breakthrough-at-the-Citadel-HoN");
            AddQuestCardId("The-Last-Battle-HoN");

            ExcludeFromEasyMode("Orc-Vanguard-HoN", 2);
            ExcludeFromEasyMode("Orc-War-Camp-HoN", 2);
            ExcludeFromEasyMode("The-Master's-Malice-HoN", 2);
            ExcludeFromEasyMode("Orc-Rabble-HoN", 3);
            ExcludeFromEasyMode("Mumak-HoN", 1);
            ExcludeFromEasyMode("Southron-Support-HoN", 2);
            ExcludeFromEasyMode("Battering-Ram-HoN", 1);
            ExcludeFromEasyMode("Orc-Scramblers-HoN", 1);
            ExcludeFromEasyMode("Siege-Raft-HoN", 1);

            ExcludeFromNightmareMode("Orc-Arbalesters-HoN", 3);
            ExcludeFromNightmareMode("The-Power-of-Mordor-HoN", 1);
            ExcludeFromNightmareMode("Orc-Rabble-HoN", 2);
            ExcludeFromNightmareMode("Scourge-of-Mordor-HoN", 2);
            ExcludeFromNightmareMode("Southron-Mercenaries-HoN", 3);
        }
    }
}

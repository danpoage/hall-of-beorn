namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class TheTreacheryOfRhudaur : Scenario
    {
        public TheTreacheryOfRhudaur()
        {
            Title = "The Treachery of Rhudaur";
            ProductName = "Treachery of Rhudaur";
            GroupName = "Angmar Awakened";
            Number = 4;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/angmar-awakened-quest-the-treachery-of-rhudaur.html";

            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
            AddEncounterSet(EncounterSet.TheTreacheryOfRhudaur);

            AddQuestCardId("Secrets-of-Rhudaur-TToR");
            AddQuestCardId("Thaurdir's-Pursuit-TToR");

            ExcludeFromEasyMode("Cursed-Dead-TLR", 1);
            ExcludeFromEasyMode("Dead-Lord-TLR", 1);
            ExcludeFromEasyMode("Restless-Evil-TLR", 1);
            ExcludeFromEasyMode("Ruins-of-Arnor-TLR", 1);
            ExcludeFromEasyMode("Centuries-of-Sorrow-TToR", 1);
            ExcludeFromEasyMode("Curse-of-the-Years-TToR", 2);
            ExcludeFromEasyMode("Eerie-Halls-TToR", 1);
            ExcludeFromEasyMode("Ghostly-Ruins-TToR", 2);
            ExcludeFromEasyMode("Traitorous-Wight-TToR", 1);

        }
    }
}

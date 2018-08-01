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

            QuestCompanionSlug = "angmar-awakened-quest-the-treachery-of-rhudaur";
            DifficultyRating = 6.1f;
            Votes = 27;

            AddTheGreyCompanyLink(Title, "OyuHE-Jvn38");
            AddTheLineUnbrokenLink("49", "3UyYN7lZJLI");

            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.RuinsOfArnor);
            AddEncounterSet(EncounterSet.TheTreacheryOfRhudaur);
            AddEncounterSet(EncounterSet.TheTreacheryOfRhudaurNightmare);

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

            ExcludeFromNightmareMode("Decrepit-Remains-TToR", 2);
            ExcludeFromNightmareMode("Eerie-Halls-TToR", 2);
            ExcludeFromNightmareMode("Dark-Covenant-TToR", 1);
            ExcludeFromNightmareMode("Ruins-of-Arnor-TLR", 2);
            ExcludeFromNightmareMode("Tragic-Discovery-TLR", 2);
            ExcludeFromNightmareMode("Cursed-Dead-TLR", 5);
        }
    }
}

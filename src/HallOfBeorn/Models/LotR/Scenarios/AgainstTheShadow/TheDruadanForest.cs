namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class TheDruadanForest : Scenario
    {
        public TheDruadanForest()
        {
            Title = "The Drúadan Forest";
            ProductName = "The Drúadan Forest";
            GroupName = "Against the Shadow";
            Number = 2;

            QuestCompanionSlug = "against-the-shadow-quest-the-druadan-forest";
            DifficultyRating = 5.6f;
            Votes = 54;

            AddTheLineUnbrokenLink("29", "jXdNOWjqnZ4");
            AddTheLineUnbrokenLink("N29", "J89b4tYpnSo");

            AddEncounterSet(EncounterSet.BroodingForest);
            AddEncounterSet(EncounterSet.TheDruadanForest);
            AddEncounterSet(EncounterSet.TheDruadanForestNightmare);

            AddQuestCardId("The-Pursuit-TDF");
            AddQuestCardId("An-Untimely-End-TDF");
            AddQuestCardId("The-Passage-Out-TDF");

            ExcludeFromEasyMode("Lost-Companion-HoN", 2);
            ExcludeFromEasyMode("Overgrown-Trail-HoN", 2);
            ExcludeFromEasyMode("Ancestral-Clearing-TDF", 1);
            ExcludeFromEasyMode("Druadan-Drummer-TDF", 2);
            ExcludeFromEasyMode("Druadan-Hunter-TDF", 2);
            ExcludeFromEasyMode("Glade-of-Cleansing-TDF", 2);

            ExcludeFromNightmareMode("Lost-Companion-HoN", 2);
            ExcludeFromNightmareMode("Overgrown-Trail-HoN", 1);
            ExcludeFromNightmareMode("Secluded-Glade-HoN", 3);
            ExcludeFromNightmareMode("Druadan-Elite-TDF", 1);
            ExcludeFromNightmareMode("Druadan-Hunter-TDF", 1);
            ExcludeFromNightmareMode("Dru-buri-Dru-TDF", 1);
            ExcludeFromNightmareMode("Men-in-the-Dark-TDF", 1);
        }
    }
}

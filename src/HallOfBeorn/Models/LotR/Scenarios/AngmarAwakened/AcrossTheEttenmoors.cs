namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class AcrossTheEttenmoors : Scenario
    {
        public AcrossTheEttenmoors()
        {
            Title = "Across the Ettenmoors";
            ProductName = "Across the Ettenmoors";
            GroupName = "Angmar Awakened";
            Number = 3;

            QuestCompanionSlug = "angmar-awakened-quest-across-the-ettenmoors";
            DifficultyRating = 4.4f;
            Votes = 27;

            AddTheLineUnbrokenLink("48", "5k3ZRulOtKE");

            AddEncounterSet(EncounterSet.AcrossTheEttenmoors);
            AddEncounterSet(EncounterSet.AcrossTheEttenmoorsNightmare);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);

            AddQuestCardId("Into-the-Ettenmoors-AtE");
            AddQuestCardId("Into-the-Ettenmoors-AtEN");
            AddQuestCardId("A-Miserable-Journey-AtE");
            AddQuestCardId("Journey's-End-AtE");

            ExcludeFromEasyMode("Arador's-Bane-AtE", 1);
            ExcludeFromEasyMode("Barren-Moorland-AtE", 2);
            ExcludeFromEasyMode("Coldfell-Giant-AtE", 2);
            ExcludeFromEasyMode("Cruel-Mountain-troll-AtE", 2);
            ExcludeFromEasyMode("Pressing-Needs-TLR", 1);
            ExcludeFromEasyMode("Shrouded-Hills-TLR", 1);
            ExcludeFromEasyMode("Weight-of-Responsibility-TLR", 1);
            ExcludeFromEasyMode("Biting-Wind-TLR", 1);
            ExcludeFromEasyMode("Cold-from-Angmar-TLR", 1);
            ExcludeFromEasyMode("Freezing-Blast-TLR", 1);

            ExcludeFromNightmareMode("Into-the-Ettenmoors-AtE", 1);
            ExcludeFromNightmareMode("Shrouded-Hills-TLR", 2);
            ExcludeFromNightmareMode("No-Rest-AtE", 3);
            ExcludeFromNightmareMode("Arador's-Bane-AtE", 2);
            ExcludeFromNightmareMode("Troll-fells-AtE", 1);
            ExcludeFromNightmareMode("Goblin-Pursuer-AtE", 2);
            ExcludeFromNightmareMode("Cold-from-Angmar-TLR", 2);
        }
    }
}

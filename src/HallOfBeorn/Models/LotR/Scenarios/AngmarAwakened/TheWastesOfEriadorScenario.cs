namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class TheWastesOfEriadorScenario : Scenario
    {
        public TheWastesOfEriadorScenario()
        {
            Title = "The Wastes of Eriador";
            ProductName = "The Wastes of Eriador";
            GroupName = "Angmar Awakened";
            Number = 1;

            QuestCompanionSlug = "angmar-awakened-quest-the-wastes-of-eriador";
            DifficultyRating = 7.2f;
            Votes = 30;

            AddTheLineUnbrokenLink("46", "RHr1bLYKzec");
            AddMrUnderhillLink(Title + " - Two Player", "lkLWwrBF56M");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/10/22/the-wastes-of-eriador/");

            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);
            AddEncounterSet(EncounterSet.TheWastesOfEriador);
            AddEncounterSet(EncounterSet.TheWastesOfEriadorNightmare);

            AddQuestCardId("Across-the-Wastes-TWoE");
            AddQuestCardId("Howling-at-Night-TWoE");
            AddQuestCardId("Battle-with-the-Pack-TWoE");

            ExcludeFromEasyMode("Pressing-Needs-TLR", 1);
            ExcludeFromEasyMode("Shrouded-Hills-TLR", 1);
            ExcludeFromEasyMode("Weight-of-Responsibility-TLR", 1);
            ExcludeFromEasyMode("Biting-Wind-TLR", 1);
            ExcludeFromEasyMode("Cold-from-Angmar-TLR", 1);
            ExcludeFromEasyMode("Freezing-Blast-TLR", 1);
            ExcludeFromEasyMode("Blood-thirsty-Warg-TWoE", 1);
            ExcludeFromEasyMode("Hunting-Pack-TWoE", 1);
            ExcludeFromEasyMode("Northern-Warg-TWoE", 1);
            ExcludeFromEasyMode("Predatory-Wolves-TWoE", 1);
            ExcludeFromEasyMode("Sudden-Darkness-TWoE", 1);
            ExcludeFromEasyMode("Warg's-Den-TWoE", 1);
            ExcludeFromEasyMode("Wolf-of-Angmar-TWoE", 1);

            ExcludeFromNightmareMode("Northern-Warg-TWoE", 2);
            ExcludeFromNightmareMode("White-Warg-TWoE", 1);
            ExcludeFromNightmareMode("Sudden-Darkness-TWoE", 1);
            ExcludeFromNightmareMode("North-Downs-TWoE", 1);
            ExcludeFromNightmareMode("Eriador-Wastes-TWoE", 2);
            ExcludeFromNightmareMode("Cold-from-Angmar-TLR", 1);
            ExcludeFromNightmareMode("Biting-Wind-TLR", 3);
            ExcludeFromNightmareMode("Freezing-Blast-TLR", 1);
            ExcludeFromNightmareMode("Shrouded-Hills-TLR", 1);
            ExcludeFromNightmareMode("Rugged-Country-TLR", 3);
            ExcludeFromNightmareMode("Pressing-Needs-TLR", 2);
        }
    }
}

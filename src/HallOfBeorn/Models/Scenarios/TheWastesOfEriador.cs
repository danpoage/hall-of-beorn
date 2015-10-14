namespace HallOfBeorn.Models.Scenarios
{
    public class TheWastesOfEriador : Scenario
    {
        public TheWastesOfEriador()
        {
            Title = "The Wastes of Eriador";
            ProductName = "The Wastes of Eriador";
            GroupName = "Angmar Awakened";
            Number = 1;

            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.FoulWeather);
            AddEncounterSet(EncounterSet.TheWastesOfEriador);

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

        }
    }
}

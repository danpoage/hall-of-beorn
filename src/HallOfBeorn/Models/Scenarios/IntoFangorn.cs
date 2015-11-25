namespace HallOfBeorn.Models.Scenarios
{
    public class IntoFangorn : Scenario
    {
        public IntoFangorn()
        {
            Title = "Into Fangorn";
            ProductName = "The Voice of Isengard";
            GroupName = "The Voice of Isengard";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/voice-of-isengard-quest-into-fangorn.html";

            AddEncounterSet(EncounterSet.AncientForest);
            AddEncounterSet(EncounterSet.IntoFangorn);
            AddEncounterSet(EncounterSet.IntoFangornNightmare);
            AddEncounterSet(EncounterSet.WearyTravelers);

            AddQuestCardId("Into-the-Woods-VoI");
            AddQuestCardId("Escape-from-Fangorn-VoI");
            AddQuestCardId("The-Angry-Forest-VoI");

            ExcludeFromEasyMode("Ancient-Forest-Location-VoI", 2);
            ExcludeFromEasyMode("Angry-Huorn-VoI", 1);
            ExcludeFromEasyMode("Dark-Hearted-Huorn-VoI", 1);
            ExcludeFromEasyMode("Deadly-Huorn-VoI", 1);
            ExcludeFromEasyMode("The-Forest's-Malice-VoI", 3);
            ExcludeFromEasyMode("In-Need-of-Rest-VoI", 1);
            ExcludeFromEasyMode("Low-on-Provisions-VoI", 1);

            ExcludeFromNightmareMode("Tangled-Woods-VoI", 3);
            ExcludeFromNightmareMode("Turned-Around-VoI", 3);
            ExcludeFromNightmareMode("Deadly-Huorn-VoI", 3);
        }
    }
}

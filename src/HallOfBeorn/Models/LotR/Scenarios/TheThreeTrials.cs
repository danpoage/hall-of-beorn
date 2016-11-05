namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheThreeTrials : Scenario
    {
        public TheThreeTrials()
            : base(true)
        {
            Title = "The Three Trials";
            ProductName = "The Three Trials";
            GroupName = "The Ring-maker";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-ring-maker-quest-the-three-trials.html";

            AddEncounterSet(EncounterSet.AncientForest);
            AddEncounterSet(EncounterSet.TheThreeTrials);
            AddEncounterSet(EncounterSet.TheThreeTrialsNightmare);

            AddQuestCardId("The-Trials-Begin-TTT");
            AddQuestCardId("The-Trial-of-Strength-TTT");
            AddQuestCardId("The-Trial-of-Perseverance-TTT");
            AddQuestCardId("The-Trial-of-Intuition-TTT");
            AddQuestCardId("The-Antlered-Crown-TTT");

            ExcludeFromEasyMode("Ancient-Forest-Location-VoI", 2);
            ExcludeFromEasyMode("Curse-of-the-Wild-Men-TTT", 1);
            ExcludeFromEasyMode("Grim-Foothills-TTT", 1);
            ExcludeFromEasyMode("Spirit-of-the-Wild-TTT", 1);
            ExcludeFromEasyMode("The-Guardian's-Fury-TTT", 2);
            ExcludeFromEasyMode("Wild-Tenacity-TTT", 1);

            ExcludeFromNightmareMode("Spirit-of-the-Wild-TTT", 3);
            ExcludeFromNightmareMode("Grim-Foothills-TTT", 3);
            ExcludeFromNightmareMode("Tangled-Woods-VoI", 1);
            ExcludeFromNightmareMode("Turned-Around-VoI", 3);
        }
    }
}

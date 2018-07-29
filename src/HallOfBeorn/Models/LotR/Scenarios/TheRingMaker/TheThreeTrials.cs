namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class TheThreeTrials : Scenario
    {
        public TheThreeTrials()
            : base(true)
        {
            Title = "The Three Trials";
            ProductName = "The Three Trials";
            GroupName = "The Ring-maker";
            Number = 2;

            QuestCompanionSlug = "the-ring-maker-quest-the-three-trials";
            DifficultyRating = 7.2f;
            Votes = 30;

            AddTheLineUnbrokenLink("38", "9LSluFqf02c");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2018/04/24/nightmare-the-three-trials/");

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

namespace HallOfBeorn.Models.Scenarios
{
    public class TheThreeTrials : Scenario
    {
        public TheThreeTrials()
        {
            Title = "The Three Trials";
            ProductName = "The Three Trials";
            GroupName = "The Ring-maker";
            Number = 0;

            AddEncounterSet(EncounterSet.AncientForest);
            AddEncounterSet(EncounterSet.TheThreeTrials);

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

        }
    }
}

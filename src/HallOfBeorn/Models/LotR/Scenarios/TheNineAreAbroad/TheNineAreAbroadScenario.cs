using System;

namespace HallOfBeorn.Models.LotR.Scenarios.TheNineAreAbroad
{
    public class TheNineAreAbroadScenario
        : Scenario
    {
        public TheNineAreAbroadScenario()
        {
            Title = "The Nine are Abroad";
            ProductName = "The Nine are Abroad";
            GroupName = ScenarioGroup.StandAlongAlepScenarios;
            Number = 2;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP09.pdf";

            //QuestCompanionSlug = "standalone-quests-quest-the-scouring-of-the-shire";
            DifficultyRating = 9f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheNineAreAbroad);
            AddEncounterSet(EncounterSet.Region);
            
            AddQuestCardId("Search-for-the-Nine-TNaA");
            AddQuestCardId("To-Mordor-We-Will-Send-Them-TNaA");
        }
    }
}
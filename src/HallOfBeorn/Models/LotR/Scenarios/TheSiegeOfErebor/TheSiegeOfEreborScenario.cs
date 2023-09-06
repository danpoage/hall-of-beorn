using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheSiegeOfErebor
{
    public class TheSiegeOfEreborScenario
        : Scenario
    {
        public TheSiegeOfEreborScenario()
        {
            Title = "The Siege of Erebor";
            ProductName = "The Siege of Erebor";
            GroupName = ScenarioGroup.StandAlongAlepScenarios;
            Number = 3;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP10.pdf";

            //QuestCompanionSlug = "standalone-quests-quest-the-siege-of-erebor";
            DifficultyRating = 7f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheSiegeOfErebor);
            
            AddQuestCardId("The-Siege-of-Erebor-TSoE");
            AddQuestCardId("The-Eastern-Defenses-TSoE");
            AddQuestCardId("The-Riverlands-TSoE");
            AddQuestCardId("Dale-TSoE");
            AddQuestCardId("Erebor-TSoE");
        }
    }
}
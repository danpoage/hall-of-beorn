using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheSiegeOfAnnuminasScenario : Scenario
    {
        public TheSiegeOfAnnuminasScenario()
        {
            Title = "The Siege of Annúminas";
            ProductName = "2016";
            GroupName = ScenarioGroup.FellowshipDecks;
            IsSubGroup = true;
            Number = 7;

            QuestCompanionSlug = "print-on-demand-quest-the-siege-of-annuminas";
            DifficultyRating = 8.3f;
            Votes = 13;

            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/06/11/the-seige-of-annuminas/", Title);
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2017/10/02/review-siege-of-annuminas/", Title);

            AddEncounterSet(EncounterSet.TheSiegeOfAnnuminas);

            AddQuestCardId("Rebuild-the-Defenses-TSoA");
            AddQuestCardId("Defend-the-City-TSoA");
            AddQuestCardId("Lead-the-Sortie-TSoA");
            AddQuestCardId("Raise-the-Levee-TSoA");
            AddQuestCardId("Guard-the-Gate-TSoA");
            AddQuestCardId("Rescue-the-Captives-TSoA");
            AddQuestCardId("Delay-the-Enemy-TSoA");
            AddQuestCardId("Man-the-Walls-TSoA");
            AddQuestCardId("Stop-the-Attack-TSoA");
        }
    }
}
using System;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class FireOnTheEastemnetScenario
        : Scenario
    {
        public FireOnTheEastemnetScenario()
        {
            Title = "Fire on the Eastemnet";
            ProductName = "Fire on the Eastemnet";
            GroupName = "Oaths of the Rohirrim";
            Number = 2;

            //RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP03.pdf";

            //QuestCompanionSlug = "oaths-of-the-rohirrim-quest-fire-on-the-eastemnet";
            //DifficultyRating = 5f;
            //Votes = 1;

            AddEncounterSet(EncounterSet.FireOnTheEastemnet);
            AddEncounterSet(EncounterSet.OrcHost);

            AddQuestCardId("Poachers-in-the-Night-FotE");
            AddQuestCardId("Relentless-Forces-FotE");
            AddQuestCardId("To-the-River-FotE");

            //Orc-Host
            ExcludeFromEasyMode("Crimson-Banner-CoE", 1);
        }
    }
}
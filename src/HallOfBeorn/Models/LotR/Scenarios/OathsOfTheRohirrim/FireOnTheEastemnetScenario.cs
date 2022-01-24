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

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP03.pdf";

            QuestCompanionSlug = "oaths-of-the-rohirrim-quest-fire-on-the-eastemnet";
            DifficultyRating = 5f;
            Votes = 2;

            AddEncounterSet(EncounterSet.FireOnTheEastemnet);
            AddEncounterSet(EncounterSet.OrcHost);

            AddQuestCardId("Poachers-in-the-Night-FotE");
            AddQuestCardId("Relentless-Forces-FotE");
            AddQuestCardId("To-the-River-FotE");

            //Fire on the Eastemnet
            ExcludeFromEasyMode("White-Mountain-Beastmaster-FotE", 1);
            ExcludeFromEasyMode("Orcish-Wrangler-FotE", 1);
            ExcludeFromEasyMode("Hidden-Orc-Camp-FotE", 1);
            ExcludeFromEasyMode("Cracking-Horse-Whip-FotE", 1);

            //Orc-Host
            ExcludeFromEasyMode("Crimson-Banner-CoE", 1);
        }
    }
}
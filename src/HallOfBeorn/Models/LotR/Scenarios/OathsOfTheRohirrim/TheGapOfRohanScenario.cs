using System;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class TheGapOfRohanScenario
        : Scenario
    {
        public TheGapOfRohanScenario()
        {
            Title = "The Gap of Rohan";
            ProductName = "The Gap of Rohan";
            GroupName = "Oaths of the Rohirrim";
            Number = 3;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP04.pdf";

            //QuestCompanionSlug = "oaths-of-the-rohirrim-quest-the-gap-of-rohan";
            //DifficultyRating = 6f;
            //Votes = 1;

            AddEncounterSet(EncounterSet.TheGapOfRohan);
            AddEncounterSet(EncounterSet.FaithlessRohirrim);
            AddEncounterSet(EncounterSet.RohanWeather);

            AddQuestCardId("Giving-Chase-TGoR");
            AddQuestCardId("A-Dangerous-Pursuit-TGoR");
            AddQuestCardId("Biting-Winds-TGoR");
            AddQuestCardId("Recapture-the-Traitor-TGoR");

            //The Gap of Rohan
            ExcludeFromEasyMode("Dunlending-Rearguard-TGoR", 1);
            ExcludeFromEasyMode("Snowbank-TGoR", 5);
            ExcludeFromEasyMode("Snow-Squall-TGoR", 1);
            ExcludeFromEasyMode("Frozen-Solid-TGoR", 1);
            ExcludeFromEasyMode("Stumble-in-the-Snow-TGoR", 1);
            ExcludeFromEasyMode("Unnatural-Cold-TGoR", 1);

            //Faithless Rohirrim
            ExcludeFromEasyMode("Recreant-Rider-CoE", 1);
            ExcludeFromEasyMode("Deadly-Defector-CoE", 2);

            //Rohan Weather
            ExcludeFromEasyMode("Cold-from-the-Mountains-CoE", 1);
            ExcludeFromEasyMode("Exhausting-Winds-CoE", 1);
        }
    }
}
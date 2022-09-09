using System;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class BloodInTheIsenScenario
        : Scenario
    {
        public BloodInTheIsenScenario()
        {
            Title = "Blood in the Isen";
            ProductName = "Blood in the Isen";
            GroupName = "Oaths of the Rohirrim";
            Number = 6;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP07.pdf";

            //QuestCompanionSlug = "oaths-of-the-rohirrim-quest-the-glittering-caves";
            DifficultyRating = 9f;
            Votes = 1;

            AddEncounterSet(EncounterSet.BloodInTheIsen);
            AddEncounterSet(EncounterSet.DunlendingWarriors);

            AddQuestCardId("Crossing-the-Fords-BitI");
            AddQuestCardId("The-Battle-is-Joined-BitI");
            AddQuestCardId("The-Flight-of-Ealdwulf-BitI");

            //Blood in the Isen
            ExcludeFromEasyMode("Dunland-Axe-hand-BitI", 1);
            ExcludeFromEasyMode("Fleet-footed Dunlending-BitI", 2);
            ExcludeFromEasyMode("Spurned-Hillman-BitI", 2);
            ExcludeFromEasyMode("Contested-Battleground-BitI", 1);
            ExcludeFromEasyMode("Defensive-Outcrop-BitI", 2);
            ExcludeFromEasyMode("North-South-Road-BitI", 2);
            ExcludeFromEasyMode("Coordinated-Assault-BitI", 2);
            ExcludeFromEasyMode("Heavy-Losses-BitI", 1);
            ExcludeFromEasyMode("Open-Rebellion-BitI", 1);

            //Dunlending Warriors
            ExcludeFromEasyMode("Wild-Ravager-CoE", 2);
            ExcludeFromEasyMode("Hillman-Scout-CoE", 1);
            ExcludeFromEasyMode("Surprise-Attack-CoE", 1);
        }
    }
}
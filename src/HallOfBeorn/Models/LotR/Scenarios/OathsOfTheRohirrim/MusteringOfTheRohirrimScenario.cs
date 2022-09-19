using System;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class MusteringOfTheRohirrimScenario
        : Scenario
    {
        public MusteringOfTheRohirrimScenario()
        {
            Title = "Mustering of the Rohirrim";
            ProductName = "Mustering of the Rohirrim";
            GroupName = "Oaths of the Rohirrim";
            Number = 5;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP06.pdf";

            QuestCompanionSlug = "http://www.lotr-lcg-quest-companion.gamersdungeon.net/#oaths-of-the-rohirrim-quest-mustering-of-the-rohirrim";
            DifficultyRating = 7f;
            Votes = 1;

            AddEncounterSet(EncounterSet.MusteringOfTheRohirrim);
            AddEncounterSet(EncounterSet.RohanLands);
            AddEncounterSet(EncounterSet.RohanWeather);

            AddQuestCardId("Oaths-of-the-Rohirrim-MotR");
            AddQuestCardId("Seeking-Support-MotR");
            AddQuestCardId("Halls-of-Ealdwulf-MotR");

            //Rohan Lands
            ExcludeFromEasyMode("Wild-Country-CoE", 1);
            ExcludeFromEasyMode("Windworn-Villages-CoE", 1);
            ExcludeFromEasyMode("Humpbacked-Downs-CoE", 1);

            //Rohan Weather
            ExcludeFromEasyMode("Cold-from-the-Mountains-CoE", 1);
            ExcludeFromEasyMode("Exhausting-Winds-CoE", 1);

            ExcludeFromEasyMode("Aldburg-Provocateur-MotR", 2);
            ExcludeFromEasyMode("Pernicious-Plotter-MotR", 2);
            ExcludeFromEasyMode("Raven-Clan-Sharpshooter-MotR", 2);
            ExcludeFromEasyMode("Cutthroat's-Strike-MotR", 1);
        }
    }
}
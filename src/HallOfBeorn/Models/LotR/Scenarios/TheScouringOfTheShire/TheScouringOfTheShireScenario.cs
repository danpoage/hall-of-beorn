using System;

namespace HallOfBeorn.Models.LotR.Scenarios.TheScouringOfTheShire
{
    public class TheScouringOfTheShireScenario
        : Scenario
    {
        public TheScouringOfTheShireScenario()
        {
            Title = "The Scouring of the Shire";
            ProductName = "The Scouring of the Shire";
            GroupName = "The Scouring of the Shire";
            Number = 1;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP08.pdf";

            QuestCompanionSlug = "standalone-quests-quest-the-scouring-of-the-shire";
            DifficultyRating = 6f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheScouringOfTheShire);
            
            AddQuestCardId("Many-Partings-TSotS");
            AddQuestCardId("Escorted-Prisoners-TSotS");
            AddQuestCardId("Raise-the-Shire-TSotS");
            AddQuestCardId("The-Battle-of-Bywater-TSotS");
            AddQuestCardId("The-Very-Last-Stroke-TSotS");

            ExcludeFromEasyMode("Feather-capped-Shirriff-TSotS", 5);
            ExcludeFromEasyMode("Highway-Robber-TSotS", 2);
            ExcludeFromEasyMode("Gang-of-Ruffians-TSotS", 2);
            ExcludeFromEasyMode("East-Road-TSotS", 2);
            ExcludeFromEasyMode("Brick-Building-TSotS", 1);
            ExcludeFromEasyMode("Against-the-Rules-TSotS", 2);
            ExcludeFromEasyMode("Take-Him-Lads-TSotS", 1);
        }
    }
}
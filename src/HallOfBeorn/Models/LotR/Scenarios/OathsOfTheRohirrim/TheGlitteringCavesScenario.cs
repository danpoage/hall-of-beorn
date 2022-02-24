using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class TheGlitteringCavesScenario
        : Scenario
    {
        public TheGlitteringCavesScenario()
        {
            Title = "The Glittering Caves";
            ProductName = "The Glittering Caves";
            GroupName = "Oaths of the Rohirrim";
            Number = 4;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP05.pdf";

            //QuestCompanionSlug = "oaths-of-the-rohirrim-quest-the-glittering-caves";
            //DifficultyRating = 7f;
            //Votes = 1;

            AddEncounterSet(EncounterSet.TheGlitteringCaves);
            AddEncounterSet(EncounterSet.SearchForTheHorn);
            AddEncounterSet(EncounterSet.ExploringTheCaves);
            AddEncounterSet(EncounterSet.DunlendingWarriors);

            AddQuestCardId("Search-the-Caves-TGC");
            AddQuestCardId("The-Horn's-Discovery-TGC");

            //The Glittering Caves
            ExcludeFromEasyMode("Lurking-Ghul-TGC", 1);
            ExcludeFromEasyMode("Wonders-of-Aglarond-TGC", 1);
            ExcludeFromEasyMode("Guard-the-Entrance-TGC", 1);

            //Dunlending Warriors
            ExcludeFromEasyMode("Wild-Ravager-CoE", 2);
            ExcludeFromEasyMode("Hillman-Scout-CoE", 1);
            ExcludeFromEasyMode("Surprise-Attack-CoE", 1);
        }
    }
}
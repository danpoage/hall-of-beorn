using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.ChildrenOfEorl
{
    public class AmbushAtErelasScenario
        : Scenario
    {
        public AmbushAtErelasScenario()
        {
            Title = "Ambush at Erelas";
            ProductName = "Children of Eorl";
            GroupName = "Children of Eorl";
            Number = 1;

            RulesImageCount = 21;

            QuestCompanionSlug = "the-children-of-eorl-quest-ambush-at-erelas";
            DifficultyRating = 5.0f;
            Votes = 1;

            AddEncounterSet(EncounterSet.AmbushAtErelas);
            AddEncounterSet(EncounterSet.RohanEncampment);
            AddEncounterSet(EncounterSet.RohanWeather);

            AddQuestCardId("Drive-them-Away-CoE");
            AddQuestCardId("Ambush-CoE");

            //Ambush at Erelas
            ExcludeFromEasyMode("Pillaging-Swordsman-CoE", 2);
            ExcludeFromEasyMode("Sneaky-Thief-CoE", 2);
            ExcludeFromEasyMode("Crossroads-CoE", 2);
            ExcludeFromEasyMode("Chaos-in-the-Hills-CoE", 1);

            //Rohan Encampment
            ExcludeFromEasyMode("Old-Farmhouse-CoE", 2);
            ExcludeFromEasyMode("Abandoned-Mill-CoE", 1);

            //Rohan Weather
            ExcludeFromEasyMode("Cold-from-the-Mountains-CoE", 1);
            ExcludeFromEasyMode("Exhausting-Winds-CoE", 1);
        }
    }
}
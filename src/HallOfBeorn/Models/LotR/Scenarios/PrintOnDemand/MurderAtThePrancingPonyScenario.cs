using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class MurderAtThePrancingPonyScenario : Scenario
    {
        public MurderAtThePrancingPonyScenario()
            : base()
        {
            Title = "Murder at the Prancing Pony";
            ProductName = "2015";
            GroupName = "Gen Con & Fellowship";
            Number = 6;

            QuestCompanionSlug = "print-on-demand-quest-murder-at-the-prancing-pony";
            DifficultyRating = 7.6f;
            Votes = 14;

            AddTheLineUnbrokenLink("G7", "xuK6zLmZoTc");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2018/01/16/murder-at-the-prancing-pony/", Title);

            AddEncounterSet(EncounterSet.MurderAtThePrancingPony);
            AddEncounterSet(EncounterSet.Investigation);

            AddQuestCardId("Investigating-the-Crime-MatPP");
            AddQuestCardId("Running-out-of-Time-MatPP");
            AddQuestCardId("Apprehending-the-Killer-MatPP");

            ExcludeFromEasyMode("Taken-by-Surprise-MatPP", 1);
            ExcludeFromEasyMode("Dark-Alley-MatPP", 2);
            ExcludeFromEasyMode("Market-Square-MatPP", 1);
            ExcludeFromEasyMode("Greenway-Footpad-MatPP", 2);
            ExcludeFromEasyMode("Chetwood-Outlaw-MatPP", 1);
            ExcludeFromEasyMode("Smoke-and-Mirrors-MatPP", 2);
            ExcludeFromEasyMode("Deadly-Accusations-MatPP", 1);
        }
    }
}
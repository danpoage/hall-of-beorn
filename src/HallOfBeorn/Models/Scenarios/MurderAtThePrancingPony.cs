using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class MurderAtThePrancingPony : Scenario
    {
        public MurderAtThePrancingPony()
            : base()
        {
            Title = "Murder at the Prancing Pony";
            ProductName = "Murder at the Prancing Pony";
            GroupName = "GenCon";
            Number = 6;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/print-on-demand-quest-murder-at-the-prancing-pony.html";

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
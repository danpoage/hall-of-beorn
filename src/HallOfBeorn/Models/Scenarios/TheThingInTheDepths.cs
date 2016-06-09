using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheThingInTheDepths : DreamChaserScenario
    {
        public TheThingInTheDepths()
        {
            Title = "The Thing in the Depths";
            ProductName = "The Thing in the Depths";
            GroupName = "Dream-chaser";
            Number = 2;

            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            AddEncounterSet(EncounterSet.TheThingInTheDepths);
            AddEncounterSet(EncounterSet.TheStormcaller);

            AddQuestCardId("Take-the-Ship-TTiTD");
            AddQuestCardId("Change-of-Plans-TTiTD");
            AddQuestCardId("Defend-the-Ship-TTiTD");

            ExcludeCorsairRaidersFromEasyMode();
            
            ExcludeFromEasyMode("Forecastle-Deck-TTiTD", 1);
            ExcludeFromEasyMode("Quarter-Deck-TTiTD", 1);
            ExcludeFromEasyMode("Hold-Steady-TTiTD", 1);
            ExcludeFromEasyMode("Lashing-Tentacles-TTiTD", 2);
        }
    }
}
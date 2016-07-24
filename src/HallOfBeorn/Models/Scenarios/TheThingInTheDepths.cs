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

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-dream-chaser-quest-the-thing-in-the-depths.html";

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
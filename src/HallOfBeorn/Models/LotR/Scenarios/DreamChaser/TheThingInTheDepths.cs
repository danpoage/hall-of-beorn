using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class TheThingInTheDepths : DreamChaserScenario
    {
        public TheThingInTheDepths()
        {
            Title = "The Thing in the Depths";
            ProductName = "The Thing in the Depths";
            GroupName = "Dream-chaser";
            Number = 2;

            QuestCompanionSlug = "the-dream-chaser-quest-the-thing-in-the-depths";
            DifficultyRating = 5.4f;
            Votes = 16;

            AddMrUnderhillLink(Title + " Nightmare Mode - Two Player (Attempt 2)", "X7mLiDyH-j0");
            AddWanderingTookVideoLink("Twitch Recast: " + Title, "_VUd5G_8GGs");
            AddWanderingTookVideoLink("Twitch Recast: " + Title, "Td3QMjH8zZg");

            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            AddEncounterSet(EncounterSet.TheThingInTheDepths);
            AddEncounterSet(EncounterSet.TheStormcaller);
            AddEncounterSet(EncounterSet.TheThingInTheDepthsNightmare);
            AddEncounterSet(EncounterSet.CorsairRaidersNightmare);
            AddEncounterSet(EncounterSet.TheStormcallerNightmare);

            AddQuestCardId("Take-the-Ship-TTiTD");
            AddQuestCardId("Change-of-Plans-TTiTD");
            AddQuestCardId("Defend-the-Ship-TTiTD");

            ExcludeCorsairRaidersFromEasyMode();
            
            ExcludeFromEasyMode("Forecastle-Deck-TTiTD", 1);
            ExcludeFromEasyMode("Quarter-Deck-TTiTD", 1);
            ExcludeFromEasyMode("Hold-Steady-TTiTD", 1);
            ExcludeFromEasyMode("Lashing-Tentacles-TTiTD", 2);

            ExcludeFromNightmareMode("Corsair-Infiltrator-TGH", 2);
            ExcludeFromNightmareMode("Crew-Quarters-TTiTD", 1);
            ExcludeFromNightmareMode("Crushing-Arm-TTiTD", 1);
            ExcludeFromNightmareMode("Grasping-Arm-TTiTD", 1);
            ExcludeFromNightmareMode("Giant-Arm-TTiTD", 1);
        }
    }
}
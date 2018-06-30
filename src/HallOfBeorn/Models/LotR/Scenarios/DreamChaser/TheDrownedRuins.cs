using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class TheDrownedRuins : DreamChaserScenario
    {
        public TheDrownedRuins()
        {
            Title = "The Drowned Ruins";
            ProductName = "The Drowned Ruins";
            GroupName = "Dream-chaser";
            Number = 4;

            QuestCompanionSlug = "the-dream-chaser-quest-the-drowned-ruins";
            DifficultyRating = 4.9f;
            Votes = 9;

            AddEncounterSet(EncounterSet.TheDrownedRuins);
            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.TheStormcallerElite);

            AddQuestCardId("The-Grotto-TDRu");
            AddQuestCardId("Sahir's-Betrayal-TDRu");

            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromEasyMode("Cave-Eel-TDRu", 1);
            ExcludeFromEasyMode("Powerful-Undertow-TDRu", 2);
            ExcludeFromEasyMode("Ancient-Depths-TDRu", 2);
        }
    }
}
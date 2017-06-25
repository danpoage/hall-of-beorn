using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class TempleOfTheDeceived : DreamChaserScenario
    {
        public TempleOfTheDeceived()
        {
            Title = "Temple of the Deceived";
            ProductName = "Temple of the Deceived";
            GroupName = "Dream-chaser";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-dream-chaser-quest-temple-of-the-deceived.html";

            AddEncounterSet(EncounterSet.TempleOfTheDeceived);
            AddEncounterSet(EncounterSet.RuinsOfNumenor);
            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            
            AddQuestCardId("Searching-the-Island-TotD");
            
            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromEasyMode("Island-Watcher-TotD", 2);
            ExcludeFromEasyMode("Furious-Rainstorm-TotD", 1);
        }
    }
}
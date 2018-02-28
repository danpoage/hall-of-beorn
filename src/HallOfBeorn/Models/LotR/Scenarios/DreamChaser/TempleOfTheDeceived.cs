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

            QuestCompanionSlug = "the-dream-chaser-quest-temple-of-the-deceived";

            AddEncounterSet(EncounterSet.TempleOfTheDeceived);
            AddEncounterSet(EncounterSet.RuinsOfNumenor);
            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            AddEncounterSet(EncounterSet.TempleOfTheDeceivedNightmare);
            
            AddQuestCardId("Searching-the-Island-TotD");
            
            ExcludeDrownedDeadFromEasyMode();

            ExcludeFromEasyMode("Island-Watcher-TotD", 2);
            ExcludeFromEasyMode("Furious-Rainstorm-TotD", 1);

            ExcludeFromNightmareMode("Jungle-Path-Lost-Island-TotD", 1);
            ExcludeFromNightmareMode("Cursed-Temple-Lost-Island-TGH", 2);
            ExcludeFromNightmareMode("Deeper-into-the-Ruins-TotD", 1);
            ExcludeFromNightmareMode("Sunken-Ruins-TotD", 3);
            ExcludeFromNightmareMode("Aimless-Wandering-TGH", 2);
            ExcludeFromNightmareMode("Curse-of-the-Downfallen-TGH", 2);
            ExcludeFromNightmareMode("Dwindling-Supplies-TotD", 1);
            ExcludeFromNightmareMode("Faithless-Desecrator-TotD", 1);
        }
    }
}
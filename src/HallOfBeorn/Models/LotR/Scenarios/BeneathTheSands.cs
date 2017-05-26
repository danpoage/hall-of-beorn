using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class BeneathTheSands : TheSandsOfHarad
    {
        public BeneathTheSands()
        {
            Title = "Beneath the Sands";
            ProductName = "Beneath the Sands";
            GroupName = "Haradrim";
            Number = 3;

            //QuestCompanionUrl = "";

            AddEncounterSet(EncounterSet.BeneathTheSands);
            AddEncounterSet(EncounterSet.DesertCreatures);
            AddEncounterSet(EncounterSet.HaradTerritory);

            AddQuestCardId("Searching-the-Caves-BtS");
            AddQuestCardId("Getting-Closer-BtS");
            AddQuestCardId("The-Spiders'-Hive-BtS");

            excludeDesertCreatures();
            excludeHaradTerritory();

            /*
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            */
        }
    }
}
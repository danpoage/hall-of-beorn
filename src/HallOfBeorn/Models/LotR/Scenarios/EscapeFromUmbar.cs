using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class EscapeFromUmbar : TheSandsOfHarad
    {
        public EscapeFromUmbar()
        {
            Title = "Escape from Umbar";
            ProductName = "The Sands of Harad";
            GroupName = "The Sands of Harad";
            Number = 1;

            //QuestCompanionUrl = "";

            AddEncounterSet(EncounterSet.EscapeFromUmbar);
            AddEncounterSet(EncounterSet.HaradTerritory);
            AddEncounterSet(EncounterSet.HaradSoldiers);
            
            AddQuestCardId("Stranded-in-Umbar-TSoH");
            AddQuestCardId("Flee-the-City-TSoH");

            excludeEscapeFromUmbar();
            excludeHaradTerritory();
            excludeHaradSoldiers();
        }
    }
}
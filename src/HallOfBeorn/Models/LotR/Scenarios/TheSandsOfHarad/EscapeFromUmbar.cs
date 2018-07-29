using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad
{
    public class EscapeFromUmbar : TheSandsOfHaradScenario
    {
        public EscapeFromUmbar()
        {
            Title = "Escape from Umbar";
            ProductName = "The Sands of Harad";
            GroupName = "The Sands of Harad";
            Number = 1;

            QuestCompanionSlug = "sands-of-harad-quest-escape-from-umbar";
            DifficultyRating = 5.3f;
            Votes = 8;

            AddMrUnderhillLink(Title + " - Three Players", "4vWJXzn1xiE");
            AddLotRDeckTechLink(Title, "w627WAUQdVw");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/11/14/path-less-traveled-escape-from-umbar/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/12/12/turn-by-turn-report-escape-from-umbar/", Title);

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
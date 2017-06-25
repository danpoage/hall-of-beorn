using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class AStormOnCobasHaven : DreamChaserScenario
    {
        public AStormOnCobasHaven()
        {
            Title = "A Storm on Cobas Haven";
            ProductName = "A Storm on Cobas Haven";
            GroupName = "Dream-chaser";
            Number = 5;

            AddEncounterSet(EncounterSet.AStormOnCobasHaven);
            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.CorsairPirates);
            AddEncounterSet(EncounterSet.UmbarFleet);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaer);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);

            AddQuestCardId("Outmaneuver-the-Enemy-ASoCH");
            AddQuestCardId("Battle-in-the-Bay-ASoCH");
            AddQuestCardId("Break-Through-the-Fleet-ASoCH");

            ExcludeCorsairRaidersFromEasyMode();
            ExcludeCorsairPiratesFromEasyMode();
            ExcludeUmbarFleetFromEasyMode();

            ExcludeFromEasyMode("Siege-Ship-ASoCH", 1);
            ExcludeFromEasyMode("Heavy-Cruiser-ASoCH", 1);
            ExcludeFromEasyMode("Coast-of-Anfalas-ASoCH", 2);
            ExcludeFromEasyMode("Taking-on-Water-ASoCH", 1);
        }
    }
}
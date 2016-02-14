using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class RaidOnTheGreyHavens : DreamChaserScenario
    {
        public RaidOnTheGreyHavens()
        {
            Title = "Raid on the Grey Havens";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 3;

            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.TheStormcallerElite);
            AddEncounterSet(EncounterSet.RaidOnTheGreyHavens);

            AddQuestCardId("The-Corsairs'-Assault-TGH");
            AddQuestCardId("Sahir's-Advance-TGH");
        }
    }
}
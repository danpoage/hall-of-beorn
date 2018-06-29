using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RaceAcrossHaradProduct : Product
    {
        public RaceAcrossHaradProduct()
            : base("Race Across Harad", "MEC57", ImageType.Jpg, new DateTime(2017, 3, 15))
        {
            AddCardSet(CardSet.RaceAcrossHarad);

            AddScenario(new Scenarios.Haradrim.RaceAcrossHaradScenario());
        }
    }
}
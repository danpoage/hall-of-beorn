using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class BeneathTheSandsProduct : Product
    {
        public BeneathTheSandsProduct()
            : base("Beneath the Sands", "MEC58", ImageType.Png, new DateTime(2017, 5, 1))
        {
            AddCardSet(CardSet.BeneathTheSands);

            AddScenario(new Scenarios.Haradrim.BeneathTheSands());
        }
    }
}
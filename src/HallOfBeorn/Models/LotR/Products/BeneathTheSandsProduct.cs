using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class BeneathTheSandsProduct : Product
    {
        public BeneathTheSandsProduct()
            : base("Beneath the Sands", "MEC58", ImageType.Png)
        {
            AddCardSet(CardSet.BeneathTheSands);

            AddScenario(new Scenarios.Haradrim.BeneathTheSands());
        }
    }
}
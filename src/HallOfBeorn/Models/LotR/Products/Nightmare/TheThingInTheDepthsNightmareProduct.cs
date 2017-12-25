using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheThingInTheDepthsNightmareProduct : Product
    {
        public TheThingInTheDepthsNightmareProduct()
            : base("The Thing in the Depths Nightmare", "MEN46", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheThingInTheDepthsNightmare);
        }
    }
}
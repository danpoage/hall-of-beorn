using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoamAcrossRhovanionProduct : Product
    {
        public RoamAcrossRhovanionProduct()
            : base("Roam Across Rhovanion", "MEC67", ImageType.Jpg)
        {
            AddCardSet(CardSet.RoamAcrossRhovanion);
        }
    }
}
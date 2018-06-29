using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoamAcrossRhovanionProduct : Product
    {
        public RoamAcrossRhovanionProduct()
            : base("Roam Across Rhovanion", "MEC67", ImageType.Jpg, new DateTime(2018, 7, 15))
        {
            AddCardSet(CardSet.RoamAcrossRhovanion);
        }
    }
}
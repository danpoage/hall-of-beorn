using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheFortressOfNurnProduct
        : Product
    {
        public TheFortressOfNurnProduct()
            : base("The Fortress of Nurn", "MEC83", ImageType.Jpg, new DateTime(2020, 8, 31))
        {
            AddCardSet(CardSet.TheFortressOfNurn);
        }
    }
}
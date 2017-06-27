using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCrossingsOfPorosProduct : Product
    {
        public TheCrossingsOfPorosProduct()
            : base("The Crossings of Poros", "MEC61", ImageType.Png)
        {
            AddCardSet(CardSet.TheCrossingsOfPoros);
        }
    }
}
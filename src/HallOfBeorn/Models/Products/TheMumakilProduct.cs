using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheMumakilProduct : Product
    {
        public TheMumakilProduct()
            : base("The Mûmakil", "MEC56", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheMumakil);
        }
    }
}
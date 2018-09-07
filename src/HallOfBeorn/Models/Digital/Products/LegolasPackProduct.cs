using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class LegolasPackProduct : DigitalProduct
    {
        public LegolasPackProduct()
            : base("Legolas Pack", "LP")
        {
            addCardSet(DigitalCardSet.LegolasPack);
        }
    }
}

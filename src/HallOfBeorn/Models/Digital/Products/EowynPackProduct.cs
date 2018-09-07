using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class EowynPackProduct : DigitalProduct
    {
        public EowynPackProduct()
            : base("Éowyn Pack", "EW")
        {
            addCardSet(DigitalCardSet.EowynPack);
        }
    }
}
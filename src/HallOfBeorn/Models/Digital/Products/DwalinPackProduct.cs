using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class DwalinPackProduct : DigitalProduct
    {
        public DwalinPackProduct()
            : base("Dwalin Pack", "DW")
        {
            addCardSet(DigitalCardSet.DwalinPack);
        }
    }
}
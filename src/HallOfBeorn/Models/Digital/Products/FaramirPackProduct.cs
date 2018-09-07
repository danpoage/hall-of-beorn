using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class FaramirPackProduct : DigitalProduct
    {
        public FaramirPackProduct()
            : base("Faramir Pack", "FR")
        {
            addCardSet(DigitalCardSet.FaramirPack);
        }
    }
}
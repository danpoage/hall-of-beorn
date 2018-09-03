using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class StarterProduct : DigitalProduct
    {
        public StarterProduct()
            : base("Starter", "ST")
        {
            addCardSet(DigitalCardSet.Starter);
        }
    }
}
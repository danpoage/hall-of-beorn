using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AngmarAwakenedProductGroup : ProductGroup
    {
        public AngmarAwakenedProductGroup()
            : base("Angmar Awakened Cycle")
        {
            MainProduct = new TheLostRealmProduct();
        }
    }
}
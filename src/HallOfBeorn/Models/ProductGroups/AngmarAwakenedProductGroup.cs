using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class AngmarAwakenedProductGroup : ProductGroup
    {
        public AngmarAwakenedProductGroup()
            : base("Angmar Awakened Cycle")
        {
            MainProduct = Product.TheLostRealm;

            AddProduct(Product.TheWastesOfEriador);
            AddProduct(Product.EscapeFromMountGram);
            AddProduct(Product.AcrossTheEttenmoors);
        }
    }
}
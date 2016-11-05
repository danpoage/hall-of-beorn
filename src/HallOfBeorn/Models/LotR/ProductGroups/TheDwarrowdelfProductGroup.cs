using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheDwarrowdelfProductGroup : ProductGroup
    {
        public TheDwarrowdelfProductGroup()
            : base("The Dwarrowdelf Cycle")
        {
            MainProduct = Product.KhazadDum;
            AddProduct(Product.TheRedhornGate);
            AddProduct(Product.RoadToRivendell);
            AddProduct(Product.TheWatcherInTheWater);
            AddProduct(Product.TheLongDark);
            AddProduct(Product.FoundationsOfStone);
            AddProduct(Product.ShadowAndFlame);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDwarrowdelfProductGroup : ProductGroup
    {
        public TheDwarrowdelfProductGroup()
            : base("The Dwarrowdelf Cycle")
        {
            MainProduct = new KhazadDumProduct();
            AddProduct(new TheRedhornGateProduct());
            AddProduct(new RoadToRivendellProduct());
            AddProduct(new TheWatcherInTheWaterProduct());
            AddProduct(new TheLongDarkProduct());
            AddProduct(new FoundationsOfStoneProduct());
            AddProduct(new ShadowAndFlameProduct());
        }
    }
}
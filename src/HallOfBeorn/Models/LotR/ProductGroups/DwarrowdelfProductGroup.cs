using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DwarrowdelfProductGroup : ProductGroup
    {
        public DwarrowdelfProductGroup()
            : base("Dwarrowdelf Cycle")
        {
            AddMainProduct(Product.KhazadDum);
            AddChildProduct(Product.TheRedhornGate);
            AddChildProduct(Product.RoadToRivendell);
            AddChildProduct(Product.TheWatcherInTheWater);
            AddChildProduct(Product.TheLongDark);
            AddChildProduct(Product.FoundationsOfStone);
            AddChildProduct(Product.ShadowAndFlame);
        }
    }
}
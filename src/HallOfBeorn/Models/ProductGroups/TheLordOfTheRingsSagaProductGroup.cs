using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class TheLordOfTheRingsSagaProductGroup : ProductGroup
    {
        public TheLordOfTheRingsSagaProductGroup()
            : base("The Lord of the Rings Saga")
        {
            AddProduct(Product.TheBlackRiders);
            AddProduct(Product.TheRoadDarkens);
            AddProduct(Product.TheTreasonOfSaruman);
            AddProduct(Product.TheLandOfShadow);
            AddProduct(Product.TheFlameOfTheWest);
        }
    }
}
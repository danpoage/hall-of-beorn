using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheLordOfTheRingsSagaProductGroup : ProductGroup
    {
        public TheLordOfTheRingsSagaProductGroup()
            : base("The Lord of the Rings Saga")
        {
            AddChildProduct(Product.TheBlackRiders);
            AddChildProduct(Product.TheRoadDarkens);
            AddChildProduct(Product.TheTreasonOfSaruman);
            AddChildProduct(Product.TheLandOfShadow);
            AddChildProduct(Product.TheFlameOfTheWest);
            AddChildProduct(Product.TheMountainOfFire);
        }
    }
}
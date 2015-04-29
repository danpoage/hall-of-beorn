using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheLordOfTheRingsSagaProductGroup : ProductGroup
    {
        public TheLordOfTheRingsSagaProductGroup()
            : base("The Lord of the Rings Saga")
        {
            AddProduct(new TheBlackRidersProduct());
            AddProduct(new TheRoadDarkensProduct());
            AddProduct(new TheTreasonOfSarumanProduct());
        }
    }
}
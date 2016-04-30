using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class DreamChaserProductGroup : ProductGroup
    {
        public DreamChaserProductGroup()
            : base("Dream-chaser Cycle")
        {
            MainProduct = Product.TheGreyHavens;
            AddProduct(Product.FlightOfTheStormcaller);
        }
    }
}
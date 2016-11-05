using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DreamChaserProductGroup : ProductGroup
    {
        public DreamChaserProductGroup()
            : base("Dream-chaser Cycle")
        {
            MainProduct = Product.TheGreyHavens;
            AddProduct(Product.FlightOfTheStormcaller);
            AddProduct(Product.TheThingInTheDepths);
            AddProduct(Product.TempleOfTheDeceived);
            AddProduct(Product.TheDrownedRuins);
            AddProduct(Product.AStormOnCobasHaven);
            AddProduct(Product.TheCityOfCorsairs);
        }
    }
}
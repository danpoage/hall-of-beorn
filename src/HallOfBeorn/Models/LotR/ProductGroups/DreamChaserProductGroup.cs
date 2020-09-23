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
            AddMainProduct(Product.TheGreyHavens);
            AddChildProduct(Product.FlightOfTheStormcaller);
            AddChildProduct(Product.TheThingInTheDepths);
            AddChildProduct(Product.TempleOfTheDeceived);
            AddChildProduct(Product.TheDrownedRuins);
            AddChildProduct(Product.AStormOnCobasHaven);
            AddChildProduct(Product.TheCityOfCorsairs);
        }
    }
}
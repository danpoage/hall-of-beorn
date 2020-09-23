using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class EredMithrinProductGroup : ProductGroup
    {
        public EredMithrinProductGroup()
            : base("Ered Mithrin Cycle")
        {
            AddMainProduct(Product.TheWildsOfRhovanion);
            AddChildProduct(Product.TheWitheredHeath);
            AddChildProduct(Product.RoamAcrossRhovanion);
            AddChildProduct(Product.FireInTheNight);
            AddChildProduct(Product.TheGhostOfFramsburg);
            AddChildProduct(Product.MountGundabad);
            AddChildProduct(Product.TheFateOfWilderland);
        }
    }
}
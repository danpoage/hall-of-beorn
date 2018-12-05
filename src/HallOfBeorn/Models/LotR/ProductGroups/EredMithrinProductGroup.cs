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
            MainProduct = Product.TheWildsOfRhovanion;
            AddProduct(Product.TheWitheredHeath);
            AddProduct(Product.RoamAcrossRhovanion);
            AddProduct(Product.FireInTheNight);
            AddProduct(Product.TheGhostOfFramsburg);
            AddProduct(Product.MountGundabad);
        }
    }
}
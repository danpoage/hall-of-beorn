using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class AgainstTheShadowProductGroup : ProductGroup
    {
        public AgainstTheShadowProductGroup()
            : base("Against the Shadow Cycle")
        {
            MainProduct = Product.HeirsOfNumenor;
            AddProduct(Product.TheStewardsFear);
            AddProduct(Product.TheDruadanForest);
            AddProduct(Product.EncounterAtAmonDin);
            AddProduct(Product.AssaultOnOsgiliath);
            AddProduct(Product.TheBloodOfGondor);
            AddProduct(Product.TheMorgulVale);
        }
    }
}
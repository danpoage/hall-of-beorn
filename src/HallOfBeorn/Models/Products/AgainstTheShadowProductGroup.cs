using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AgainstTheShadowProductGroup : ProductGroup
    {
        public AgainstTheShadowProductGroup()
            : base("Against the Shadow Cycle")
        {
            MainProduct = new HeirsOfNumenorProduct();
            AddProduct(new TheStewardsFearProduct());
            AddProduct(new TheDruadanForestProduct());
            AddProduct(new EncounterAtAmonDinProduct());
            AddProduct(new AssaultOnOsgiliathProduct());
            AddProduct(new TheBloodOfGondorProduct());
            AddProduct(new TheMorgulValeProduct());
        }
    }
}
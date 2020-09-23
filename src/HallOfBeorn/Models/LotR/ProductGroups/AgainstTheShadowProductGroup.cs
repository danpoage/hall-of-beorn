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
            AddMainProduct(Product.HeirsOfNumenor);
            AddChildProduct(Product.TheStewardsFear);
            AddChildProduct(Product.TheDruadanForest);
            AddChildProduct(Product.EncounterAtAmonDin);
            AddChildProduct(Product.AssaultOnOsgiliath);
            AddChildProduct(Product.TheBloodOfGondor);
            AddChildProduct(Product.TheMorgulVale);
        }
    }
}
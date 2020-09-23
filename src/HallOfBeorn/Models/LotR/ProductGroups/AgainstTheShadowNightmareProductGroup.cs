using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class AgainstTheShadowNightmareProductGroup
        : ProductGroup
    {
        public AgainstTheShadowNightmareProductGroup()
            : base("Against the Shadow Nightmare Decks")
        {
            AddMainProduct(Product.HeirsOfNumenorNightmare);
            AddChildProduct(Product.TheStewardsFearNightmare);
            AddChildProduct(Product.TheDruadanForestNightmare);
            AddChildProduct(Product.EncounterAtAmonDinNightmare);
            AddChildProduct(Product.AssaultOnOsgiliathNightmare);
            AddChildProduct(Product.TheBloodOfGondorNightmare);
            AddChildProduct(Product.TheMorgulValeNightmare);
        }
    }
}

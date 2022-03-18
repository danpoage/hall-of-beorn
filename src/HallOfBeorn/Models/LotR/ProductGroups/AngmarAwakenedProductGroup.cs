using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class AngmarAwakenedProductGroup : ProductGroup
    {
        public AngmarAwakenedProductGroup()
            : base("Angmar Awakened Cycle")
        {
            AddMainProduct(Product.TheLostRealm);
            AddMainProduct(Product.AngmarAwakenedHeroExpansion);
            AddChildProduct(Product.TheWastesOfEriador);
            AddChildProduct(Product.EscapeFromMountGram);
            AddChildProduct(Product.AcrossTheEttenmoors);
            AddChildProduct(Product.TheTreacheryOfRhudaur);
            AddChildProduct(Product.TheBattleOfCarnDum);
            AddChildProduct(Product.TheDreadRealm);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheRingMakerProductGroup : ProductGroup
    {
        public TheRingMakerProductGroup()
            : base("The Ring-maker Cycle")
        {
            MainProduct = Product.TheVoiceOfIsengard;
            AddProduct(Product.TheDunlandTrap);
            AddProduct(Product.TheThreeTrials);
            AddProduct(Product.TroubleInTharbad);
            AddProduct(Product.TheNinInEilph);
            AddProduct(Product.CelebrimborsSecret);
            AddProduct(Product.TheAntleredCrown);
        }
    }
}
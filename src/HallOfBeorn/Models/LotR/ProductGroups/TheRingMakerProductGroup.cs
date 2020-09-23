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
            AddMainProduct(Product.TheVoiceOfIsengard);
            AddChildProduct(Product.TheDunlandTrap);
            AddChildProduct(Product.TheThreeTrials);
            AddChildProduct(Product.TroubleInTharbad);
            AddChildProduct(Product.TheNinInEilph);
            AddChildProduct(Product.CelebrimborsSecret);
            AddChildProduct(Product.TheAntleredCrown);
        }
    }
}
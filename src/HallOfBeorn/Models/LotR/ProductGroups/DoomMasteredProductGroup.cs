using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DoomMasteredProductGroup : ProductGroup
    {
        public DoomMasteredProductGroup()
            : base("Doom Mastered Cycle")
        {
            MainProduct = Product.FirstAge;

            AddProduct(Product.TrialUponTheMarches);
            AddProduct(Product.AmongTheOutlaws);
        }
    }
}
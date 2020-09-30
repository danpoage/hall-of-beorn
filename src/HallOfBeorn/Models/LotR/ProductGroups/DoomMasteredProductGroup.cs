using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DoomMasteredProductGroup : ProductGroup
    {
        public DoomMasteredProductGroup()
            : base("Doom Mastered Cycle")
        {
            AddMainProduct(Product.FirstAge);
            AddChildProduct(Product.TrialUponTheMarches);
            AddChildProduct(Product.AmongTheOutlaws);
            AddChildProduct(Product.TheBetrayalOfMim);
        }
    }
}
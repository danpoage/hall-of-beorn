using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheLegacyOfFeanorProductGroup
        : ProductGroup
    {
        public TheLegacyOfFeanorProductGroup()
            : base("The Legacy of Fëanor")
        {
            AddMainProduct(Product.TheLegacyOfFeanor);

            AddChildProduct(Product.BetrayingTheFalathrim);
        }
    }
}
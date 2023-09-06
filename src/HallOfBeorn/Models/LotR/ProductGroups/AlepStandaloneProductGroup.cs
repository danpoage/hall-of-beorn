using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class AlepStandaloneProductGroup
        : ProductGroup
    {
        public AlepStandaloneProductGroup()
            : base("Stand Alone Scenarios")
        {
            AddMainProduct(Product.TheScouringOfTheShire);
            AddMainProduct(Product.TheNineAreAbroad);
            AddMainProduct(Product.TheSiegeOfErebor);
        }
    }
}
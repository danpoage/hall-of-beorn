using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class StarterDeckProductGroup
        : ProductGroup
    {
        public StarterDeckProductGroup()
            : base("Starter Deck")
        {
            AddChildProduct(Product.DwarvesOfDurin);
            AddChildProduct(Product.ElvesOfLorien);
            AddChildProduct(Product.DefendersOfGondor);
            AddChildProduct(Product.RidersOfRohan);
        }
    }
}
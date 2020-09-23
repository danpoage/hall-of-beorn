using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class GenConDeckProductGroup : ProductGroup
    {
        public GenConDeckProductGroup()
            : base("Gen Con Decks")
        {
            AddChildProduct(Product.TheMassingAtOsgiliath);
            AddChildProduct(Product.TheBattleOfLakeTown);
            AddChildProduct(Product.TheStoneOfErech);
            AddChildProduct(Product.TheOldForest);
            AddChildProduct(Product.TheRuinsOfBelegost);
        }
    }
}

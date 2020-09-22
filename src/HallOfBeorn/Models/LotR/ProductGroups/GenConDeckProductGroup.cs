using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class GenConDeckProductGroup : ProductGroup
    {
        public GenConDeckProductGroup()
            : base("Gen Con Decks")
        {
            AddProduct(Product.TheMassingAtOsgiliath);
            AddProduct(Product.TheBattleOfLakeTown);
            AddProduct(Product.TheStoneOfErech);
            AddProduct(Product.TheOldForest);
            AddProduct(Product.TheRuinsOfBelegost);
        }
    }
}

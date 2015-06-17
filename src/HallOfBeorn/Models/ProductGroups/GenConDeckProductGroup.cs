using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class GenConDeckProductGroup : ProductGroup
    {
        public GenConDeckProductGroup()
            : base("Gen Con & Fellowship Decks")
        {
            AddProduct(Product.TheMassingAtOsgiliath);
            AddProduct(Product.TheBattleOfLakeTown);
            AddProduct(Product.TheStoneOfErech);
            AddProduct(Product.TheOldForest);
            AddProduct(Product.FogOnTheBarrowDowns);
        }
    }
}
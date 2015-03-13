using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class GenConDeckProductGroup : ProductGroup
    {
        public GenConDeckProductGroup()
            : base("Gen Con & Fellowship Decks")
        {
            AddProduct(new TheMassingAtOsgiliathProduct());
            AddProduct(new TheBattleOfLakeTownProduct());
            AddProduct(new TheStoneOfErechProduct());
            AddProduct(new TheOldForestProduct());
            AddProduct(new FogOnTheBarrowDownsProduct());
        }
    }
}
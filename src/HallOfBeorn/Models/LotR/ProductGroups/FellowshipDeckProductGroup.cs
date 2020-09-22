using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class FellowshipDeckProductGroup
        : ProductGroup
    {
        public FellowshipDeckProductGroup()
            : base("Fellowship Decks")
        {
            AddProduct(Product.FogOnTheBarrowDowns);
            AddProduct(Product.MurderAtThePrancingPony);
            AddProduct(Product.TheSiegeOfAnnuminas);
            AddProduct(Product.AssaultOnDolGuldur);
        }
    }
}
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
            AddChildProduct(Product.FogOnTheBarrowDowns);
            AddChildProduct(Product.MurderAtThePrancingPony);
            AddChildProduct(Product.TheSiegeOfAnnuminas);
            AddChildProduct(Product.AssaultOnDolGuldur);
        }
    }
}
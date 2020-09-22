using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ShadowsOfMirkwoodProductGroup : ProductGroup
    {
        public ShadowsOfMirkwoodProductGroup()
            : base("Shadows of Mirkwood Cycle")
        {
            MainProduct = Product.CoreSet;
            SecondProduct = Product.TwoPlayerLimitedEditionStarter;
            AddProduct(Product.TheHuntForGollum);
            AddProduct(Product.ConflictAtTheCarrock);
            AddProduct(Product.AJourneyToRhosgobel);
            AddProduct(Product.TheHillsOfEmynMuil);
            AddProduct(Product.TheDeadMarshes);
            AddProduct(Product.ReturnToMirkwood);
        }
    }
}
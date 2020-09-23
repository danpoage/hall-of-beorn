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
            AddMainProduct(Product.CoreSet);
            AddMainProduct(Product.TwoPlayerLimitedEditionStarter);
            AddChildProduct(Product.TheHuntForGollum);
            AddChildProduct(Product.ConflictAtTheCarrock);
            AddChildProduct(Product.AJourneyToRhosgobel);
            AddChildProduct(Product.TheHillsOfEmynMuil);
            AddChildProduct(Product.TheDeadMarshes);
            AddChildProduct(Product.ReturnToMirkwood);
        }
    }
}
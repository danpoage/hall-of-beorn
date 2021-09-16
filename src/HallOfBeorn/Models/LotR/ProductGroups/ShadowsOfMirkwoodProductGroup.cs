using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ShadowsOfMirkwoodProductGroup : ProductGroup
    {
        public ShadowsOfMirkwoodProductGroup()
            : base("Shadows of Mirkwood Cycle")
        {
            AddMainProduct(Product.CoreSet);
            AddMainProduct(Product.TwoPlayerLimitedEditionStarter);
            AddMainProduct(Product.RevisedCoreSet);
            AddChildProduct(Product.TheHuntForGollum);
            AddChildProduct(Product.ConflictAtTheCarrock);
            AddChildProduct(Product.AJourneyToRhosgobel);
            AddChildProduct(Product.TheHillsOfEmynMuil);
            AddChildProduct(Product.TheDeadMarshes);
            AddChildProduct(Product.ReturnToMirkwood);
        }
    }
}
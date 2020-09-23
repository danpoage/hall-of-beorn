using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ShadowsOfMirkwoodNightmareProductGroup
        : ProductGroup
    {
        public ShadowsOfMirkwoodNightmareProductGroup()
            : base("Shadows of Mirkwood Nightmare Decks")
        {
            AddMainProduct(Product.PassageThroughMirkwoodNightmare);
            AddMainProduct(Product.JourneyAlongTheAnduinNightmare);
            AddMainProduct(Product.EscapeFromDolGuldurNightmare);
            AddChildProduct(Product.TheHuntForGollumNightmare);
            AddChildProduct(Product.ConflictAtTheCarrockNightmare);
            AddChildProduct(Product.AJourneyToRhosgobelNightmare);
            AddChildProduct(Product.TheHillsOfEmynMuilNightmare);
            AddChildProduct(Product.TheDeadMarshesNightmare);
            AddChildProduct(Product.ReturnToMirkwoodNightmare);
        }
    }
}
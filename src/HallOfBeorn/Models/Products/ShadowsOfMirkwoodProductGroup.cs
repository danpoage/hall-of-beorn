using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class ShadowsOfMirkwoodProductGroup : ProductGroup
    {
        public ShadowsOfMirkwoodProductGroup()
            : base("Shadows of Mirkwood Cycle")
        {
            MainProduct = new CoreSetProduct();
            AddProduct(new TheHuntForGollumProduct());
            AddProduct(new ConflictAtTheCarrokProduct());
            AddProduct(new AJourneyToRhosgobelProduct());
            AddProduct(new TheHillsOfEmynMuilProduct());
            AddProduct(new TheDeadMarshesProduct());
            AddProduct(new ReturnToMirkwoodProduct());
        }
    }
}
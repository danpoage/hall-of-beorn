using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ScenarioPackProductGroup
        : ProductGroup
    {
        public ScenarioPackProductGroup()
            : base("Scenario Packs")
        {
            AddChildProduct(Product.TheHuntForTheDreadnaught);
            AddChildProduct(Product.TheDarkOfMirkwood);
        }
    }
}
using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ScenarioPackProductGroup
        : ProductGroup
    {
        public ScenarioPackProductGroup()
            : base("Scenario Packs")
        {
            AddProduct(Product.TheHuntForTheDreadnaught);
        }
    }
}
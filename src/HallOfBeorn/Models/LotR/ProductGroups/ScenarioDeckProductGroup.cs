using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class ScenarioDeckProductGroup
        : ProductGroup
    {
        public ScenarioDeckProductGroup()
            : base("Scenario Decks")
        {
            AddProduct(Product.TheHuntForTheDreadnaught);
        }
    }
}
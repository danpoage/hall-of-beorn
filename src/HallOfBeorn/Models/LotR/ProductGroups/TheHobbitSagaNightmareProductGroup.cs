using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheHobbitSagaNightmareProductGroup
        : ProductGroup
    {
        public TheHobbitSagaNightmareProductGroup()
            : base("The Hobbit Saga Nightmare Decks")
        {
            AddChildProduct(Product.TheHobbitOverHillAndUnderHillNightmare);
            AddChildProduct(Product.TheHobbitOnTheDoorstepNightmare);
        }
    }
}
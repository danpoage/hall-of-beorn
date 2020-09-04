using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Cycle
        : INamed
    {
        public Cycle(ProductGroup productGroup, string name, List<Product> adventurePacks)
        {
            ProductGroup = productGroup;
            Name = new Content(name);
            this.adventurePacks = adventurePacks;
        }

        private readonly List<Product> adventurePacks = new List<Product>();

        public ProductGroup ProductGroup { get; }
        public Content Name { get; }
        public IReadOnlyList<Product> AdventurePacks => adventurePacks;
    }
}

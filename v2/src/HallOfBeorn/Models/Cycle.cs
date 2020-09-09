using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models
{
    public class Cycle
        : INamed
    {
        public Cycle(ProductGroup productGroup, string name, List<Product> adventurePacks)
        {
            ProductGroup = productGroup;
            Name = new Content(name);
            Parent = productGroup.Products.First();
            this.adventurePacks = adventurePacks;
        }

        private readonly List<Product> adventurePacks = new List<Product>();

        public ProductGroup ProductGroup { get; }
        public Content Name { get; }
        public Product Parent { get; }
        public IReadOnlyList<Product> AdventurePacks => adventurePacks;
    }
}

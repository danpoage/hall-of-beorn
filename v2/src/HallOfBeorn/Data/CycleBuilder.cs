using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CycleBuilder
    {
        public CycleBuilder(ProductGroup productGroup, string name)
        {
            cycle = new Cycle(productGroup, name, adventurePacks);
        }

        private readonly Cycle cycle;
        private readonly List<Product> adventurePacks = new List<Product>();
        private readonly List<ProductBuilder> productBuilders = new List<ProductBuilder>();
        
        public void AdventurePack(ProductBuilder builder)
        {
            productBuilders.Add(builder);
        }

        public Cycle ToCycle()
        {
            adventurePacks.AddRange(
                productBuilders.Select(builder => builder.ToProduct()));

            return cycle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class ProductGroupBuilder
    {
        public ProductGroupBuilder(string name)
        {
            productGroup = new ProductGroup(name, products, cycles);
        }

        private readonly ProductGroup productGroup;
        private readonly List<Product> products = new List<Product>();
        private readonly List<Cycle> cycles = new List<Cycle>();
        
        private readonly List<ProductBuilder> productBuilders = new List<ProductBuilder>();
        private readonly List<CycleBuilder> cycleBuilders = new List<CycleBuilder>();

        public void Product(ProductBuilder builder)
        {
            productBuilders.Add(builder);
        }

        public CycleBuilder Cycle(string name)
        {
            var builder = new CycleBuilder(productGroup, name);
            cycleBuilders.Add(builder);
            return builder;
        }

        public ProductGroup ToProductGroup()
        {
            products.AddRange(
                productBuilders.Select(builder => builder.ToProduct()));

            cycles.AddRange(
                cycleBuilders.Select(builder => builder.ToCycle()));

            return productGroup;
        }
    }
}

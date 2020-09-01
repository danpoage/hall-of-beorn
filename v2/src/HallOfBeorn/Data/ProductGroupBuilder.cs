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
            productGroup = new ProductGroup(name, products);
        }

        private readonly ProductGroup productGroup;
        private readonly List<Product> products = new List<Product>();

        private readonly List<ProductBuilder> productBuilders = new List<ProductBuilder>();

        public ProductBuilder Product(string name, string code, DateTime releaseDate)
        {
            var builder = new ProductBuilder(name, code, releaseDate);
            productBuilders.Add(builder);
            return builder;
        }

        public ProductGroup ToProductGroup()
        {
            products.AddRange(
                productBuilders.Select(builder => builder.ToProduct()));

            return productGroup;
        }
    }
}

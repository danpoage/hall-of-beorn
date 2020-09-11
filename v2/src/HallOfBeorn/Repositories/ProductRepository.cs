using System;
using System.Collections.Generic;

using HallOfBeorn.Data;
using HallOfBeorn.Data.ProductGroups;
using HallOfBeorn.Models;

namespace HallOfBeorn.Repositories
{
    public class ProductRepository
    {
        public ProductRepository()
        {
            AddProductGroup(CoreProductGroup.Builder());
        }

        private readonly Dictionary<string, ProductGroup> groups = new Dictionary<string, ProductGroup>();
        private readonly Dictionary<string, Product> all = new Dictionary<string, Product>();

        private void AddProduct(Product product)
        {
            all[product.Name.NormalizedText] = product;
        }

        private void AddProductGroup(ProductGroupBuilder builder)
        {
            var group = builder.ToProductGroup();
            groups[group.Name.NormalizedText] = group;

            foreach (var product in group.Products)
            {
                AddProduct(product);
            }

            foreach (var cycle in group.Cycles)
            {
                foreach (var product in cycle.AdventurePacks)
                {
                    AddProduct(product);
                }
            }
        }

        public IReadOnlyList<Product> All()
        {
            return all.Values.ToListSafe();
        }

        public Product GetProduct(string name)
        {
            var key = name.NormalizeCaseSensitiveString();
            return all.ContainsKey(key)
                ? all[key]
                : null;
        }
    }
}

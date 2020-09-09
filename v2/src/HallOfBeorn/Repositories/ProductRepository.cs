using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Repositories
{
    public class ProductRepository
    {
        private readonly Dictionary<string, Product> all = new Dictionary<string, Product>();

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

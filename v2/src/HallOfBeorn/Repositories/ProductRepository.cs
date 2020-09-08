using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Repositories
{
    public class ProductRepository
    {
        public IReadOnlyList<Product> AllProducts()
        {
            var products = new List<Product>();

            return products;
        }
    }
}

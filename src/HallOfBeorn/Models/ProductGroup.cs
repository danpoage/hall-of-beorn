using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ProductGroup
    {
        public ProductGroup(string name)
        {
            Name = name;
            ChildProducts = new List<Product>();
        }

        protected void AddProduct(Product product)
        {
            ChildProducts.Add(product);
        }

        public string Name { get; private set; }
        public Product MainProduct { get; set; }
        public List<Product> ChildProducts { get; private set; }
    }
}
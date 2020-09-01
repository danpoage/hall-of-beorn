using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class ProductGroup
        : INamed
    {
        public ProductGroup(string name, List<Product> products)
        {
            Name = new Content(name);
            this.products = products;
        }

        private readonly List<Product> products;

        public Content Name { get; }
        public IReadOnlyList<Product> Products => products;
    }
}

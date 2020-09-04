using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class ProductGroup
        : INamed
    {
        public ProductGroup(string name, List<Product> products, List<Cycle> cycles)
        {
            Name = new Content(name);
            this.products = products;
            this.cycles = cycles;
        }

        private readonly List<Product> products;
        private readonly List<Cycle> cycles;

        public Content Name { get; }
        public IReadOnlyList<Product> Products => products;
        public IReadOnlyList<Cycle> Cycles => cycles;
        
    }
}

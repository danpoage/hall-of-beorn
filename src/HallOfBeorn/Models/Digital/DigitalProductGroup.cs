using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital
{
    public abstract class DigitalProductGroup : IProductGroup<DigitalProduct, DigitalCardSet, DigitalCard>
    {
        protected DigitalProductGroup(string name)
        {
            Name = name;
        }

        private readonly List<DigitalProduct> childProducts = new List<DigitalProduct>();

        protected void addChildProduct(DigitalProduct product)
        {
            childProducts.Add(product);
        }

        public string Name { get; private set; }
        
        public string Abbreviation { get; protected set; }
        
        public DigitalProduct MainProduct { get; protected set; }
        public DigitalProduct SecondProduct { get; protected set; }

        public IEnumerable<DigitalProduct> ChildProducts
        {
            get { return childProducts; }
        }
    }
}
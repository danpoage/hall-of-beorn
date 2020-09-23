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

        private readonly List<DigitalProduct> mainProducts = new List<DigitalProduct>();
        private readonly List<DigitalProduct> childProducts = new List<DigitalProduct>();

        protected void AddMainProduct(DigitalProduct product)
        {
            mainProducts.Add(product);
        }

        protected void addChildProduct(DigitalProduct product)
        {
            childProducts.Add(product);
        }

        public string Name { get; private set; }
        
        public string Abbreviation { get; protected set; }

        public IEnumerable<DigitalProduct> MainProducts
        { 
            get { return mainProducts;  } 
        }

        public IEnumerable<DigitalProduct> ChildProducts
        {
            get { return childProducts; }
        }
    }
}
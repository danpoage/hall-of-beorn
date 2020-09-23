using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ProductGroups;

namespace HallOfBeorn.Services.Digital
{
    public class DigitalProductRepository : IProductRepository<DigitalProductGroup, DigitalProduct, DigitalCardSet, DigitalCard>
    {
        public DigitalProductRepository()
        {
            addProductGroup(new StarterProductGroup());
            addProductGroup(new HeroPacksProductGroup());
            addProductGroup(new ValorProductGroup());
        }

        private readonly List<DigitalProductGroup> productGroups = new List<DigitalProductGroup>();
        private readonly List<DigitalProduct> products = new List<DigitalProduct>();

        private void addProductGroup(DigitalProductGroup group)
        {
            productGroups.Add(group);

            foreach (var main in group.MainProducts)
                products.Add(main);
            
            foreach (var child in group.ChildProducts)
                products.Add(child);
        }

        public IEnumerable<DigitalProductGroup> ProductGroups()
        {
            return productGroups;
        }

        public IEnumerable<DigitalProduct> Products()
        {
            return products;
        }

        public IEnumerable<DigitalCardSet> CardSets()
        {
            foreach (var product in products)
                foreach (var cardSet in product.CardSets)
                    yield return cardSet;
        }
    }
}
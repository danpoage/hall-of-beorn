using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Products;

namespace HallOfBeorn.Services
{
    public class ProductRepository
    {
        public ProductRepository()
        {
            productGroups.Add(new ShadowsOfMirkwoodProductGroup());
            productGroups.Add(new TheDwarrowdelfProductGroup());
            productGroups.Add(new AgainstTheShadowProductGroup());
            productGroups.Add(new TheRingMakerProductGroup());
            productGroups.Add(new AngmarAwakenedProductGroup());

            productGroups.Add(new TheHobbitSagaProductGroup());
            productGroups.Add(new TheLordOfTheRingsSagaProductGroup());

            productGroups.Add(new GenConDeckProductGroup());
            productGroups.Add(new NightmareDeckProductGroup());

            productGroups.Add(new CustomProductGroup());
        }

        private readonly List<ProductGroup> productGroups = new List<ProductGroup>();

        public IEnumerable<ProductGroup> ProductGroups()
        {
            return productGroups;
        }

        public IEnumerable<Product> Products()
        {
            foreach (var group in productGroups)
            {
                foreach (var product in group.ChildProducts)
                {
                    yield return product;
                }
            }
        }
    }
}
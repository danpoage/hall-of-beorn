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
            productGroups.Add(ProductGroup.ShadowsOfMirkwood);
            productGroups.Add(ProductGroup.TheDwarrowdelf);
            productGroups.Add(ProductGroup.AgainstTheShadow);
            productGroups.Add(ProductGroup.TheRingMaker);
            productGroups.Add(ProductGroup.AngmarAwakened);
            productGroups.Add(ProductGroup.DreamChaser);
            productGroups.Add(ProductGroup.TheHobbitSaga);
            productGroups.Add(ProductGroup.TheLordOfTheRingsSaga);
            productGroups.Add(ProductGroup.GenConDeck);
            productGroups.Add(ProductGroup.NightmareDeck);
            productGroups.Add(ProductGroup.DoomMastered);
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
                if (group.MainProduct != null)
                {
                    yield return group.MainProduct;
                }

                foreach (var product in group.ChildProducts)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<CardSet> CardSets()
        {
            foreach (var group in productGroups)
            {
                if (group.MainProduct != null)
                {
                    foreach (var set in group.MainProduct.CardSets())
                    {
                        yield return set;
                    }
                }

                foreach (var product in group.ChildProducts)
                {
                    foreach (var set in product.CardSets())
                    {
                        yield return set;
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Products;

namespace HallOfBeorn.Services.LotR
{
    public class ProductRepository : IProductRepository<ProductGroup, Product, CardSet, LotRCard>
    {
        public ProductRepository()
        {
            productGroups.Add(ProductGroup.ShadowsOfMirkwood);
            productGroups.Add(ProductGroup.StarterDeck);
            productGroups.Add(ProductGroup.Dwarrowdelf);
            productGroups.Add(ProductGroup.AgainstTheShadow);
            productGroups.Add(ProductGroup.TheRingMaker);
            productGroups.Add(ProductGroup.AngmarAwakened);
            productGroups.Add(ProductGroup.DreamChaser);
            productGroups.Add(ProductGroup.Haradrim);
            productGroups.Add(ProductGroup.EredMithrin);
            productGroups.Add(ProductGroup.VengeanceOfMordor);
            productGroups.Add(ProductGroup.TheHobbitSaga);
            productGroups.Add(ProductGroup.TheLordOfTheRingsSaga);
            productGroups.Add(ProductGroup.GenConDeck);
            productGroups.Add(ProductGroup.FellowshipDeck);
            productGroups.Add(ProductGroup.CustomScenarioKits);
            productGroups.Add(ProductGroup.ScenarioPack);

            productGroups.Add(ProductGroup.ShadowsOfMirkwoodNightmare);
            productGroups.Add(ProductGroup.DwarrowdelfNightmare);
            productGroups.Add(ProductGroup.AgainstTheShadowNightmare);
            productGroups.Add(ProductGroup.TheRingMakerNightmare);
            productGroups.Add(ProductGroup.AngmarAwakenedNightmare);
            productGroups.Add(ProductGroup.DreamChaserNightmare);
            productGroups.Add(ProductGroup.TheHobbitSagaNightmare);
            productGroups.Add(ProductGroup.TheLordOfTheRingsSagaNightmare);

            productGroups.Add(ProductGroup.DoomMastered);

            productGroups.Add(ProductGroup.OathsOfTheRohirrim);
            productGroups.Add(ProductGroup.StandAloneScenarios);
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
                foreach (var main in group.MainProducts)
                {
                    yield return main;
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
                foreach (var main in group.MainProducts)
                {
                    foreach (var cardSet in main.CardSets)
                    {
                        yield return cardSet;
                    }
                }
                
                foreach (var product in group.ChildProducts)
                {
                    foreach (var cardSet in product.CardSets)
                    {
                        yield return cardSet;
                    }
                }
            }
        }

        public IEnumerable<string> TraitLabels(string trait, Func<LotRCard, bool> filter)
        {
            foreach (var card in Products().SelectMany(p => p.CardSets).SelectMany(cs => cs.Cards)
                .Where(card => card.HasTraits(trait) && filter(card)))
            {
                yield return card.NormalizedTitle;
                if (card.Title != card.NormalizedTitle)
                {
                    yield return card.Title;
                }
            }
        }

        //public static Func<IProductRepository<ProductGroup, Product, CardSet, LotRCard>> Generator { get; set; }
        
        private static ProductRepository instance;
        
        public static ProductRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("ProductRepository.Instance not initialized");
                    //instance = new ProductRepository();
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }
}
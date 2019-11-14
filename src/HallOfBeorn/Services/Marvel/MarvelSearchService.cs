using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.Marvel;
using HallOfBeorn.Models.Marvel.ViewModels;

namespace HallOfBeorn.Services.Marvel
{
    public class MarvelSearchService
    {
        public MarvelSearchService(
            MarvelProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        private readonly MarvelProductRepository productRepository;

        public IEnumerable<MarvelSearchResult> Search(MarvelSearchViewModel model)
        {
            var results = new List<MarvelSearchResult>();

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    results.Add(new MarvelSearchResult(card, 100));
                }
            }

            return results;
        }
    }
}
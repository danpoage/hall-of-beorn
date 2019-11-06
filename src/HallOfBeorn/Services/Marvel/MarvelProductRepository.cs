using System;
using System.Collections.Generic;
using HallOfBeorn.Models.Marvel;
using HallOfBeorn.Models.Marvel.Products;

namespace HallOfBeorn.Services.Marvel
{
    public class MarvelProductRepository
    {
        public MarvelProductRepository()
        {
            products.Add(new CoreSet());
        }

        private readonly List<MarvelProduct> products = new List<MarvelProduct>();

        public IEnumerable<MarvelProduct> Products()
        {
            return products;
        }

        public IEnumerable<MarvelCard> Cards()
        {
            foreach (var product in products)
            {
                foreach (var card in product.Cards())
                {
                    yield return card;
                }
            }
        }
    }
}

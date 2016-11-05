using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class CardRepository
    {
        public CardRepository(ProductRepository productRepository)
        {
            foreach (var product in productRepository.Products())
            {
                foreach (var cardSet in product.CardSets())
                {
                    foreach (var card in cardSet.Cards)
                    {
                        this.cards.Add(card);
                    }
                }
            }
        }

        private readonly List<LotRCard> cards = new List<LotRCard>();

        public IEnumerable<LotRCard> Cards()
        {
            return cards;
        }

        public LotRCard Find(string id)
        {
            return cards.Where(x => x.Id == id).FirstOrDefault();
        }

        public LotRCard FindBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return null;

            var exact = cards.Where(x => x.Slug.ToLower() == slug.ToLower()).FirstOrDefault();
            if (exact != null)
                return exact;

            var partials = cards.Where(x => x.Slug.ToLower().StartsWith(slug.ToLower()) || x.AlternateSlug.ToLowerSafe().Contains(slug.ToLowerSafe())).ToList();
            if (partials.Count == 1)
                return partials.First();

            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
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

        private readonly List<Card> cards = new List<Card>();

        public IEnumerable<Card> Cards()
        {
            return cards;
        }

        public Card Find(string id)
        {
            return cards.Where(x => x.Id == id).FirstOrDefault();
        }

        public Card FindBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return null;

            var exact = cards.Where(x => x.Slug.ToLower() == slug.ToLower()).FirstOrDefault();
            if (exact != null)
                return exact;

            var partials = cards.Where(x => x.Slug.ToLower().StartsWith(slug.ToLower())).ToList();
            if (partials.Count == 1)
                return partials.First();

            return null;
        }
    }
}
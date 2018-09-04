using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services
{
    public class CardRepository<TRepo, TGroup, TProduct, TCardSet, TCard> : ICardRepository<TCard>
        where TRepo: IProductRepository<TGroup, TProduct, TCardSet, TCard>
        where TGroup: IProductGroup<TProduct, TCardSet, TCard>
        where TProduct: IProduct<TProduct, TCardSet, TCard>
        where TCardSet: ICardSet<TProduct, TCard>
        where TCard: ICard
    {
        public CardRepository(TRepo productRepository)
        {
            foreach (var product in productRepository.Products())
            {
                foreach (var cardSet in product.CardSets)
                {
                    //Player cards (and quest/encounter cards for old-style sets)
                    foreach (var card in cardSet.Cards)
                    {
                        AddCard(card);
                    }
                }
            }
        }

        private readonly List<TCard> cards = new List<TCard>();
        private readonly Dictionary<string, TCard> cardsBySlug = new Dictionary<string, TCard>();

        protected void AddCard(TCard card)
        {
            var slug = card.Slug.ToLower();

            if (cardsBySlug.ContainsKey(slug))
                return;

            cards.Add(card);
            cardsBySlug.Add(slug, card);
        }

        protected virtual IEnumerable<TCard> FindPartialMatches(string normalizedSlug)
        {
            return Cards().Where(x => x.Slug.ToLower().StartsWith(normalizedSlug) 
                || x.AlternateSlug.ToLowerSafe().Contains(normalizedSlug))
                .ToList();
        }

        public IEnumerable<TCard> Cards()
        {
            return cards;
        }

        public TCard FindBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return default(TCard);

            var normalizedSlug = slug.ToLowerSafe();

            if (cardsBySlug.ContainsKey(normalizedSlug))
                return cardsBySlug[normalizedSlug];

            var partials = FindPartialMatches(normalizedSlug);
            if (partials.Count() == 1)
                return partials.First();

            return default(TCard);
        }
    }
}
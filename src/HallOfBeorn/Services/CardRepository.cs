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
    }
}
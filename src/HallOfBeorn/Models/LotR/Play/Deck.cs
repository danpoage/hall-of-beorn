using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Deck
    {
        private List<CardInDeck> cards = new List<CardInDeck>();
        private List<CardInDiscard> discardPile = new List<CardInDiscard>();

        public IEnumerable<CardInDeck> Cards { get { return cards; } }
        public IEnumerable<CardInDiscard> DiscardPile { get { return discardPile; } }

        public IEnumerable<CardInHand> Draw(int numberOfCards)
        {
            var cards = new List<CardInHand>();
            return cards;
        }

        public void Shuffle()
        {
            var random = new Random();

            for (var i=0; i<cards.Count-1;i++)
            {
                var index = i + random.Next(cards.Count - i);
                var target = cards[index];
                cards[index] = cards[i];
                cards[i] = target;
            }
        }

        public void ShuffleDiscardIntoDeck()
        {
            foreach (var discard in discardPile)
            {
                cards.Add(new CardInDeck { Deck = this, Card = discard.Card });
            }

            discardPile.Clear();

            Shuffle();
        }
    }
}

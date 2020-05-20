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
        private List<CardOutOfPlay> sideboardCards = new List<CardOutOfPlay>();

        public string Name { get; set; }
        public string DeckId { get; set; }
        public IEnumerable<CardInDeck> Cards { get { return cards; } }
        public IEnumerable<CardInDiscard> DiscardPile { get { return discardPile; } }
        public IEnumerable<CardOutOfPlay> SideboardCards { get { return sideboardCards; } }

        public IEnumerable<CardInHand> Draw(int count)
        {
            var draws = cards.Count <= count
                ? cards.Take(count)
                : cards.ToList();

            foreach (var draw in draws)
            {
                cards.Remove(draw);
                yield return new CardInHand{ Card = draw.Card, Deck = this };
            }
        }

        public IEnumerable<CardInDeck> LookAt(int count)
        {
            return cards.Count <= count
                ? cards.Take(count)
                : cards.ToList();
        }

        public IEnumerable<CardInDiscard> MillFromTop(int count)
        {
            var mills = cards.Count <= count
                ? cards.Take(count)
                : cards.ToList();

            foreach (var mill in mills)
            {
                cards.Remove(mill);
                var discard = new CardInDiscard { Card = mill.Card, Deck = this };
                discardPile.Add(discard);
                yield return discard;
            }
        }

        public void Load(Dictionary<string, byte> deckList, Func<string, LotRCard> lookupCard)
        {
            foreach (var item in deckList)
            {
                var card = lookupCard(item.Key);
                if (card != null && item.Value > 0)
                {
                    for (var i=1;i<=item.Value;i++)
                    {
                        cards.Add(new CardInDeck { Card = card, Deck = this });
                    }
                }

            }
        }

        public void Load(IEnumerable<Tuple<LotRCard, byte>> cardsWithCounts)
        {
            foreach (var entry in cardsWithCounts)
            {
                if (entry.Item2 > 0)
                {
                    for (var i=1; i<=entry.Item2; i++)
                    {
                        cards.Add(new CardInDeck { Card = entry.Item1, Deck = this });
                    }
                }
            }
        }

        public void LoadSideboard(IEnumerable<Tuple<LotRCard, byte>> cardsWithCounts)
        {
            foreach (var entry in cardsWithCounts)
            {
                if (entry.Item2 > 0)
                {
                    for (var i=1; i<=entry.Item2; i++)
                    {
                        sideboardCards.Add(new CardOutOfPlay { Card = entry.Item1, Deck = this });
                    }
                }
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public class DeckService
    {
        public DeckService(DeckRepository deckRepository, CardRepository cardRepository)
        {
            foreach (var deck in deckRepository.Decks())
            {
                AddDeck(deck, cardRepository);
            }
        }

        private readonly Dictionary<string, Deck> decks = new Dictionary<string, Deck>();
        private readonly Dictionary<string, Dictionary<string, Deck>> decksByCardSlug = new Dictionary<string, Dictionary<string, Deck>>();

        private void AddDeck(Deck deck, CardRepository cardRepository)
        {
            if (deck == null || decks.ContainsKey(deck.Name))
                return;

            decks.Add(deck.Name, deck);

            if (string.IsNullOrEmpty(deck.DeckList))
                return;

            foreach (var line in deck.DeckList.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                var tokens = line.Split(' ').ToList();
                if (tokens == null || tokens.Count == 0)
                    continue;

                if (tokens.Last().StartsWith("x"))
                {
                    tokens.Remove(tokens.Last());
                }

                var setName = string.Empty;
                var last = tokens.LastOrDefault();
                if (last != null && last.Contains('(') && last.Contains(')'))
                {
                    setName = last.Trim().TrimStart('(').TrimEnd(')');
                    tokens.Remove(last);
                }

                if (tokens.Count == 0)
                    continue;

                var title = string.Join(" ", tokens).ToLower();

                var card = cardRepository.Cards().Where(x =>
                    (
                        (string.Equals(x.Title.ToLower(), title) || (!string.IsNullOrEmpty(x.NormalizedTitle) && string.Equals(x.NormalizedTitle.ToLower(), title)))
                        && (string.IsNullOrEmpty(setName) || (string.Equals(x.CardSet.Abbreviation, setName) || string.Equals(x.CardSet.Name, setName)))
                        && (x.CardType == CardType.Hero || x.CardType == CardType.Ally || x.CardType == CardType.Attachment || x.CardType == CardType.Event || x.CardType == CardType.Treasure)
                    )
                ).FirstOrDefault();

                if (card != null && !IncludesCard(deck.Name, card.Slug))
                {
                    if (!decksByCardSlug.ContainsKey(card.Slug))
                    {
                        decksByCardSlug.Add(card.Slug, new Dictionary<string, Deck>());
                    }

                    decksByCardSlug[card.Slug].Add(deck.Name, deck);
                }
            }
        }

        public bool IncludesCard(string deckName, string cardSlug)
        {
            if (!decksByCardSlug.ContainsKey(cardSlug))
            {
                return false;
            }
            else
            {
                return decksByCardSlug[cardSlug].ContainsKey(deckName);
            }
        }

        public IEnumerable<Deck> Decks(string cardSlug)
        {
            return decksByCardSlug.ContainsKey(cardSlug) ? decksByCardSlug[cardSlug].Values.ToList().OrderBy(x => x.Name) : Enumerable.Empty<Deck>();
        }
    }
}
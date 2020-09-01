using System.Collections.Immutable;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class CardSet
        : INamed
    {
        public CardSet(Product product,
            string name, string abbreviation, ushort number, SetType setType,
            List<Card> playerCards, List<EncounterSet> encounterSets)
        {
            Product = product;
            Name = new Content(name);
            Abbreviation = abbreviation;
            Number = number;
            SetType = setType;

            foreach (var card in playerCards)
            {
                playerCards.Add(card);
                cards.Add(card);
            }

            foreach (var encounterSet in encounterSets)
            {
                encounterSets.Add(encounterSet);
                foreach (var card in encounterSet.Cards)
                {
                    cards.Add(card);
                }
            }
        }

        private readonly List<Card> playerCards = new List<Card>();
        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();
        private readonly List<Card> cards = new List<Card>();

        public INamed Product { get; }
        public Content Name { get; }
        public string Abbreviation { get; }
        public ushort Number { get; }
        public SetType SetType { get; }

        public IReadOnlyList<Card> PlayerCards => playerCards;
        public IReadOnlyList<EncounterSet> EncounterSets => encounterSets;
        public IReadOnlyList<Card> Cards => cards;
    }
}

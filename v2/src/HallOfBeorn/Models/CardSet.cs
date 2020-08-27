using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class CardSet
        : INamed
    {
        public CardSet(Product product, List<Card> playerCards, List<EncounterSet> encounterSets)
        {
            Product = product;
            this.playerCards = playerCards;
            this.encounterSets = encounterSets;
        }

        public INamed Product { get; set; }
        public Content Name { get; set; }
        public string Abbreviation { get; set; }
        public ushort Number { get; set; }
        public SetType SetType { get; set; }

        public readonly List<Card> playerCards;
        public readonly List<EncounterSet> encounterSets;
        public IEnumerable<Card> Cards
        {
            get
            {
                foreach (var card in playerCards)
                {
                    yield return card;
                }
                
                foreach (var encounterSet in encounterSets)
                {
                    foreach (var card in encounterSet.Cards)
                    {
                        yield return card;
                    }
                }
            }
        }
    }
}

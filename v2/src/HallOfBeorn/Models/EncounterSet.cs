using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class EncounterSet
        : INamed
    {
        public EncounterSet(CardSet cardSet, string name, List<Card> cards)
            : this(cardSet, name, cards, null)
        {
        }

        public EncounterSet(CardSet cardSet, string name, List<Card> cards, string alternateName)
        {
            CardSet = cardSet;
            Name = new Content(name);
            this.cards = cards;
            AlternateName = alternateName != null ? new Content(alternateName) : null;
        }

        private readonly List<Card> cards;
        
        public INamed CardSet { get; }
        public Content Name { get; }
        public Content AlternateName { get; }
        public IReadOnlyList<Card> Cards => cards;
    }
}

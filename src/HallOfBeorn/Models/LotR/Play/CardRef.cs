using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public abstract class CardRef
        : Target
    {
        protected CardRef(Deck deck, LotRCard card)
            : base(card.NormalizedTitle)
        {
            Deck = deck;
            Card = card;
        }

        public Deck Deck { get; private set; }
        public LotRCard Card { get; private set; }
    }
}
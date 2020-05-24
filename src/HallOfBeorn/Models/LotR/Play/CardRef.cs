using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public abstract class CardRef
    {
        protected CardRef(Deck deck, LotRCard card)
        {
            Id = Guid.NewGuid().ToString("D");
            Deck = deck;
            Card = card;
        }

        public string Id { get; private set; }
        public Deck Deck { get; private set; }
        public LotRCard Card { get; private set; }
    }
}
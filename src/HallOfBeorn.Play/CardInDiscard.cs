using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Play
{
    public class CardInDiscard
        : CardRef
    {
        public CardInDiscard(Deck deck, LotRCard card)
            : base(deck, card)
        {
        }
        
        public override string ToString()
        {
            return Card.Title + " [In Discard]";
        }
    }
}
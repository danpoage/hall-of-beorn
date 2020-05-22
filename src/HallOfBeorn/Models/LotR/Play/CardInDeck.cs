using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInDeck
        : CardRef
    {
        public CardInDeck(Deck deck, LotRCard card)
            : base(deck, card)
        {
        }
        
        public override string ToString()
        {
            return Card.Title + " [In Deck]";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Play
{
    public class CardInHand
        : CardRef
    {
        public CardInHand(Deck deck, LotRCard card)
            : base(deck, card)
        {
        }
        
        public override string ToString()
        {
            return Card.Title + " [In Hand]";
        }
    }
}
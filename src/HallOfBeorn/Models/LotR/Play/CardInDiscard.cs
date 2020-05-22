using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInDiscard
    {
        public LotRCard Card { get; set; }
        public Deck Deck { get; set; }

        public override string ToString()
        {
            return Card.Title + " [In Discard]";
        }
    }
}
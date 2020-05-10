using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInHand
    {
        public LotRCard Card { get; set; }
        public Deck Deck { get; set; }
    }
}
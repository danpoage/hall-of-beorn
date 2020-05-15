using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardOutOfPlay
    {
        public Deck Deck { get; set; }
        public LotRCard Card { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Player
    {
        public bool IsFirstPlayer { get; set; }

        public byte Threat { get; set; }

        public Deck Deck { get; set; }

        public List<CardInPlay> PlayArea { get; set; }
    }
}

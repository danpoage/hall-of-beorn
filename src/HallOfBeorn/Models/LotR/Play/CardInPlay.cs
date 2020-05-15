using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInPlay
    {
        public CardInPlay(Deck deck, LotRCard card)
        {
            Deck = deck;
            Card = card;
        }

        public Deck Deck { get; set; }
        public LotRCard Card { get; set; }
        
        public bool IsExhausted { get; set; }
        public bool IsCommitted { get; set; }

        public uint DamageTokens { get; set; }
        public uint ProgressTokens { get; set; }
        public uint ResourceTokens { get; set; }

        public List<CardInPlay> Attachments = new List<CardInPlay>();
        public CardInPlay GuardedBy { get; set; }
    }
}
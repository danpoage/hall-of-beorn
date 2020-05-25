using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInPlay
        : CardRef
    {
        public CardInPlay(Deck deck, LotRCard card)
            : base(deck, card)
        {
        }

        public CardSide ActiveSide { get; set; }
        
        public bool IsAttacking { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsDefending { get; set; }
        public bool IsEnteringPlay { get; set; }
        public bool IsExhausted { get; set; }
        public bool IsLeavingPlay { get; set; }

        public uint DamageTokens { get; set; }
        public uint ProgressTokens { get; set; }
        public uint ResourceTokens { get; set; }

        public List<CardInPlay> Attachments = new List<CardInPlay>();
        public List<CardInPlay> ShadowCards = new List<CardInPlay>();
        public CardInPlay GuardedBy { get; set; }

        public override string ToString()
        {
            return Card.Title + " [In Play]";
        }
    }
}
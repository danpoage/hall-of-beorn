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

        public CardInPlay(Deck deck, LotRCard card, string refId)
            : base(deck, card, refId)
        {
        }

        //TODO: Set this
        public Player Owner { get; set; }

        public CardSide ActiveSide { get; set; }
        
        //TODO: Consider a set of flags
        public bool IsAttacking { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsDefending { get; set; }
        public bool IsEnteringPlay { get; set; }
        public bool IsExhausted { get; set; }
        public bool IsLeavingPlay { get; set; }

        public bool HasSphere(Sphere sphere)
        {
            return (sphere == Sphere.Neutral)
                ? true
                : Card.Sphere == sphere;
        }

        public uint DamageTokens { get; set; }
        public uint ProgressTokens { get; set; }
        public uint ResourceTokens { get; set; }
        
        public uint ResourcesPaid { get; set; }

        public byte Threat { get; set; }
        public byte Willpower { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte HitPoints { get; set; }

        public List<CardInPlay> Attachments = new List<CardInPlay>();
        public List<CardInPlay> ShadowCards = new List<CardInPlay>();
        public CardInPlay GuardedBy { get; set; }

        public override string ToString()
        {
            return Card.Title + " [In Play]";
        }
    }
}
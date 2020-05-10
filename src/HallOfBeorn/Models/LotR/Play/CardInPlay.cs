﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class CardInPlay
    {
        public LotRCard Card { get; set; }
        public Deck Deck { get; set; }

        public bool IsExhausted { get; set; }
        public uint DamageTokens { get; set; }
        public uint ProgressTokens { get; set; }
        public uint ResourceTokens { get; set; }

        public List<CardInPlay> Attachments = new List<CardInPlay>();
        public CardInPlay GuardedBy { get; set; }
    }
}
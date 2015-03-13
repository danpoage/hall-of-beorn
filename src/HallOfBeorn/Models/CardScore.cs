using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class CardScore
    {
        public CardScore(Card card, float score)
        {
            this.Card = card;
            this.Score = score;
        }

        public Card Card { get; set; }
        public float Score { get; set; }
    }
}
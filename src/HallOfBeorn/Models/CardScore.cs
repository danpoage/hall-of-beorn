using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class CardScore
    {
        public CardScore(Card card, float score, string description)
        {
            this.Card = card;
            this.Score = score;
            this.Description = description;
        }

        public Card Card { get; private set; }
        public float Score { get; set; }
        public string Description { get; set; }
    }
}
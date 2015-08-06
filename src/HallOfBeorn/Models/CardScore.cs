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
            this.Description = description;

            AddScore(score);
        }

        private readonly List<float> scores = new List<float>();

        public Card Card { get; private set; }
        public string Description { get; set; }

        public void AddScore(float score)
        {
            scores.Add(score);
        }

        public float Score()
        {
            if (scores.Any(x => x == 0))
            {
                return 0;
            }

            return scores.Average();
        }
    }
}
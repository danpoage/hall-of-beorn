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
            AddDescription(description);
            AddScore(score);
        }

        private readonly List<float> scores = new List<float>();
        private readonly List<string> descriptions = new List<string>();

        public Card Card { get; private set; }
        
        public string Description
        {
            get
            {
                var sb = new System.Text.StringBuilder();

                sb.AppendFormat("<div>Score: {0}</div>", Math.Truncate(Score()));
                sb.Append("<ul>");

                foreach (var desc in descriptions)
                {
                    sb.AppendFormat("<li>{0}</li>", desc);
                }

                sb.Append("</ul>");

                return sb.ToString();
            }
        }

        public void AddDescription(string description)
        {
            descriptions.Add(description);
        }

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
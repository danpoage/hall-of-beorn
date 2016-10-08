using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamSearchResult
    {
        public ArkhamSearchResult(ArkhamCard card)
            : this(card, 1)
        {
        }

        public ArkhamSearchResult(ArkhamCard card, float score)
        {
            this.Card = card;
            this.Score = score;
        }

        public ArkhamCard Card { get; private set; }
        public float Score { get; private set; }
    }
}
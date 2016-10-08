using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamSearchResult
    {
        public ArkhamSearchResult(ArkhamCard card)
        {
            this.Card = card;
        }

        public ArkhamCard Card { get; private set; }
    }
}
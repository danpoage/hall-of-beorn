using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Search
{
    public class VictoryPointFilter : Filter
    {
        public VictoryPointFilter(string target)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            byte victoryPoints = 0;
            if (!byte.TryParse(target.Replace("Victory", string.Empty).Trim('.'), out victoryPoints))
                return;

            predicate = (score) => {
                var match = score.Card.VictoryPoints == victoryPoints;
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }
    }
}
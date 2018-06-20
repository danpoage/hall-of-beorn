using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Search
{
    public class TraitFilter : Filter
    {
        public TraitFilter(string target)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            if (!target.EndsWith("."))
                target = target + ".";

            predicate = (score) => {
                var match = score.Card.Traits.Any(t => t == target) || score.Card.NormalizedTraits.Any(t => t == target);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }
    }
}
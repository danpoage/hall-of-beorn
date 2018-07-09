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

        public TraitFilter(string value, bool isNegation)
        {
            if (string.IsNullOrWhiteSpace(value) || value == defaultValue)
                return;

            var values = GetStringValues(value, ".");
            
            if (isNegation)
            {
                predicate = (score) => {
                    var match = false;
                    foreach (var target in values)
                    {
                        match = score.Card.Traits.All(tr => tr != target) && score.Card.NormalizedTraits.All(tr => tr != target);
                        if (!match)
                            break;
                    }
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
            else
            {
                predicate = (score) => {
                    var match = false;
                    foreach (var target in values)
                    {
                        match = score.Card.Traits.Any(tr => tr == target) || score.Card.NormalizedTraits.Any(tr => tr == target);
                        if (match)
                            break;
                    }
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
        }
    }
}

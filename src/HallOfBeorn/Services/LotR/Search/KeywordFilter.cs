using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Search
{
    public class KeywordFilter : Filter
    {
        public KeywordFilter(string target)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            if (!target.EndsWith("."))
                target = target + ".";

            predicate = (score) => {
                var match = score.Card.Keywords.Any(k => k == target) || score.Card.NormalizedKeywords.Any(k => k == target);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }

        public KeywordFilter(string value, bool isNegation)
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
                        match = !score.Card.Keywords.Any(k => k == target) && !score.Card.NormalizedKeywords.Any(k => k == target);
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
                        match = score.Card.Keywords.Any(k => k == target) || score.Card.NormalizedKeywords.Any(k => k == target);
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
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

            target = target.Trim();

            predicate = (score) => {
                var match = score.Card.Keywords.Any(kw => kw.Trim().StartsWith(target)) || score.Card.NormalizedKeywords.Any(kw => kw.Trim().StartsWith(target));
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }

        public KeywordFilter(string value, bool isNegation)
        {
            if (string.IsNullOrWhiteSpace(value) || value == defaultValue)
                return;

            var values = GetStringValues(value, string.Empty);

            if (isNegation)
            {
                predicate = (score) => {
                    var match = false;
                    foreach (var target in values)
                    {
                        match = score.Card.Keywords.All(kw => !kw.Trim().StartsWith(target)) 
                            && score.Card.NormalizedKeywords.All(kw => !kw.Trim().StartsWith(target));
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
                        match = score.Card.Keywords.Any(k => k.Trim().StartsWith(target)) 
                            || score.Card.NormalizedKeywords.Any(k => k.Trim().StartsWith(target));
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
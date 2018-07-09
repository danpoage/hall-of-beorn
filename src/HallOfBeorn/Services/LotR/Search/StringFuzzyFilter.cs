using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringFuzzyFilter : Filter
    {
        public StringFuzzyFilter(Func<CardScore, string> getValue, string target, Func<string, string, bool> compareValues)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            predicate = (score) => {
                var match = compareValues(getValue(score), target);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }

        public StringFuzzyFilter(Func<CardScore, string> getValue, string target, Func<string, string, bool> compareValues, bool isNegation)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            var values = GetStringValues(target, string.Empty);

            if (isNegation)
            {
                predicate = (score) =>
                {
                    var match = values.All(v => !compareValues(getValue(score), v));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
            else
            {
                predicate = (score) =>
                {
                    var match = values.Any(v => compareValues(getValue(score), v));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class CategoryFilter<TEnum> : Filter
        where TEnum : struct
    {
        public CategoryFilter(Func<CardScore, TEnum, bool> hasCategory, string target)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            var normalizedTarget = target.Replace(' ', '_');

            var targetEnum = default(TEnum);
            if (!Enum.TryParse<TEnum>(normalizedTarget, out targetEnum))
                return;

            predicate = (score) => {
                var match = hasCategory(score, targetEnum);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }

        public CategoryFilter(Func<CardScore, TEnum, bool> hasCategory, string value, bool isNegation)
        {
            if (string.IsNullOrWhiteSpace(value) || value == defaultValue)
                return;

            var values = GetEnumValues<TEnum>(value);
            if (values.Count() == 0)
                return;

            if (isNegation)
            {
                predicate = (score) =>
                {
                    var match = !values.All(v => hasCategory(score, v));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
            else
            {
                predicate = (score) =>
                {
                    var match = values.Any(v => hasCategory(score, v));
                    score.AddScore(match ? 1 : 0);
                    return match;
                };
            }
        }
    }
}
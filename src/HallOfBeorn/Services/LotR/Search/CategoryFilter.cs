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
    }
}
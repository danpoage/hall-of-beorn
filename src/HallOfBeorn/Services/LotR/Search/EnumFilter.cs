using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class EnumFilter<TEnum> : Filter
        where TEnum : struct
    {
        public EnumFilter(Func<CardScore, TEnum> getValue, string target, Func<string, string> normalizeTarget)
        {
            if (normalizeTarget != null)
                target = normalizeTarget(target);

            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            TEnum targetEnum = default(TEnum);
            if (!Enum.TryParse<TEnum>(target, out targetEnum))
                return;

            predicate = (score) => {
                var match = Enum.Equals(getValue(score), targetEnum);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }

        public EnumFilter(Func<CardScore, TEnum> getValue, TEnum? target)
        {
            if (!target.HasValue)
                return;

            predicate = (score) => {
                var match = Enum.Equals(getValue(score), target);
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }
    }
}
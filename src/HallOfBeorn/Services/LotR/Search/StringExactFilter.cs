using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringExactFilter : Filter
    {
        public StringExactFilter(Func<CardScore, string> getValue, string target)
        {
            if (string.IsNullOrWhiteSpace(target) || target == defaultValue)
                return;

            predicate = (score) => {
                var match = getValue(score) == target;
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }
    }
}
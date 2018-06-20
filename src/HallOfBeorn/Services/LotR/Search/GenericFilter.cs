using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class GenericFilter: Filter
    {
        public GenericFilter(string target, params Func<CardScore, string, bool>[] options)
        {
            if (string.IsNullOrWhiteSpace(target)|| target == defaultValue)
                return;

            predicate = (score) => {
                var match = options.Any(opt => opt(score, target));
                score.AddScore(match ? 1 : 0);
                return match;
            };
        }
    }
}
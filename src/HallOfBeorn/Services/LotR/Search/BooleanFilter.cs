using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class BooleanFilter : Filter
    {
        public BooleanFilter(Func<CardScore, bool> check, bool isNegation)
        {
            predicate = (score) =>
            {
                var match = isNegation ? !check(score) : check(score);
                score.AddScore(match ? 1 : 0);
                return match;
            };   
        }
    }
}

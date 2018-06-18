using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Sort<TKey> : IComponent
    {
        public Sort(Func<CardScore, TKey> keySelector, bool isAscending)
        {
            this.keySelector = keySelector;
            this.isAscending = isAscending;
        }

        private readonly Func<CardScore, TKey> keySelector;
        private readonly bool isAscending;

        public IEnumerable<CardScore> Apply(IEnumerable<CardScore> scores)
        {
            return isAscending ? scores.OrderBy(keySelector)
                : scores.OrderByDescending(keySelector);
        }
    }
}
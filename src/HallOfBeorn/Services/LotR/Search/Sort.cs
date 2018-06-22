using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Sort<TKey> : IComponent
    {
        public Sort(Func<CardScore, TKey> keySelector, bool isAscending, bool isTopLevel)
        {
            this.keySelector = keySelector;
            this.isAscending = isAscending;
            this.isTopLevel = isTopLevel;
        }

        private readonly Func<CardScore, TKey> keySelector;
        private readonly bool isAscending;
        private readonly bool isTopLevel;

        public bool IsEmpty
        {
            get { return keySelector == null; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            if (keySelector == null)
                return scores;

            if (isTopLevel)
            {
                return isAscending ?
                    scores.OrderBy(keySelector)
                    : scores.OrderByDescending(keySelector);
            }
            else
            {
                return isAscending ?
                    scores.ThenBy(keySelector)
                    : scores.ThenByDescending(keySelector);
            }
        }
    }
}
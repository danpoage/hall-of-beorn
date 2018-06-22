using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class Filter : IComponent
    {
        public Filter()
        {
        }

        public Filter(Func<CardScore, bool> predicate)
        {
            this.predicate = predicate;
        }

        protected const string defaultValue = "Any";
        protected Func<CardScore, bool> predicate;

        public bool IsEmpty
        {
            get { return predicate == null; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            return scores.Where(predicate).OrderBy(s => 1);
        }
    }
}
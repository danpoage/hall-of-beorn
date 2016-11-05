using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Models.LotR.Search
{
    public class SimpleFilterDefinition : FilterDefinition
    {
        public SimpleFilterDefinition(string name, Func<SearchViewModel, object> getValue, Func<SearchViewModel, LotRCard, bool> isMatch, float score)
            : base(name, getValue)
        {
            this.isMatch = isMatch;
            this.score = score;
        }

        protected readonly Func<SearchViewModel, LotRCard, bool> isMatch;
        protected readonly float score;

        protected override IEnumerable<SearchFilter> getFilters(SearchViewModel model)
        {
            return new List<SearchFilter>
            {
                new SearchFilter((s, c) => { return isMatch(s, c); }, this.score, this.name + " matches '" + this.getValue(model).ToString() + "'")
            };
        }
    }
}
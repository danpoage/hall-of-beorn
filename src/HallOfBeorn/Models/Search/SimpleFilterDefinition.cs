using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public class SimpleFilterDefinition : FilterDefinition
    {
        public SimpleFilterDefinition(string name, Func<SearchViewModel, object> getValue, Func<SearchViewModel, Card, bool> isMatch, float score)
            : base(name, getValue)
        {
            this.isMatch = isMatch;
            this.score = score;
        }

        protected readonly Func<SearchViewModel, Card, bool> isMatch;
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
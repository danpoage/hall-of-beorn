using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public class EnumFilterDefinition : SimpleFilterDefinition
    {
        public EnumFilterDefinition(string name, Func<SearchViewModel, object> getValue, Func<SearchViewModel, Card, bool> isMatch, float score)
            : base(name, getValue, isMatch, score)
        {
        }

        protected override IEnumerable<SearchFilter> getFilters(SearchViewModel model)
        {
            return new List<SearchFilter>
            {
                new SearchFilter((s, c) => { return isMatch(s, c); }, 100, this.name + " matches '" + getValue(model).ToEnumDisplayString() + "'")
            };
        }
    }
}
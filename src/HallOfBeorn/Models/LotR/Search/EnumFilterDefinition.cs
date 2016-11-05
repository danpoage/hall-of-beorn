using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Models.LotR.Search
{
    public class EnumFilterDefinition : SimpleFilterDefinition
    {
        public EnumFilterDefinition(string name, Func<SearchViewModel, object> getValue, Func<SearchViewModel, LotRCard, bool> isMatch, float score)
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
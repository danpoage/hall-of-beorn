using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public class FilterDefinition
    {
        public FilterDefinition(string name, Func<SearchViewModel, object> getValue)
            : this(name, getValue, null)
        {
        }

        public FilterDefinition(string name, Func<SearchViewModel, object> getValue, Func<SearchViewModel, object> getOperator)
        {
            this.name = name;
            this.getValue = getValue;
            this.getOperator = getOperator;
        }

        private readonly string name;
        private readonly Func<SearchViewModel, object> getValue;
        private readonly Func<SearchViewModel, object> getOperator;

        public bool HasValue<T>(SearchViewModel model)
        {
            if (getOperator != null && getOperator(model) == null)
            {
                return false;
            }

            return getValue(model) != null;
        }
    }
}
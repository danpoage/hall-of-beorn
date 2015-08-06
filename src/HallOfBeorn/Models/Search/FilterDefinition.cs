using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Search
{
    public abstract class FilterDefinition
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

        const string VALUE_ANY = "Any";

        protected readonly string name;
        protected readonly Func<SearchViewModel, object> getValue;
        protected readonly Func<SearchViewModel, object> getOperator;

        protected abstract IEnumerable<SearchFilter> getFilters(SearchViewModel model);

        public bool HasValue<T>(SearchViewModel model)
        {
            if (getOperator != null && getOperator(model) == null)
            {
                return false;
            }

            var value = getValue(model);
            return value != null && value.ToString() != VALUE_ANY;
        }

        public bool HasValue(SearchViewModel model)
        {
            if (getOperator != null && getOperator(model) == null)
            {
                return false;
            }

            var value = getValue(model);
            return value != null && value.ToString() != VALUE_ANY;
        }

        public IEnumerable<SearchFilter> Filters(SearchViewModel model)
        {
            return getFilters(model);
        }
    }
}
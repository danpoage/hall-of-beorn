using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Models.LotR.Search
{
    public class QueryFilterDefinition : FilterDefinition
    {
        public QueryFilterDefinition()
            : base("Query", (m) => { return m.Query; })
        {
        }

        protected override IEnumerable<SearchFilter> getFilters(SearchViewModel model)
        {
            var queryFilters = new List<SearchFilter>();
            queryFilters.Add(new SearchFilter((s, c) => { return c.Title.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.IsEqualToLower(s.BasicQuery()); }, 200, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Title.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.StartsWithLower(s.BasicQuery()); }, 141, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Title.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTitle.ContainsLower(s.BasicQuery()); }, 100, "Title matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Text.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.OppositeText.ContainsLower(s.BasicQuery()); }, 100, "Card Text matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Equals(s.BasicQuery() + ".")); }, 130, "Trait matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Traits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.NormalizedTraits.Any(t => t.ToLowerSafe().Contains(s.BasicQuery())); }, 120, "Trait contains '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Equals(s.BasicQuery())); }, 115, "Keyword matches '" + model.Query + "'"));
            queryFilters.Add(new SearchFilter((s, c) => { return c.Keywords.Any(k => k.ToLowerSafe().Contains(s.BasicQuery())); }, 110, "Keyword contains '" + model.Query + "'"));

            return new List<SearchFilter> { new SearchFilter(queryFilters) };
        }
    }
}
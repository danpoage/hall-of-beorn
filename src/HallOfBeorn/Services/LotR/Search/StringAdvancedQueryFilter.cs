using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringAdvancedQueryFilter : IComponent
    {
        public StringAdvancedQueryFilter(string query, AdvancedSearchService service)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            filters = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => x.StartsWith("-") || x.StartsWith("+")).ToListSafe();
            if (filters.Count == 0)
                return;

            this.query = query;
            this.service = service;
        }

        private readonly string query;
        private readonly List<string> filters;
        private readonly AdvancedSearchService service;

        public bool IsEmpty
        {
            get { return service == null; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            var model = new SearchViewModel { Query = query };
            return service.Search(model, scores.ToList()).OrderBy(r => 1);
        }
    }
}
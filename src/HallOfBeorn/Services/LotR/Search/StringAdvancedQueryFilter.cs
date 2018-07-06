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
        public StringAdvancedQueryFilter(string query, IAdvancedSearchService service)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            _filters = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => x.StartsWith("-") || x.StartsWith("+")).ToListSafe();
            if (_filters.Count == 0)
                return;

            _query = query;
            _service = service;
        }

        private readonly string _query;
        private readonly List<string> _filters;
        private readonly IAdvancedSearchService _service;

        public bool IsEmpty
        {
            get { return _service == null; }
        }

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            var model = new SearchViewModel { Query = _query };
            return _service.Search(model, scores.ToList()).OrderBy(r => 1);
        }
    }
}
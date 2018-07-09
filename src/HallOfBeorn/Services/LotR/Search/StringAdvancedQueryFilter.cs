using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringAdvancedQueryFilter : IComponent
    {
        public StringAdvancedQueryFilter(string query, IFilterService filterService)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            _parts = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => x.StartsWith("-") || x.StartsWith("+")).ToListSafe();
            if (_parts.Count == 0)
                return;

            _query = query;
            _filterService = filterService;
        }

        private readonly string _query;
        private readonly List<string> _parts;
        private readonly IFilterService _filterService;

        public bool IsEmpty
        {
            get { return _filterService == null; }
        }

        /*
         * TODO: Remove after testing
        public IOrderedEnumerable<CardScore> ApplyOld(IOrderedEnumerable<CardScore> scores)
        {
            var model = new SearchViewModel { Query = _query };
            return _service.Search(model, scores.ToList()).OrderBy(r => 1);
        }
        */

        public IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores)
        {
            var orMode = false;
            var allResults = scores;
            var orResults = new Dictionary<string, CardScore>();

            foreach (var part in _parts)
            {
                var fields = part.Split(new char[] { ':', '=' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();

                if (fields.Count == 0 || string.IsNullOrEmpty(fields[0]))
                    continue;

                var isNegation = (fields[0][0] == '-');
                var name = fields[0].ToLower().Trim('-', '+');
                
                if (name == "and") {
                    orMode = false;
                    if (orResults.Count > 0) {
                        allResults = orResults.Values.OrderBy(x => 1);
                    }
                    continue;
                } else if (name == "or") {
                    orMode = true;
                    continue;
                }
                
                var value = string.Empty;

                if (fields.Count > 1)
                {
                    value = fields[1];
                }

                var filter = _filterService.GetFilter(name, value, isNegation);
                if (filter == null || filter.IsEmpty)
                    continue;

                var filterResults = filter.Apply(allResults);

                if (orMode) {
                    foreach (var res in filterResults)
                        orResults[res.Card.Slug] = res;
                } else {
                    allResults = filterResults;
                }
            }

            return orMode ? orResults.Values.OrderBy(x => 1) : allResults;
        }
    }
}
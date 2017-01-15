using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Search;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR
{
    public class SearchSortService
    {
        public SearchSortService(RingsDbService ringsDbService)
        {
            this.ringsDbService = ringsDbService;

            this.popularityLookup = (slug) => { return ringsDbService.GetPopularity(slug); };
        }

        const int MAX_RESULTS = 128;

        private readonly RingsDbService ringsDbService;
        private readonly Func<string, byte> popularityLookup;

        public List<CardScore> Sort(SearchViewModel model, List<SearchFilter> filters, Dictionary<string, CardScore> results)
        {
            var sortedResults = new List<CardScore>();

            var takeCount = model.HasFilter() || model.IsRandom() ? results.Count : MAX_RESULTS;

            /*
            var limit = filters.Max(x => x.Limit);
            if (limit > 0)
            {
                takeCount = limit;
            }
            */

            var sort = model.Sort.HasValue ? model.Sort.Value : Models.LotR.Sort.None;

            if (filters.Count == 1 && model.CardSet != null && model.CardSet != "Any" && sort == Models.LotR.Sort.None)
            {
                sort = Models.LotR.Sort.Set_Number;
            }

            switch (sort)
            {
                case Models.LotR.Sort.Alphabetical:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderBy(x => x.Value.Card.Title).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Models.LotR.Sort.Sphere_Type_Cost:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderBy(x => x.Value.Card.Sphere).ThenBy(x => x.Value.Card.CardType).ThenBy(x => x.Value.Card.CardSubtype).ThenBy(x =>
                    {
                        if (x.Value.Card.ThreatCost.HasValue && x.Value.Card.ThreatCost.Value > 0)
                            return x.Value.Card.ThreatCost.Value;
                        else if (x.Value.Card.ResourceCost.HasValue && x.Value.Card.ResourceCost.Value > 0)
                            return x.Value.Card.ResourceCost.Value;
                        else if (x.Value.Card.EngagementCost.HasValue && x.Value.Card.EngagementCost.Value > 0)
                            return x.Value.Card.EngagementCost.Value;
                        else if (x.Value.Card.QuestPoints.HasValue && x.Value.Card.QuestPoints > 0)
                            return x.Value.Card.QuestPoints.Value;
                        else
                            return -1;
                    }).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Models.LotR.Sort.Set_Number:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderBy(x => x.Value.Card.CardSet.Number).ThenBy(x => x.Value.Card.CardNumber).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Models.LotR.Sort.Released:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderBy(x => x.Value.Card.CardSet.Product.FirstReleased).ThenBy(x => x.Value.Card.CardSet.Number).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                case Models.LotR.Sort.Popularity:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderByDescending(x => popularityLookup(x.Value.Card.Slug)).ThenBy(x => x.Value.Card.CardSet.Number).ThenBy(x => x.Value.Card.CardNumber).Select(x => x.Value).Take(takeCount).ToList();
                    break;
                default:
                    sortedResults = results.Where(x => x.Value.Score() > 0).OrderByDescending(x => x.Value.Score()).Select(y => y.Value).Take(takeCount).ToList();
                    break;
            }

            return sortedResults;
        }
    }
}
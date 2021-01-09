using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Services.LotR.Search
{
    public class SearchService : ISearchService
    {
        public SearchService(LotRCardRepository cardRepository, IPlanService planService)
        {
            _cardRepository = cardRepository;
            _planService = planService;
        }

        private readonly LotRCardRepository _cardRepository;
        private readonly IPlanService _planService;

        private IOrderedEnumerable<CardScore> InitialScores()
        {
            return _cardRepository
                .Cards()
                .Select(card => new CardScore(card, 1, string.Empty))
                .OrderBy(s => 1);
        }

        public IOrderedEnumerable<CardScore> Search(SearchViewModel model, UserSettings settings)
        {
            var all = _cardRepository
                .Cards()
                .Select(card => new CardScore(card, 1, string.Empty))
                .OrderBy(s => 1);

            var scores = _planService
                .CreatePlan(model, settings)
                .Execute(all);

            return scores;
        }
    }
}
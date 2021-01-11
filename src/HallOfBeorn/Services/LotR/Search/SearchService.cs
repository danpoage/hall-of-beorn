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

        private Func<LotRCard, bool> GetProductFilter(UserSettings settings)
        {
            if (!settings.FilterOwnedProducts || settings.OwnedProducts == null || settings.OwnedProducts.Count == 0)
            {
                return (c) => true;
            }

            return (c) => c.CardSet != null && c.CardSet.Product != null && settings.OwnedProducts.Contains(c.CardSet.Product.Code);
        }

        public IOrderedEnumerable<CardScore> Search(SearchViewModel model, UserSettings settings)
        {
            Func<LotRCard, bool> productFilter = GetProductFilter(settings);

            var all = _cardRepository
                .Cards()
                .Where(productFilter)
                .Select(card => new CardScore(card, 1, string.Empty))
                .OrderBy(s => 1);

            var scores = _planService
                .CreatePlan(model, settings)
                .Execute(all);

            return scores;
        }
    }
}
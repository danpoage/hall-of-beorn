using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Services.LotR.Search
{
    public class SearchService : ISearchService
    {
        public SearchService(
            LotRCardRepository cardRepository, IPlanService planService,
            ITranslationService translationService, ITemplateService templateService)
        {
            _cardRepository = cardRepository;
            _planService = planService;
            _translationService = translationService;
            _templateService = templateService;
        }

        private readonly LotRCardRepository _cardRepository;
        private readonly IPlanService _planService;
        private readonly ITranslationService _translationService;
        private readonly ITemplateService _templateService;

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

            var searchLang = model.Lang.GetValueOrDefault(Models.Language.EN);

            Action<LotRCard, Models.Language> translate = null;
            if (searchLang != Models.Language.EN)
            {
                translate = (card, lang) => {
                    var translatedTitle = _translationService.TranslateTitle(lang, card.GetTitle(Models.Language.EN));
                    card.SetTitle(lang, translatedTitle);

                    var translatedFrontText = _templateService.GetFrontText(card.Slug, lang);
                    card.SetText(lang, translatedFrontText);

                    if (!string.IsNullOrEmpty(card.OppositeText))
                    {
                        var translatedBackText = _templateService.GetBackText(card.Slug, lang);
                        card.SetOppositeText(lang, translatedBackText);
                    }
                };
            }

            var all = _cardRepository
                .Cards(model.Lang, translate)
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
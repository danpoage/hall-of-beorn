using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Handlers.LotR
{
    public class TranslationHandler
    {
        public TranslationHandler(IStatService statService, ITemplateService templateService, ITranslationService translationService)
        {
            _statService = statService;
            _templateService = templateService;
            _translationService = translationService;
        }

        private readonly IStatService _statService;
        private readonly ITemplateService _templateService;
        private readonly ITranslationService _translationService;

        private Language defaultLang = Language.EN;

        private IEnumerable<CardEffect> ParseCardEffects(LotRCard card, string text)
        {
            if (string.IsNullOrEmpty(text))
                return Enumerable.Empty<CardEffect>();

            var effects = new List<CardEffect>();

            foreach (var line in text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                effects.Add(CardEffect.Parse(_statService, card, line));
            }

            return effects;
        }

        public void Translate(Language lang, LotRCard card, CardViewModel viewModel)
        {
            var serviceFrontHtml = _templateService.GetFrontHtml(card.Slug, lang);
            var serviceBackHtml = _templateService.GetBackHtml(card.Slug, lang);

            card.HtmlTemplate = !string.IsNullOrEmpty(serviceFrontHtml) ?
                serviceFrontHtml : card.GetFrontHtmlTemplate(lang);

            card.HtmlTemplate2 = !string.IsNullOrEmpty(serviceBackHtml) ?
                serviceBackHtml : card.GetBackHtmlTemplate(lang);

            /*
            if (string.IsNullOrEmpty(card.GetFrontHtmlTemplate(lang)))
            {
                card.HtmlTemplate = _templateService.GetFrontHtml(card.Slug, lang);
            }
            if (string.IsNullOrEmpty(card.GetBackHtmlTemplate(lang)) && !string.IsNullOrEmpty(card.OppositeText))
            {
                card.HtmlTemplate2 = _templateService.GetBackHtml(card.Slug, lang);
            }
            */
            //TODO: Remove effects once the HTML templates are complete

            //TODO: Change this to a series of translation functions
            if (lang != defaultLang)
            {
                viewModel.SetTranslatedTitle(lang, _translationService.TranslateTitle(lang, card.Title));

                viewModel.AddTranslatedTraits(
                    lang,
                    card.Traits.Select(t => _translationService.TranslateTrait(lang, t))
                );

                viewModel.AddTranslatedKeywords(
                    card.Keywords.Select(k =>
                    {
                        var translatedKeyword = _translationService.TranslateKeyword(lang, k);
                        return CardEffect.Parse(_statService, card, translatedKeyword);
                    })
                );
            }

            viewModel.TextEffects.AddRange(ParseCardEffects(card, card.Text));
            viewModel.OppositeTextEffects.AddRange(ParseCardEffects(card, card.OppositeText));

            if (!string.IsNullOrEmpty(card.Shadow))
                viewModel.ShadowEffects.Add(CardEffect.Parse(_statService, card, card.Shadow));

            viewModel.CardTypeName = _translationService.TranslateCardTypeName(lang, viewModel.CardType);
            var x = viewModel.CardTypeName;
        }
    }
}
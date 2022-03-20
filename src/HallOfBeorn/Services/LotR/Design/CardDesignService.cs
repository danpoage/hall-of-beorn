using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Services.LotR.Design
{
    public class CardDesignService
        : ICardDesignService
    {
        public CardDesignService(LotRCardRepository cardRepository, 
            ITemplateService templateService,
            ITranslationService translationService)
        {
            this.cardRepository = cardRepository;
            this.templateService = templateService;
            this.translationService = translationService;
        }

        private readonly LotRCardRepository cardRepository;
        private readonly ITemplateService templateService;
        private readonly ITranslationService translationService;
        
        private Func<string, Language, string> getTitle
        {
            get { return (title, lang) => translationService.TranslateTitle(lang, title); }
        }

        private Func<string, bool, Language, string> getTemplate
        {
            get {
                return (slug, front, lang) => {
                    return front 
                        ? templateService.GetFrontHtml(slug, lang)
                        : templateService.GetBackHtml(slug, lang);
                };
            }
        }

        private IEnumerable<LotRCard> lookupCards(HashSet<string> slugs)
        {
            return cardRepository.Cards()
                .Where(card => slugs.Contains(card.Slug))
                .ToList();
        }

        private IEnumerable<CardDesign> lookupDesigns(IEnumerable<LotRCard> cards, Language lang)
        {
            var designs = new List<CardDesign>();

            var map = new Dictionary<string, List<LotRCard>>();

            foreach (var card in cards)
            {
                var key = CardDesign.GetSlug(card);
                if (!map.ContainsKey(key)) 
                {
                    map[key] = new List<LotRCard>();
                }

                map[key].Add(card);
            }

            foreach (var key in map.Keys)
            {
                designs.Add(new CardDesign(map[key], lang, getTitle, getTemplate));
            }

            return designs;
        }

        public IEnumerable<CardDesign> All(Language lang)
        {
            return lookupDesigns(cardRepository.Cards(), lang);
        }

        public IEnumerable<CardDesign> ForCards(IEnumerable<LotRCard> cards, Language lang)
        {
            var map = new Dictionary<string, CardDesign>();

            var slugs = cards.Select(card => card.Slug);

            foreach (var design in lookupDesigns(cardRepository.Cards(), lang))
            {
                if (map.ContainsKey(design.Slug))
                {
                    continue;
                }

                foreach (var slug in slugs)
                {
                    if (design.IncludesVersion(slug))
                    {
                        map[design.Slug] = design;
                        break;
                    }
                }
            }

            return map.Values;
        }
    }
}
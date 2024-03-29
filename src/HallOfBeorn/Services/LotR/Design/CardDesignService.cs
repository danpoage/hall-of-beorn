﻿using System;
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

        private Dictionary<string, CardDesign> lookupDesigns(
            IEnumerable<LotRCard> cards, Language lang)
        {
            var designsBySlug = new Dictionary<string, CardDesign>();

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
                var design = new CardDesign(map[key], lang, getTitle, getTemplate);
                designsBySlug.Add(design.Slug, design);
            }

            return designsBySlug;
        }

        public CardDesign Lookup(string slug, Language lang)
        {
            var designs = lookupDesigns(cardRepository.Cards(), lang);

            return designs.ContainsKey(slug) ? designs[slug] : null;
        }

        public IEnumerable<CardDesign> Designs(Language lang)
        {
            return lookupDesigns(cardRepository.Cards(), lang).Values;
        }

        public IEnumerable<CardDesign> WithVersions(IEnumerable<LotRCard> cards, Language lang)
        {
            var slugs = cards.Select(card => card.Slug);

            var designs = lookupDesigns(cardRepository.Cards(), lang);

            return designs.Values.Where(design => slugs.Any(slug => design.IncludesVersion(slug))).ToList();
        }
    }
}
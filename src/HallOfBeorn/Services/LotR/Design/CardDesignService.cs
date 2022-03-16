using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR.Templates;

namespace HallOfBeorn.Services.LotR.Design
{
    public class CardDesignService
    {
        public CardDesignService(LotRCardRepository cardRepository, ITemplateService templateService)
        {
            this.cardRepository = cardRepository;
            this.templateService = templateService;
        }

        private readonly LotRCardRepository cardRepository;
        private readonly ITemplateService templateService;
        
        private Func<string, bool, string> lookupTemplate(Language lang)
        {
            return (slug, front) => {
                return front 
                    ? templateService.GetFrontHtml(slug, lang)
                    : templateService.GetBackHtml(slug, lang);
            };
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
                designs.Add(new CardDesign(map[key], lookupTemplate(lang)));
            }

            return designs;
        }

        public IEnumerable<CardDesign> All(Language lang)
        {
            return lookupDesigns(cardRepository.Cards(), lang);
        }

        public IEnumerable<CardDesign> ForCards(IEnumerable<LotRCard> cards, Language lang)
        {
            return lookupDesigns(cards, lang);
        }
    }
}
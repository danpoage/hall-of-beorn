using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Handlers.LotR
{
    public class RingsDbSearchHandler
        : ISearchViewHandler
    {
        public RingsDbSearchHandler(LotRCardRepository cardRepository, IRingsDbService ringsDbService)
        {
            this.cardRepository = cardRepository;
            this.ringsDbService = ringsDbService;
        }

        private readonly LotRCardRepository cardRepository;
        private readonly IRingsDbService ringsDbService;

        private RingsDbDeckViewModel GetDeckViewModel(
            HashSet<string> foundSlugs,
            Models.RingsDb.RingsDbDeckList deck)
        {
            var found = false;

            var description = !string.IsNullOrEmpty(deck.description_md)
                ? new MarkdownSharp.Markdown().Transform(deck.description_md).Replace("/card/", "https://ringsdb.com/card/")
                : "<i>No deck description</i>";

            var deckViewModel = new RingsDbDeckViewModel(deck.id, deck.name, description);
            foreach (var heroId in deck.heroes.Keys)
            {
                var lookupId = heroId;
                //Remove the 99 prefix from Messenger of the King heroes
                if (heroId.StartsWith("99"))
                {
                    lookupId = heroId.Remove(0, 2);
                }

                var heroSlug = ringsDbService.GetSlug(lookupId);
                if (!string.IsNullOrEmpty(heroSlug))
                {
                    var heroCard = cardRepository.FindBySlug(heroSlug); //This may be a unique ally
                    if (heroCard != null && heroCard.IsUnique && heroCard.IsCharacter()) {
                        if (foundSlugs.Contains(heroSlug))
                        {
                            found = true;
                        }

                        deckViewModel.AddHero(heroCard);
                    }
                }
            }

            foreach (var cardId in deck.slots.Keys)
            {
                var cardSlug = ringsDbService.GetSlug(cardId);
                if (!string.IsNullOrEmpty(cardSlug)) 
                {
                    var card = cardRepository.FindBySlug(cardSlug);
                    if (card != null)
                    {
                        if (foundSlugs.Contains(cardSlug))
                        {
                            found = true;
                        }

                        deckViewModel.AddCard(card, deck.slots[cardId]);
                    }
                }
            }

            if (!found)
            {
                return null;
            }

            return deckViewModel;
        }


        public void HandleSearch(SearchViewModel model, UserSettings settings)
        {
            HashSet<string> foundSlugs = new HashSet<string>();
            
            foreach (var card in model.Cards)
            {
                if (!foundSlugs.Contains(card.Slug))
                {
                    foundSlugs.Add(card.Slug);
                }
            }

            model.RingsDbDecks = new List<RingsDbDeckViewModel>();

            var userId = settings.RingsDbUserId.GetValueOrDefault(0);
            if (userId == 0)
            {
                return;
            }

            var decks = ringsDbService.GetUserDecks(userId);

            foreach (var deck in decks)
            {
                var deckViewModel = GetDeckViewModel(foundSlugs, deck);
                if (deckViewModel != null)
                {
                    model.RingsDbDecks.Add(deckViewModel);
                }
            }
        }
    }
}
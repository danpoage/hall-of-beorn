using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.Digital;

namespace HallOfBeorn.Handlers.Digital
{
    public class DetailsHandler
    {
        public DetailsHandler(ICardRepository<DigitalCard> cardRepository, ICharacterRepository characterRepository)
        {
            _cardRepository = cardRepository;
            _characterRepository = characterRepository;
        }

        private readonly ICardRepository<DigitalCard> _cardRepository;
        private readonly ICharacterRepository _characterRepository;

        private Tuple<DigitalCard, string> GetCardAndRedirect(string id)
        {
            DigitalCard card = null;
            var redirectUrl = string.Empty;

            card = _cardRepository.FindBySlug(id);
            if (card != null && card.Slug != id)
            {
                redirectUrl = string.Format("/Digital/Details/{0}", card.Slug);
            }

            if (card == null)
            {
                //TODO: Integrate with Deck-builder site
                //var slug = _ringsDbService.GetSlug(slug);
                //if (!string.IsNullOrEmpty(slug))
                //{
                //    redirectUrl = string.Format("/Digital/Details/{0}", slug);
                //}
                //else
                //{
                redirectUrl = string.Format("/Digital/Search?Query={0}", id.Replace('-', '+'));
                //}
            }

            return new Tuple<DigitalCard, string>(card, redirectUrl);
        }

        private DigitalCardViewModel GetCardViewModel(DigitalCard card)
        {
            return new DigitalCardViewModel(card);
        }

        
        
        private bool isPlayerCard(DigitalCard card)
        {
            switch (card.CardType)
            {
                case DigitalCardType.Hero:
                case DigitalCardType.Ally:
                case DigitalCardType.Attachment:
                case DigitalCardType.Event:
                    return true;
                default:
                    return false;
            }
        }

        public string HandleRedirect(string id)
        {
            var lookup = GetCardAndRedirect(id);
            return lookup.Item2;
        }

        public DigitalCardViewModel HandleDetails(string id)
        {
            var lookup = GetCardAndRedirect(id);
            if (lookup.Item1 == null)
                return null;

            var card = lookup.Item1;
            var model = GetCardViewModel(card);

            var character = _characterRepository.Lookup(card.Title.NormalizeCaseSensitiveString().ToUrlSafeString());
            if (character != null)
            {
                model.CharacterUrl = character.Url;
            }

            //TODO: Integrate with deck-builder here
            if (isPlayerCard(card))
            {
                /*
                var cardId = _ringsDbService.GetCardId(model.Slug);
                if (!string.IsNullOrEmpty(cardId))
                {
                    model.RingsDbUrl = string.Format("http://ringsdb.com/card/{0}", cardId);
                }

                var popularity = _ringsDbService.GetPopularity(model.Slug);
                if (popularity > 0)
                {
                    model.Popularity = popularity;
                }
                */
            }

            return model;
        }
    }
}
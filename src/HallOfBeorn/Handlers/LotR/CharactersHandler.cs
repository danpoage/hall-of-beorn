using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Handlers.LotR
{
    public class CharactersHandler
    {
        public CharactersHandler(LotRCardRepository cardRepository, ICharacterRepository characterRepository)
        {
            _cardRepository = cardRepository;
            _characterRepository = characterRepository;
        }

        private readonly LotRCardRepository _cardRepository;
        private readonly ICharacterRepository _characterRepository;

        public CharacterViewModel HandleCharacters(string id)
        {
            CharacterViewModel model = null;

            if (string.IsNullOrEmpty(id)) {
                model = new CharacterViewModel(Character.Empty());
                model.AddCharacters(_characterRepository.All());
                return model;
            }

            var character = _characterRepository.Lookup(id);

            if (character == null) {
                return null;
            }

            model = new CharacterViewModel(character);

            foreach (var cardSlug in character.Cards) {
                var card = _cardRepository.FindBySlug(cardSlug);
                if (card != null) {
                    model.AddCardLink(card);
                }
            }

            return model;
        }
    }
}
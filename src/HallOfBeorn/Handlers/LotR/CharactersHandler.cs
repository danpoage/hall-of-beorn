using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.Digital;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Handlers.LotR
{
    public class CharactersHandler
    {
        public CharactersHandler(LotRCardRepository lotrCardRepository, DigitalCardRepository digitalCardRepository, 
            ICharacterRepository characterRepository)
        {
            _lotrCardRepository = lotrCardRepository;
            _digitalCardRepository = digitalCardRepository;
            _characterRepository = characterRepository;
        }

        private readonly LotRCardRepository _lotrCardRepository;
        private readonly DigitalCardRepository _digitalCardRepository;
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

            foreach (var slug in character.LotRCards) {
                var card = _lotrCardRepository.FindBySlug(slug);
                model.AddLotRCardLink(card);
            }

            foreach (var slug in character.DigitalCards)
            {
                var card = _digitalCardRepository.FindBySlug(slug);
                model.AddDigitalCardLink(card);
            }

            return model;
        }
    }
}
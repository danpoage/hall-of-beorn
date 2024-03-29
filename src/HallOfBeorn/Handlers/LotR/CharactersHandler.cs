﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Links;

namespace HallOfBeorn.Handlers.LotR
{
    public class CharactersHandler
    {
        public CharactersHandler(LotRCardRepository lotrCardRepository,
            ICharacterRepository characterRepository, ILinkService linkService)
        {
            _lotrCardRepository = lotrCardRepository;
            _characterRepository = characterRepository;
            _linkService = linkService;
        }

        private readonly LotRCardRepository _lotrCardRepository;
        private readonly ICharacterRepository _characterRepository;
        private readonly ILinkService _linkService;

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

            var cardUrls = new HashSet<string>();

            if (!character.DisableAutoLinks)
            {
                var links = _linkService.GetCharacterLinks(character.Name);

                foreach (var link in links)
                {
                    if (cardUrls.Contains(link.Url))
                        continue;

                    cardUrls.Add(link.Url);

                    model.AddLotRCardLink(link);
                }
            }

            foreach (var slug in character.LotRCards)
            {
                var card = _lotrCardRepository.FindBySlug(slug);
                if (card.Slug != slug)
                {
                    continue;
                }

                var link = Link.CreateLotRImageLink(card);

                if (link == null || cardUrls.Contains(link.Url))
                    continue;

                cardUrls.Add(link.Url);

                model.AddLotRCardLink(link);
            }
            
            return model;
        }
    }
}
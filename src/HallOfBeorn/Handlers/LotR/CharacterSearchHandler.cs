using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Design;

namespace HallOfBeorn.Handlers.LotR
{
    public class CharacterSearchHandler
        : ISearchViewHandler
    {
        public CharacterSearchHandler(LotRCardRepository cardRepository, ICharacterRepository characterRepository)
        {
            this.cardRepository = cardRepository;
            this.characterRepository = characterRepository;
        }

        private readonly LotRCardRepository cardRepository;
        private readonly ICharacterRepository characterRepository;

        private void AddRelatedCharacters(IEnumerable<ILink> links, Dictionary<string, CharacterViewModel> charactersByUrl, Dictionary<string, CharacterViewModel> relatedCharactersByUrl)
        {
            foreach (var member in links)
            {
                var memberTitle = member.Title.Contains("(") ? (member.Title.Split('('))[0].Trim() : member.Title;
                var memberCharacter = characterRepository.Lookup(memberTitle.NormalizeCaseSensitiveString().ToUrlSafeString());
                if (memberCharacter != null && !charactersByUrl.ContainsKey(memberCharacter.Url) && !relatedCharactersByUrl.ContainsKey(memberCharacter.Url))
                {
                    relatedCharactersByUrl.Add(memberCharacter.Url, new CharacterViewModel(memberCharacter));

                    foreach (var memberSlug in memberCharacter.LotRCards)
                    {
                        var memberCard = cardRepository.FindBySlug(memberSlug);
                        if (memberCard != null)
                        {
                            if (charactersByUrl.ContainsKey(memberCharacter.Url) || relatedCharactersByUrl.ContainsKey(memberCharacter.Url))
                                continue;

                            var memberLink = Link.CreateLotRImageLink(memberCard);

                            relatedCharactersByUrl[memberCharacter.Url].AddLotRCardLink(memberLink);
                        }
                    }
                }
            }
        }

        public void HandleSearch(SearchViewModel model, UserSettings settings)
        {
            var charactersByUrl = new Dictionary<string, CharacterViewModel>();
            var relatedCharactersByUrl = new Dictionary<string, CharacterViewModel>();

            foreach (var cardViewModel in model.Cards)
            {
                var character = characterRepository.Lookup(cardViewModel.Title.NormalizeCaseSensitiveString().ToUrlSafeString());
                if (character != null)
                {
                    if (!charactersByUrl.ContainsKey(character.Url))
                    {
                        charactersByUrl.Add(character.Url, new CharacterViewModel(character));
                    }

                    var characterLink = Link.CreateLotRImageLink(cardViewModel.Card);
                    charactersByUrl[character.Url].AddLotRCardLink(characterLink);

                    AddRelatedCharacters(character.RelatedCharacters(), charactersByUrl, relatedCharactersByUrl);

                    foreach (var group in character.Groups)
                    {
                        var groupTitle = group.Title.Contains("(") ? (group.Title.Split('('))[0].Trim() : group.Title;
                        var groupCharacter = characterRepository.Lookup(groupTitle.NormalizeCaseSensitiveString().ToUrlSafeString());
                        if (groupCharacter != null)
                        {
                            AddRelatedCharacters(groupCharacter.RelatedCharacters(), charactersByUrl, relatedCharactersByUrl);
                        }
                    }
                }
            }

            model.Characters.AddRange(charactersByUrl.Values.OrderBy(ch => ch.Title));
            foreach (var relatedPair in relatedCharactersByUrl.OrderBy(pair => pair.Value.Title))
            {
                if (charactersByUrl.ContainsKey(relatedPair.Key))
                    continue;

                model.Characters.Add(relatedCharactersByUrl[relatedPair.Key]);
            }            
        }
    }
}
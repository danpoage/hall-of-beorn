using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.Links;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Tags;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Handlers.LotR
{
    public class DetailsHandler
    {
        public DetailsHandler(TranslationHandler translationHandler,
            LotRCardRepository cardRepository,
            ICharacterRepository characterRepository,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService,
            ICategoryService<QuestCategory> questCategoryService,
            ICategoryService<Region> regionService,
            ICategoryService<Archetype> archetypeService,
            IRingsDbService ringsDbService, IStatService statService, 
            ILinkService linkService, INoteService noteService, ITagService tagService,
            ITemplateService templateService,
            IOctgnService octgnService)
        {
            _translationHandler = translationHandler;
            _cardRepository = cardRepository;
            _characterRepository = characterRepository;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _regionService = regionService;
            _archetypeService = archetypeService;
            _ringsDbService = ringsDbService;
            _statService = statService;
            _linkService = linkService;
            _noteService = noteService;
            _tagService = tagService;
            _templateService = templateService;
            _octgnService = octgnService;
        }

        private readonly TranslationHandler _translationHandler;
        private readonly LotRCardRepository _cardRepository;
        private readonly ICharacterRepository _characterRepository;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly ICategoryService<Region> _regionService;
        private readonly ICategoryService<Archetype> _archetypeService;
        private readonly IRingsDbService _ringsDbService;
        private readonly IStatService _statService;
        private readonly ILinkService _linkService;
        private readonly INoteService _noteService;
        private readonly ITagService _tagService;
        private readonly ITemplateService _templateService;
        private readonly IOctgnService _octgnService;
        
        private bool IsId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            if (id.Length != 36)
                return false;

            if (id[8] != '-' || id[13] != '-' || id[18] != '-')
                return false;

            return true;
        }

        private CardViewModel GetCardViewModel(LotRCard card, Language lang)
        {
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
            var getRegions = new Func<string, IEnumerable<Region>>((slug) => _regionService.Categories(slug));
            var getArchetypes = new Func<string, IEnumerable<Archetype>>(slug => _archetypeService.Categories(slug));
            var viewModel = new CardViewModel(
                card, getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, lang);

            viewModel.LinkedCards = GetLinkedCards(card);

            _translationHandler.Translate(lang, card, viewModel);

            return viewModel;
        }

        public List<Link> GetLinkedCards(LotRCard card)
        {
            var links = new List<Link>();

            var children = _ringsDbService.GetLinks(card.Slug);

            foreach (var child in children)
            {
                var childSlug = _ringsDbService.GetSlug(child.Key);
                if (string.IsNullOrWhiteSpace(childSlug))
                    continue;

                var childCard = _cardRepository.FindBySlug(childSlug);
                if (childCard == null)
                    continue;

                var qualifiedTitle = string.Format("{0} ({1})", childCard.Title, childCard.CardSet.Abbreviation);
                links.Add(new Link(LinkType.Hall_of_Beorn_LotR_Detail, childCard, qualifiedTitle)); 
            }

            return links;
        }
        
        private bool isPlayerCard(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                case CardType.Treasure:
                case CardType.Player_Side_Quest:
                case CardType.Contract:
                    return true;
                default:
                    return false;
            }
        }

        private bool hasRingsDbLink(LotRCard card)
        {
            return isPlayerCard(card) || card.CardSubtype == CardSubtype.Boon || card.CardSubtype == CardSubtype.Burden;
        }

        private Tuple<LotRCard, string> GetCardAndRedirect(string id)
        {
            LotRCard card = null;
            var redirectUrl = string.Empty;

            if (IsId(id))
            {
                var slug = _octgnService.GetCardSlug(id);
                if (!string.IsNullOrWhiteSpace(slug))
                {
                    card = _cardRepository.FindBySlug(slug);
                    redirectUrl = string.Format("/LotR/Details/{0}", slug);
                }
            }
            else
            {
                card = _cardRepository.FindBySlug(id);
                if (card != null && card.Slug != id)
                {
                    redirectUrl = string.Format("/LotR/Details/{0}", card.Slug);
                }
            }

            if (card == null)
            {
                var slug = _ringsDbService.GetSlug(id);
                if (!string.IsNullOrEmpty(slug))
                {
                    redirectUrl = string.Format("/LotR/Details/{0}", slug);
                }
                else
                {
                    redirectUrl = string.Format("/LotR/Search?Query={0}", id.Replace('-', '+'));
                }
            }

            return new Tuple<LotRCard, string>(card, redirectUrl);
        }

        public string HandleRedirect(string id)
        {
            var lookup = GetCardAndRedirect(id);
            return lookup.Item2;
        }

        public CardViewModel HandleDetails(string id, Language lang)
        {
            var lookup = GetCardAndRedirect(id);
            if (lookup.Item1 == null)
                return null;

            var card = lookup.Item1;
            var model = GetCardViewModel(card, lang);

            var octgnGuid = _octgnService.GetCardOctgnGuid(card.Slug);
            if (!string.IsNullOrEmpty(octgnGuid))
            {
                model.OctgnGuid = octgnGuid;
            }

            var character = _characterRepository.Lookup(card.Title.NormalizeCaseSensitiveString().ToUrlSafeString());
            if (character != null)
            {
                model.CharacterUrl = character.Url;
            }

            model.LoadNotes(_noteService.Notes(card.Slug));
            model.LoadTags(_tagService.GetTags(card.Slug));
            model.LoadContentLinks(_linkService.GetLinks(card.Slug));

            if (hasRingsDbLink(card))
            {
                var cardId = _ringsDbService.GetCardId(model.Slug);
                if (!string.IsNullOrEmpty(cardId))
                {
                    model.RingsDbUrl = string.Format("http://ringsdb.com/card/{0}", cardId);
                }
            }

            if (isPlayerCard(card))
            {
                var popularity = _ringsDbService.GetPopularity(model.Slug);
                if (popularity > 0)
                {
                    model.Votes = _ringsDbService.GetVotes(model.Slug);
                    model.Popularity = popularity;
                }
            }

            return model;
        }
    }
}
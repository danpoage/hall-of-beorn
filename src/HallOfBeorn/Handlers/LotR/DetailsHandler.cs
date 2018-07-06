using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Tags;
using HallOfBeorn.Services.LotR.Templates;

namespace HallOfBeorn.Handlers.LotR
{
    public class DetailsHandler
    {
        public DetailsHandler(ICardRepository cardRepository,
            ICharacterRepository characterRepository,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService,
            ICategoryService<QuestCategory> questCategoryService,
            IRingsDbService ringsDbService,
            IStatService statService, INoteService noteService, ITagService tagService,
            ITemplateService templateService, IOctgnService octgnService)
        {
            _cardRepository = cardRepository;
            _characterRepository = characterRepository;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _ringsDbService = ringsDbService;
            _statService = statService;
            _noteService = noteService;
            _tagService = tagService;
            _templateService = templateService;
            _octgnService = octgnService;
        }

        private readonly ICardRepository _cardRepository;
        private readonly ICharacterRepository _characterRepository;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly IRingsDbService _ringsDbService;
        private readonly IStatService _statService;
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

        private CardViewModel GetCardViewModel(LotRCard card)
        {
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
            var viewModel = new CardViewModel(card, getPlayerCategories, getEncounterCategories, getQuestCategories);

            if (string.IsNullOrEmpty(card.HtmlTemplate))
            {
                card.HtmlTemplate = _templateService.GetFrontHtml(card.Slug);
            }
            if (string.IsNullOrEmpty(card.HtmlTemplate2) && !string.IsNullOrEmpty(card.OppositeText))
            {
                card.HtmlTemplate2 = _templateService.GetBackHtml(card.Slug);
            }

            //TODO: Remove effects once the HTML templates are complete
            foreach (var keyword in card.Keywords)
                viewModel.KeywordEffects.Add(CardEffect.Parse(_statService, card, keyword));

            viewModel.TextEffects.AddRange(ParseCardEffects(card, card.Text));
            viewModel.OppositeTextEffects.AddRange(ParseCardEffects(card, card.OppositeText));

            if (!string.IsNullOrEmpty(card.Shadow))
                viewModel.ShadowEffects.Add(CardEffect.Parse(_statService, card, card.Shadow));

            return viewModel;
        }

        private IEnumerable<CardEffect> ParseCardEffects(LotRCard card, string text)
        {
            if (string.IsNullOrEmpty(text))
                return Enumerable.Empty<CardEffect>();

            var effects = new List<CardEffect>();

            foreach (var line in text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                effects.Add(CardEffect.Parse(_statService, card, line));
            }

            return effects;
        }

        
        private bool isPlayerCard(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                case CardType.Player_Side_Quest:
                    return true;
                default:
                    return false;
            }
        }

        private Tuple<LotRCard, string> GetCardAndRedirect(string id)
        {
            LotRCard card = null;
            var redirectUrl = string.Empty;

            if (IsId(id))
            {
                card = _cardRepository.Find(id);
                if (card != null)
                {
                    redirectUrl = string.Format("/LotR/Details/{0}", card.Slug);
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

        public CardViewModel HandleDetails(string id)
        {
            var lookup = GetCardAndRedirect(id);
            if (lookup.Item1 == null)
                return null;

            var card = lookup.Item1;
            var model = GetCardViewModel(card);

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

            if (isPlayerCard(card))
            {
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
            }

            return model;
        }
    }
}
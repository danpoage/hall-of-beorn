using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.Links;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;
using HallOfBeorn.Services.LotR.Stats;

namespace HallOfBeorn.Handlers.LotR
{
    public class SearchHandler
    {
        public SearchHandler(LotRCardRepository cardRepository,
            ICharacterRepository characterRepository,
            ISearchService searchService,
            IScenarioService scenarioService,
            ILinkService linkService,
            IStatService statService,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService,
            ICategoryService<Region> regionService,
            IRingsDbService ringsDbService,
            TranslationHandler translationHandler)
        {
            _cardRepository = cardRepository;
            _characterRepository = characterRepository;
            _searchService = searchService;
            _scenarioService = scenarioService;
            _linkService = linkService;
            _statService = statService;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _regionService = regionService;
            _ringsDbService = ringsDbService;
            _translationHandler = translationHandler;
        }

        private readonly LotRCardRepository _cardRepository;
        private readonly ICharacterRepository _characterRepository;
        private readonly ISearchService _searchService;
        private readonly IScenarioService _scenarioService;
        private readonly ILinkService _linkService;
        private readonly IStatService _statService;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly ICategoryService<Region> _regionService;
        private readonly IRingsDbService _ringsDbService;
        private readonly TranslationHandler _translationHandler;
        
        private void InitializeSearch(SearchViewModel model)
        {
            model.Cards = new List<CardViewModel>();
            model.Products = new List<ProductViewModel>();
            model.Characters = new List<CharacterViewModel>();
            model.Links = new List<LinkViewModel>();

            SearchViewModel.Keywords = _statService.Keywords().GetSelectListItems();
            SearchViewModel.Traits = _statService.Traits().GetSelectListItems();
            SearchViewModel.ResourceCosts = _statService.ResourceCosts().GetSelectListItems();
            SearchViewModel.ThreatCosts = _statService.ThreatCosts().GetSelectListItems();
            SearchViewModel.EngagementCosts = _statService.EngagementCosts().GetSelectListItems();
            SearchViewModel.VictoryPointValues = _statService.VictoryPointsValues().GetSelectListItems(new Tuple<string, string>("Victory > 0", "Victory>0"));
            SearchViewModel.AttackStrengthValues = _statService.AttackStrengthValues().GetSelectListItems();
            SearchViewModel.DefenseStrengthValues = _statService.DefenseStrengthValues().GetSelectListItems();
            SearchViewModel.HitPointsValues = _statService.HitPointsValues().GetSelectListItems();
            SearchViewModel.WillpowerStrengthValues = _statService.WillpowerStrengthValues().GetSelectListItems();
            SearchViewModel.ThreatStrengthValues = _statService.ThreatStrengthValues().GetSelectListItems();
            SearchViewModel.QuestPointsValues = _statService.QuestPointsValues().GetSelectListItems();

            SearchViewModel.CardSets = _scenarioService.SetNames().GetExtendedSelectListItems();
            SearchViewModel.Scenarios = _scenarioService.ScenarioTitles().GetSelectListItems();
            SearchViewModel.EncounterSets = _scenarioService.EncounterSetNames().GetSelectListItems();

            SearchViewModel.Categories = _playerCategoryService.CategoryNames().GetSelectListItems();
            SearchViewModel.EncounterCategories = _encounterCategoryService.CategoryNames().GetSelectListItems();
            SearchViewModel.QuestCategories = _questCategoryService.CategoryNames().GetSelectListItems();
            SearchViewModel.Regions = _regionService.CategoryNames().GetSelectListItems();
        }

        private void AddRelatedCharacters(IEnumerable<ILink> links, Dictionary<string, CharacterViewModel> charactersByUrl, Dictionary<string, CharacterViewModel> relatedCharactersByUrl)
        {
            foreach (var member in links)
            {
                var memberTitle = member.Title.Contains("(") ? (member.Title.Split('('))[0].Trim() : member.Title;
                var memberCharacter = _characterRepository.Lookup(memberTitle.NormalizeCaseSensitiveString().ToUrlSafeString());
                if (memberCharacter != null && !charactersByUrl.ContainsKey(memberCharacter.Url) && !relatedCharactersByUrl.ContainsKey(memberCharacter.Url))
                {
                    relatedCharactersByUrl.Add(memberCharacter.Url, new CharacterViewModel(memberCharacter));

                    foreach (var memberSlug in memberCharacter.LotRCards)
                    {
                        var memberCard = _cardRepository.FindBySlug(memberSlug);
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
            InitializeSearch(model);

            var useLang = model.Lang.HasValue ? model.Lang.Value : default(Language);

            foreach (var score in _searchService.Search(model, settings))
            {
                var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
                var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
                var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
                var getRegions = new Func<string, IEnumerable<Region>>((slug) => { return _regionService.Categories(slug); });

                var viewModel = new CardViewModel(score, getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, useLang);
                viewModel.Popularity = _ringsDbService.GetPopularity(viewModel.Slug);
                viewModel.Votes = _ringsDbService.GetVotes(viewModel.Slug);

                _translationHandler.Translate(useLang, score.Card, viewModel);

                model.Cards.Add(viewModel);
            }

            if (model.View.HasValue)
            {
                if (model.View == Models.View.Product)
                {
                    var productsByCode = new Dictionary<string, ProductViewModel>();

                    Func<string, byte> getPopularity = (slug) => {
                        return _ringsDbService.GetPopularity(slug);
                    };

                    var key = string.Empty;
                    foreach (var cardViewModel in model.Cards)
                    {
                        key = cardViewModel.Card.CardSet.Product.Code;
                        if (!productsByCode.ContainsKey(key))
                        {
                            productsByCode[key] = new ProductViewModel(cardViewModel.Card.CardSet.Product, getPopularity);
                        }

                        productsByCode[key].AddCard(cardViewModel);
                    }

                    model.Products.AddRange(productsByCode.Values.OrderBy(prod => prod.Code));
                }
                if (model.View == Models.View.Character)
                {
                    var charactersByUrl = new Dictionary<string, CharacterViewModel>();
                    var relatedCharactersByUrl = new Dictionary<string, CharacterViewModel>();

                    foreach (var cardViewModel in model.Cards)
                    {
                        var character = _characterRepository.Lookup(cardViewModel.Title.NormalizeCaseSensitiveString().ToUrlSafeString());
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
                                var groupCharacter = _characterRepository.Lookup(groupTitle.NormalizeCaseSensitiveString().ToUrlSafeString());
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
                if (model.View == Models.View.Community)
                {
                    var linksByUrl = new Dictionary<string, Tuple<LinkViewModel, double>>();
                    var scenariosByTitle = new Dictionary<string, Tuple<Scenario, double>>();
                    var relevantDecks = new HashSet<string>();

                    foreach (var cardViewModel in model.Cards)
                    {
                        var communityLinks = _linkService.GetLinks(cardViewModel.Card.Slug);
                        foreach (var link in communityLinks)
                        {
                            linksByUrl[link.Url] = new Tuple<LinkViewModel, double>(new LinkViewModel(link), 200);
                        }

                        var associatedScenarios = _scenarioService.AssociatedScenarios(
                            cardViewModel.Card.Slug, cardViewModel.Card.CardType, cardViewModel.Score);

                        foreach (var result in associatedScenarios)
                        {
                            var isRelevant = false;
                            foreach (var link in result.Item1.PlayLinks)
                            {
                                if (link.Item2.Any(deckId => 
                                    _ringsDbService.DeckIncludesCard(deckId, cardViewModel.Slug)))
                                {
                                    foreach (var deckId in link.Item2)
                                        relevantDecks.Add(deckId);

                                    isRelevant = true;
                                    break;
                                }
                            }

                            if (!isRelevant)
                            {
                                continue;
                            }

                            if (!scenariosByTitle.ContainsKey(result.Item1.Title))
                            {
                                scenariosByTitle[result.Item1.Title] = 
                                    new Tuple<Scenario, double>(result.Item1, result.Item2);
                            }
                            else
                            {
                                var existingScore = scenariosByTitle[result.Item1.Title].Item2;
                                scenariosByTitle[result.Item1.Title] = 
                                    new Tuple<Scenario, double>(result.Item1, existingScore + result.Item2);
                            }
                        }
                    }

                    foreach (var result in scenariosByTitle.Values)
                    {
                        foreach (var linkItem in result.Item1.PlayLinks)
                        {
                            var link = linkItem.Item1;
                            var includedDecks = linkItem.Item2;

                            var isRelevant = false;
                            foreach (var deckId in includedDecks)
                            {
                                if (relevantDecks.Contains(deckId))
                                {
                                    isRelevant = true;
                                    break;
                                }
                            }

                            if (!isRelevant)
                            {
                                continue;
                            }

                            if (!linksByUrl.ContainsKey(link.Url))
                            {
                                linksByUrl[link.Url] = 
                                    new Tuple<LinkViewModel, double>(new LinkViewModel(link), result.Item2);
                            }
                            else
                            {
                                var existingLink = linksByUrl[link.Url].Item1;
                                var existingScore = linksByUrl[link.Url].Item2;
                                linksByUrl[link.Url] =
                                    new Tuple<LinkViewModel, double>(existingLink, existingScore + result.Item2);
                            }
                        }
                    }

                    model.Links.AddRange(
                        linksByUrl.Values
                            .OrderByDescending(ln => ln.Item2)
                            .Select(ln => ln.Item1)
                    );
                }
            }
        }

        public object HandleJsonSearch(SearchViewModel model, UserSettings settings)
        {
            HandleSearch(model, settings);

            var cards = new List<SimpleCard>();

            foreach (var cardViewModel in model.Cards)
            {
                cards.Add(new SimpleCard(cardViewModel.Card));
            }

            return cards;
        }
    }
}

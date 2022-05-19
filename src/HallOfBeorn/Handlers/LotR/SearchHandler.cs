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
using HallOfBeorn.Services.LotR.Design;
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
            ICategoryService<Archetype> archetypeService,
            IRingsDbService ringsDbService,
            ICardDesignService cardDesignService,
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
            _archetypeService = archetypeService;
            _ringsDbService = ringsDbService;
            _cardDesignService = cardDesignService;
            _translationHandler = translationHandler;
            _viewHandlers.Add(View.RingsDB, new RingsDbSearchHandler(_cardRepository, _ringsDbService));
            _viewHandlers.Add(View.Card_Design, new CardDesignSearchHandler(_cardDesignService));
            _viewHandlers.Add(View.Product, new ProductSearchHandler(_ringsDbService));
            _viewHandlers.Add(View.Character, new CharacterSearchHandler(_cardRepository, _characterRepository));
            _viewHandlers.Add(View.Community, new CommunitySearchHandler(_linkService, _ringsDbService, _scenarioService));
            _viewHandlers.Add(View.Alt_Art, new CardDesignSearchHandler(_cardDesignService));
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
        private readonly ICategoryService<Archetype> _archetypeService;
        private readonly IRingsDbService _ringsDbService;
        private readonly ICardDesignService _cardDesignService;
        private readonly TranslationHandler _translationHandler;
        private readonly Dictionary<View, ISearchViewHandler> _viewHandlers = new Dictionary<View, ISearchViewHandler>();

        private void InitializeSearch(SearchViewModel model)
        {
            model.Cards = new List<CardViewModel>();
            model.Products = new List<ProductViewModel>();
            model.Characters = new List<CharacterViewModel>();
            model.Links = new List<LinkViewModel>();
            model.CardDesigns = new List<CardDesignViewModel>();

            SearchViewModel.CardTypes = _statService.CardTypes(model.Lang).GetSelectListItems();
            SearchViewModel.Keywords = _statService.Keywords(model.Lang).GetSelectListItems();
            SearchViewModel.Traits = _statService.Traits(model.Lang).GetSelectListItems();
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
            SearchViewModel.Archetypes = _archetypeService.CategoryNames().GetSelectListItems();
            SearchViewModel.Ages = _statService.AgeValues().GetSelectListItems();
            SearchViewModel.Projects = typeof(Project).GetSelectListItems(" ", true, null);
        }

        public void HandleSearch(SearchViewModel model, UserSettings settings)
        {
            InitializeSearch(model);

            var useLang = model.Lang.HasValue && model.Lang != Language.None ? model.Lang.Value : Language.EN;

            foreach (var score in _searchService.Search(model, settings))
            {
                var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
                var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
                var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
                var getRegions = new Func<string, IEnumerable<Region>>((slug) => { return _regionService.Categories(slug); });
                var getArchetypes = new Func<string, IEnumerable<Archetype>>((slug) => { return _archetypeService.Categories(slug); });

                var viewModel = new CardViewModel(score, 
                    getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, useLang);
                viewModel.Popularity = _ringsDbService.GetPopularity(viewModel.Slug);
                viewModel.Votes = _ringsDbService.GetVotes(viewModel.Slug);

                _translationHandler.Translate(useLang, score.Card, viewModel);
                
                model.Cards.Add(viewModel);
            }

            if (model.View.HasValue && _viewHandlers.ContainsKey(model.View.Value))
            {
                _viewHandlers[model.View.Value].HandleSearch(model, settings);
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

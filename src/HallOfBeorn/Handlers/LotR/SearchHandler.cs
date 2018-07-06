using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;
using HallOfBeorn.Services.LotR.Stats;

namespace HallOfBeorn.Handlers.LotR
{
    public class SearchHandler
    {
        public SearchHandler(ISearchService searchService,
            IScenarioService scenarioService,
            IStatService statService,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService,
            IRingsDbService ringsDbService)
        {
            _searchService = searchService;
            _scenarioService = scenarioService;
            _statService = statService;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _ringsDbService = ringsDbService;
        }

        private readonly ISearchService _searchService;
        private readonly IScenarioService _scenarioService;
        private readonly IStatService _statService;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly IRingsDbService _ringsDbService;

        private void InitializeSearch(SearchViewModel model)
        {
            model.Cards = new List<CardViewModel>();
            model.Products = new List<ProductViewModel>();

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
        }

        public void HandleSearch(SearchViewModel model)
        {
            InitializeSearch(model);

            foreach (var score in _searchService.Search(model))
            {
                var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
                var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
                var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });

                var viewModel = new CardViewModel(score, getPlayerCategories, getEncounterCategories, getQuestCategories);
                viewModel.Popularity = _ringsDbService.GetPopularity(viewModel.Slug);
                viewModel.Votes = _ringsDbService.GetVotes(viewModel.Slug);

                model.Cards.Add(viewModel);
            }

            if (model.View.HasValue && model.View == Models.View.Product)
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

                model.Products.AddRange(productsByCode.Values.OrderBy(x => x.Code));
            }
        }

        public object HandleJsonSearch(SearchViewModel model)
        {
            HandleSearch(model);

            var cards = new List<SimpleCard>();

            foreach (var cardViewModel in model.Cards)
            {
                cards.Add(new SimpleCard(cardViewModel.Card));
            }

            return cards;
        }
    }
}

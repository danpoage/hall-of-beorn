using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public class SearchService
    {
        public SearchService(ProductRepository productRepository, CardRepository cardRepository, 
            ScenarioService scenarioService, AdvancedSearchService advancedSearchService,
            CategoryService categoryService, RingsDbService ringsDbService)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            this.scenarioService = scenarioService;
            this.advancedSearchService = advancedSearchService;
            this.ringsDbService = ringsDbService;
            this.categoryService = categoryService;
        }

        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;
        private readonly AdvancedSearchService advancedSearchService;
        private readonly RingsDbService ringsDbService;
        private readonly CategoryService categoryService;

        private IOrderedEnumerable<CardScore> InitialScores()
        {
            return cardRepository
                .Cards()
                .Select(card => new CardScore(card, 1, string.Empty))
                .OrderBy(s => 1);
        }

        public IOrderedEnumerable<CardScore> Search(SearchViewModel model)
        {            
            var builder = new PlanBuilder(model, scenarioService, categoryService, ringsDbService, advancedSearchService);
            
            var scores = builder
                .ToPlan()
                .Execute(InitialScores());

            return scores;
        }
    }
}
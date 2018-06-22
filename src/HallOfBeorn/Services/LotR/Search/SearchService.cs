﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public class SearchService
    {
        public SearchService(ProductRepository productRepository, CardRepository cardRepository, ScenarioService scenarioService, 
            CategoryService categoryService, RingsDbService ringsDbService)
            //AdvancedSearchService advancedSearchService, SearchSortService sortService, RingsDbService ringsDbService, NoteService noteService, CategoryService categoryService)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            this.scenarioService = scenarioService;
            //this.advancedSearchService = advancedSearchService;
            //this.sortService = sortService;
            //this.cards = cardRepository.Cards();
            this.ringsDbService = ringsDbService;
            //this.noteService = noteService;
            this.categoryService = categoryService;
            //this.getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
        }

        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;
        //private readonly AdvancedSearchService advancedSearchService;
        //private readonly SearchSortService sortService;
        //private readonly IOredeEnumerable<LotRCard> cards;
        private readonly RingsDbService ringsDbService;
        //private readonly NoteService noteService;
        private readonly CategoryService categoryService;
        //private readonly Func<string, byte> getPopularity;

        private IOrderedEnumerable<CardScore> InitialScores()
        {
            return cardRepository
                .Cards()
                .Select(card => new CardScore(card, 1, string.Empty))
                .OrderBy(s => 1);
        }

        public IOrderedEnumerable<CardScore> Search(SearchViewModel model)
        {            
            var builder = new PlanBuilder(model, scenarioService, categoryService, ringsDbService);
            
            var scores = builder
                .ToPlan()
                .Execute(InitialScores());

            return scores;
        }
    }
}
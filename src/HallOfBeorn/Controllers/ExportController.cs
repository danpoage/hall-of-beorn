using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;

namespace HallOfBeorn.Controllers
{
    public class ExportController : Controller
    {
        public ExportController()
        {
            productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.ProductRepository];
            cardRepository = (LotRCardRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository];
            scenarioService = (IScenarioService)System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService];
            searchService = (SearchService)System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService];
        }

        private readonly SearchService searchService;
        private readonly ProductRepository productRepository;
        private readonly LotRCardRepository cardRepository;
        private readonly IScenarioService scenarioService;

        public ActionResult Search(SearchViewModel model)
        {
            var result = new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            var cards = new List<SimpleCard>();

            foreach (var score in searchService.Search(model))
            {
                cards.Add(new SimpleCard(score.Card));
            }

            result.Data = cards.Count > 0 ?
                (object)cards
                : "Search returned no results";

            return result;
        }

        public ActionResult PlayerCards()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = cardRepository.OfficialPlayerCards()
                .Select(card => new SimpleCard(card)).ToList();

            return result;
        }

        public ActionResult EncounterCards()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = cardRepository.OfficialEncounterCards()
                .Select(y => new SimpleCard(y)).ToList();

            return result;
        }

        public ActionResult QuestCards()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = cardRepository.OfficialQuestCards()
                .Select(y => new SimpleCard(y)).ToList();

            return result;
        }

        private SimpleScenario GetSimpleScenario(Scenario scenario)
        {
            return new SimpleScenario() 
            { 
                Title = scenario.Title, 
                Slug = scenario.Title.ToSlug(),
                Number = (uint)scenario.Number,
                Product = scenario.ProductName
            };
        }

        private SimpleScenario GetFullScenario(Scenario scenario)
        {
            var simple = GetSimpleScenario(scenario);

            foreach (var quest in scenario.QuestCards.Select(x => x.Quest))
            {
                simple.QuestCards.Add(new SimpleCard(quest));
            }

                    
            foreach (var card in scenario.ScenarioCards)
            {
                simple.ScenarioCards.Add(new SimpleScenarioCard()
                {
                    EncounterSet = card.EncounterSet,
                    Title = card.Title,
                    Slug = card.Slug,
                    NormalQuantity = (uint)card.NormalQuantity,
                    EasyQuantity = (uint)card.EasyQuantity,
                    NightmareQuantity = (uint)card.NightmareQuantity
                });
            }

            return simple;
        }

        public ActionResult Scenarios(string id)
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            if (!string.IsNullOrEmpty(id))
            {
                foreach (var group in scenarioService.ScenarioGroups())
                {
                    foreach (var scenario in group.Scenarios)
                    {
                        if (scenario.Slug == id)
                        {
                            result.Data = GetFullScenario(scenario);
                            return result;
                        }
                    }
                }

                return result;
            }
            
            var simpleScenarios = new List<SimpleScenario>();
            foreach (var group in scenarioService.ScenarioGroups())
            {
                foreach (var scenario in group.Scenarios)
                {
                    var simple = GetSimpleScenario(scenario);

                    simpleScenarios.Add(simple);
                }
            }

            result.Data = simpleScenarios;

            return result;
        }

        private SimpleCardSet GetSimpleCardSet(CardSet cardSet)
        {
            return new SimpleCardSet
            {
                Name = cardSet.Name,
                Abbreviation = cardSet.Abbreviation,
                Slug = cardSet.LookupSlug,
                Cycle = cardSet.Cycle,
                SetType = cardSet.SetType.ToString()
            };
        }

        public ActionResult CardSets(string id)
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            if (string.IsNullOrEmpty(id))
            {
                result.Data = scenarioService.CardSets().Select(cs => GetSimpleCardSet(cs)).ToList();
            }
            else
            {
                foreach (var cardSet in scenarioService.CardSets())
                {
                    if (cardSet.LookupSlug == id || cardSet.Abbreviation == id)
                    {
                        var simple = GetSimpleCardSet(cardSet);
                        simple.Cards = new List<SimpleCard>();
                        foreach (var card in cardSet.Cards.OrderBy(c => c.CardNumber))
                        {
                            simple.Cards.Add(new SimpleCard(card));
                        }
                        result.Data = simple;
                        return result;
                    }
                }
            }

            return result;
        }

        public ActionResult EncounterSets()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = scenarioService.EncounterSetNames();

            return result;
        }
    }
}
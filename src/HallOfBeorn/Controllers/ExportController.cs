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

        public ActionResult Scenarios()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            var scenarios = new List<SimpleScenario>();
            foreach (var group in scenarioService.ScenarioGroups())
            {
                foreach (var item in group.Scenarios)
                {
                    var scenario = new SimpleScenario() { Title = item.Title, Number = (uint)item.Number };

                    foreach (var quest in item.QuestCards.Select(x => x.Quest))
                    {
                        scenario.QuestCards.Add(new SimpleCard(quest));
                    }

                    foreach (var card in item.ScenarioCards)
                    {
                        scenario.ScenarioCards.Add(new SimpleScenarioCard()
                        {
                            EncounterSet = card.EncounterSet,
                            Title = card.Title,
                            NormalQuantity = (uint)card.NormalQuantity,
                            EasyQuantity = (uint)card.EasyQuantity,
                            NightmareQuantity = (uint)card.NightmareQuantity
                        });
                    }

                    scenarios.Add(scenario);
                }
            }

            result.Data = scenarios;

            return result;
        }

        public ActionResult CardSets()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = scenarioService.CardSets().Select(x => new SimpleCardSet { Name = x.Name, Cycle = x.Cycle, SetType = x.SetType.ToString() }).ToList();

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
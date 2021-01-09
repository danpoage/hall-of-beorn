using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
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
            octgnService = (IOctgnService)System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService];
            ringsDbService = GetService<IRingsDbService>(LotRServiceNames.RingsDbService);
        }

        private readonly SearchService searchService;
        private readonly ProductRepository productRepository;
        private readonly LotRCardRepository cardRepository;
        private readonly IScenarioService scenarioService;
        private readonly IOctgnService octgnService;
        private readonly IRingsDbService ringsDbService;

        private static T GetService<T>(string key)
        {
            return (T)System.Web.HttpContext.Current.Application[key];
        }

        public ActionResult Search(SearchViewModel model)
        {
            var result = new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            var cards = new List<SimpleCard>();

            var settings = UserSettings.ReadFromCookies(HttpContext.Request);

            foreach (var score in searchService.Search(model, settings))
            {
                cards.Add(GetSimpleCard(score.Card));
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
                .Select(card => GetSimpleCard(card)).ToList();

            return result;
        }

        public ActionResult EncounterCards()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = cardRepository.OfficialEncounterCards()
                .Select(y => GetSimpleCard(y)).ToList();

            return result;
        }

        public ActionResult QuestCards()
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            result.Data = cardRepository.OfficialQuestCards()
                .Select(y => GetSimpleCard(y)).ToList();

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

        private SimpleCard GetSimpleCard(LotRCard card)
        {
            var simpleCard = new SimpleCard(card);

            simpleCard.OctgnGuid = octgnService.GetCardOctgnGuid(card.Slug);

            simpleCard.RingsDbCardId = ringsDbService.GetCardId(card.Slug);
            simpleCard.RingsDbPopularity = ringsDbService.GetPopularity(card.Slug);
            simpleCard.RingsDbVotes = ringsDbService.GetVotes(card.Slug);

            return simpleCard;
        }

        public ActionResult Cards(string setType)
        {
            try
            {
                Func<string, string> getRingsDbCode = (slug) =>
                    ringsDbService.GetCardId(slug);

                Func<string, string> getOctgnId = (slug) =>
                    octgnService.GetCardOctgnGuid(slug);

                var cards = new List<Models.RingsDb.RingsDbCard>();
                foreach (var cardSet in productRepository.CardSets())
                {
                    if (cardSet.SetType.IsCommunity() && setType != SetType.ALL_SETS.ToString())
                    {
                        continue;
                    }

                    foreach (var card in cardSet.Cards)
                    {
                        cards.Add(
                            Models.RingsDb.RingsDbCard.FromCard(card, getRingsDbCode, getOctgnId));
                    }
                }

                var content = JsonConvert.SerializeObject(cards, 
                    Formatting.None, 
                    new JsonSerializerSettings { 
                        NullValueHandling = NullValueHandling.Ignore
                    });

                return new ContentResult {
                    Content = content,
                    ContentEncoding = System.Text.Encoding.UTF8,
                    ContentType = "application/json",
                };
            }
            catch (Exception ex)
            {
                return new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = ex.Message };
            }
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
                            simple.Cards.Add(GetSimpleCard(card));
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
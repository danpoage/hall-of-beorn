using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Controllers
{
    public class ExportController : Controller
    {
        public ExportController()
        {
            productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[Extensions.ProductRepositoryKey];
            cardRepository = (CardRepository)System.Web.HttpContext.Current.Application[Extensions.CardRepositoryKey];
            scenarioService = (ScenarioService)System.Web.HttpContext.Current.Application[Extensions.ScenarioServiceKey];
            searchService = (SearchService)System.Web.HttpContext.Current.Application[Extensions.SearchServiceKey];
        }

        private SearchService searchService;
        private readonly ProductRepository productRepository;
        private readonly CardRepository cardRepository;
        private readonly ScenarioService scenarioService;

        private bool IsPlayerCard(LotRCard card)
        {
            if (card == null)
            {
                return false;
            }

            switch (card.CardType)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                case CardType.Treasure:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsEncounterCard(LotRCard card)
        {
            if (card == null)
            {
                return false;
            }

            switch (card.CardType)
            {
                case CardType.Encounter:
                case CardType.Encounter_Side_Quest:
                case CardType.Enemy:
                case CardType.Location:
                case CardType.Treachery:
                case CardType.Objective:
                case CardType.Objective_Ally:
                case CardType.Objective_Hero:
                case CardType.Objective_Location:
                case CardType.Ship_Enemy:
                case CardType.Ship_Objective:
                case CardType.Treasure:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsQuestCard(LotRCard card)
        {
            if (card == null)
            {
                return false;
            }

            switch (card.CardType)
            {
                case CardType.Quest:
                case CardType.Campaign:
                case CardType.GenCon_Setup:
                case CardType.Nightmare_Setup:
                case CardType.Scenario:
                    return true;
                default:
                    return false;
            }
        }

        private string ToLabel(byte? stat)
        {
            if (!stat.HasValue)
                return "none";

            switch (stat.Value)
            {
                case 254:
                    return "X";
                case 255:
                    return "-";
                default:
                    return stat.Value.ToString();
            }
        }

        private string DelimitedText(IEnumerable<CardScore> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Title|ThreatCost|ResourceCost|EngagementCost|Willpower|Threat|Attack|Defense|HitPoints|QuestPoints|Traits");

            foreach (var result in results)
            {
                var title = result.Card.Title;
                var threatCost = ToLabel(result.Card.Threat);
                var resourceCost = ToLabel(result.Card.ResourceCost);
                var engagementCost = ToLabel(result.Card.EngagementCost);
                var willpower = ToLabel(result.Card.Willpower);
                var threat = ToLabel(result.Card.Threat);
                var attack = ToLabel(result.Card.Attack);
                var defense = ToLabel(result.Card.Defense);
                var hitPoints = ToLabel(result.Card.HitPoints);
                var questPoints = ToLabel(result.Card.QuestPoints);
                var traits = result.Card.Traits.ToListString<string>();
                sb.AppendLine(string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}", title, threatCost, resourceCost, engagementCost, willpower, threatCost, attack, defense, hitPoints, questPoints, traits));
            }

            return sb.ToString();
        }

        public ActionResult Search(SearchViewModel model)
        {
            var result = new ContentResult();

            result.Content = DelimitedText(searchService.Search(model));

            return result;
        }

        public ActionResult Get(string name)
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            switch (name)
            {
                case "Cards":
                    result.Data = "This method is no longer supported for performance reasons. Use export/PlayerCards, export/EncounterCards or export/QuestCards instead. Thanks for your support!"; //cardRepository.Cards().Where(x => x.CardSet.SetType != SetType.CUSTOM).Select(x => new SimpleCard(x)).ToList();
                    break;
                case "PlayerCards":
                    result.Data = cardRepository.Cards().Where(x => x.CardSet.SetType != SetType.CUSTOM && IsPlayerCard(x)).Select(y => new SimpleCard(y)).ToList();
                    break;
                case "EncounterCards":
                    result.Data = cardRepository.Cards().Where(x => x.CardSet.SetType != SetType.CUSTOM && IsEncounterCard(x)).Select(y => new SimpleCard(y)).ToList();
                    break;
                case "QuestCards":
                    result.Data = cardRepository.Cards().Where(x => x.CardSet.SetType != SetType.CUSTOM && IsQuestCard(x)).Select(y => new SimpleCard(y)).ToList();
                    break;
                case "Scenarios":
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
                    break;
                case "CardSets":
                    result.Data = scenarioService.CardSets().Select(x => new SimpleCardSet { Name = x.Name, Cycle = x.Cycle, SetType = x.SetType.ToString() }).ToList();
                    break;
                case "EncounterSets":
                    result.Data = scenarioService.EncounterSetNames();
                    break;
                default:
                    if (!string.IsNullOrEmpty(name))
                    {
                        result.Data = "Unknown record type: " + name;
                    }
                    else
                    {
                        result.Data = "Undefined record type";
                    }
                    break;
            }

            return result;
        }
    }
}
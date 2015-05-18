using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Simple;
using HallOfBeorn.Services;

namespace HallOfBeorn.Controllers
{
    public class ExportController : Controller
    {
        public ExportController()
        {
            _cardService = new CardService();
        }

        private CardService _cardService;

        private bool IsPlayerCard(Card card)
        {
            switch (card.CardType)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                //case CardType.Boon:
                case CardType.Treasure:
                    return true;
                default:
                    return false;
            }
        }

        private string ToString(IEnumerable<CardScore> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Title;ThreatCost;ResourceCost;EngagementCost;Willpower;Threat;Attack;Defense;HitPoints;Traits");

            var card = default(Card);
            foreach (var result in results)
            {
                card = result.Card;
                var threatCost = card.ThreatCost.HasValue ? card.ThreatCost.Value.ToString() : "n/a";
                //var resourceCost = card.ResourceCost.HasValue ? card.ResourceCost.Value.ToString() : "n/a";
                //sb.AppendLine(string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", card.Title, threatCost, resourceCost, engagementCost, willpower, threatCost, attack, defense, hitPoints, traits);
                sb.AppendLine(string.Format("{0};{1}", card.Title, threatCost));
            }

            return sb.ToString();
        }

        public ActionResult Search(SearchViewModel model)
        {
            var result = new ContentResult();

            result.Content = ToString(_cardService.Search(model));

            return result;
        }

        public ActionResult Get(string name)
        {
            var result = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            switch (name)
            {
                case "Cards":
                    result.Data = _cardService.All().Select(x => new SimpleCard(x)).ToList();
                    break;
                case "PlayerCards":
                    result.Data = _cardService.All().Where(x => IsPlayerCard(x)).Select(y => new SimpleCard(y)).ToList();
                    break;
                case "Scenarios":
                    var scenarios = new List<SimpleScenario>();
                    foreach (var group in _cardService.ScenarioGroups())
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
                    result.Data = _cardService.CardSets().Select(x => new SimpleCardSet { Name = x.Name, Cycle = x.Cycle, SetType = x.SetType.ToString() }).ToList();
                    break;
                case "EncounterSets":
                    result.Data = _cardService.EncounterSetNames;
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


            //return "This is a test of the API: " + name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

using HallOfBeorn.Models;
using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Controllers
{
    public class LotRController : Controller
    {
        public LotRController()
        {
            cardRepository = (CardRepository)System.Web.HttpContext.Current.Application[Extensions.CardRepositoryKey];
            productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[Extensions.ProductRepositoryKey];
            searchService = (SearchService)System.Web.HttpContext.Current.Application[Extensions.SearchServiceKey];
            categoryService = (CategoryService)System.Web.HttpContext.Current.Application[Extensions.CategoryServiceKey];
            noteService = (NoteService)System.Web.HttpContext.Current.Application[Extensions.NoteServiceKey];
            scenarioService = (ScenarioService)System.Web.HttpContext.Current.Application[Extensions.ScenarioServiceKey];
            statService = (StatService)System.Web.HttpContext.Current.Application[Extensions.StatServiceKey];
            octgnService = (OctgnService)System.Web.HttpContext.Current.Application[Extensions.OctgnServiceKey];
            ringsDbService = (RingsDbService)System.Web.HttpContext.Current.Application[Extensions.RingsDbKey];
            templateService = (TemplateService)System.Web.HttpContext.Current.Application[Extensions.TemplateServiceKey];
            tagService = (TagService)System.Web.HttpContext.Current.Application[Extensions.TagServiceKey];
        }

        private readonly SearchService searchService;
        private readonly CardRepository cardRepository;
        private readonly ProductRepository productRepository;
        private readonly CategoryService categoryService;
        private readonly NoteService noteService;
        private readonly ScenarioService scenarioService;
        private readonly StatService statService;
        private readonly OctgnService octgnService;
        private readonly RingsDbService ringsDbService;
        private readonly TemplateService templateService;
        private readonly TagService tagService;

        private void InitializeSearch(SearchViewModel model)
        {
            model.Cards = new List<CardViewModel>();
            model.Products = new List<ProductViewModel>();

            SearchViewModel.Keywords = statService.Keywords().GetSelectListItems();
            SearchViewModel.Traits = statService.Traits().GetSelectListItems();
            SearchViewModel.ResourceCosts = statService.ResourceCosts().GetSelectListItems();
            SearchViewModel.ThreatCosts = statService.ThreatCosts().GetSelectListItems();
            SearchViewModel.EngagementCosts = statService.EngagementCosts().GetSelectListItems();
            SearchViewModel.VictoryPointValues = statService.VictoryPointsValues().GetSelectListItems(new Tuple<string, string>("Victory > 0", "Victory>0"));
            SearchViewModel.AttackStrengthValues = statService.AttackStrengthValues().GetSelectListItems();
            SearchViewModel.DefenseStrengthValues = statService.DefenseStrengthValues().GetSelectListItems();
            SearchViewModel.HitPointsValues = statService.HitPointsValues().GetSelectListItems();
            SearchViewModel.WillpowerStrengthValues = statService.WillpowerStrengthValues().GetSelectListItems();
            SearchViewModel.ThreatStrengthValues = statService.ThreatStrengthValues().GetSelectListItems();
            SearchViewModel.QuestPointsValues = statService.QuestPointsValues().GetSelectListItems();

            SearchViewModel.CardSets = scenarioService.SetNames().GetExtendedSelectListItems();
            SearchViewModel.Scenarios = scenarioService.ScenarioTitles().GetSelectListItems();
            SearchViewModel.EncounterSets = scenarioService.EncounterSetNames().GetSelectListItems();

            SearchViewModel.Categories = categoryService.CategoryNames().GetSelectListItems();
            SearchViewModel.EncounterCategories = categoryService.EncounterCategoryNames().GetSelectListItems();
            SearchViewModel.QuestCategories = categoryService.QuestCategoryNames().GetSelectListItems();
        }

        private IEnumerable<CardEffect> ParseCardEffects(LotRCard card, string text)
        {
            if (string.IsNullOrEmpty(text))
                return Enumerable.Empty<CardEffect>();

            var effects = new List<CardEffect>();

            foreach (var line in text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                effects.Add(CardEffect.Parse(statService, card, line));
            }

            return effects;
        }

        private CardViewModel GetCardViewModel(LotRCard card)
        {
            var viewModel = new CardViewModel(card);

            if (string.IsNullOrEmpty(card.HtmlTemplate))
            {
                card.HtmlTemplate = templateService.GetHtmlTemplate1(card.Slug);
            }
            if (string.IsNullOrEmpty(card.HtmlTemplate2) && !string.IsNullOrEmpty(card.OppositeText))
            {
                card.HtmlTemplate2 = templateService.GetHtmlTemplate2(card.Slug);
            }

            //TODO: Remove effects once the HTML templates are complete
            foreach (var keyword in card.Keywords)
                viewModel.KeywordEffects.Add(CardEffect.Parse(statService, card, keyword));

            viewModel.TextEffects.AddRange(ParseCardEffects(card, card.Text));
            viewModel.OppositeTextEffects.AddRange(ParseCardEffects(card, card.OppositeText));

            if (!string.IsNullOrEmpty(card.Shadow))
                viewModel.ShadowEffects.Add(CardEffect.Parse(statService, card, card.Shadow));

            return viewModel;
        }

        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return Redirect("/LotR/Search");
        }

        /*
        public ActionResult Browse()
        {
            var model = new BrowseViewModel();

            foreach (var productGroup in productRepository.ProductGroups())
            {
                model.ProductGroups.Add(new ProductGroupViewModel(productGroup));
            }

            return View(model);
        }*/

        private Product getProductByIdentifier(string id)
        {
            return productRepository.Products()
                .Where(
                    x => x.Name.ToUrlSafeString() == id || 
                    x.Name.NormalizeCaseSensitiveString().ToUrlSafeString() == id ||
                    x.Code == id
                ).FirstOrDefault();
        }

        public ActionResult Browse(string id)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                if (string.IsNullOrEmpty(id))
                {
                    return Redirect(Url.Action("Browse", "LotR"));
                }
                else
                {
                    return Redirect(Url.Action("Browse", "LotR", new { action = id }));
                }
            }

            var model = new BrowseViewModel();

            Func<string, byte> getPopularity = (slug) =>
            {
                return ringsDbService.GetPopularity(slug);
            };

            if (string.IsNullOrEmpty(id))
            {
                foreach (var productGroup in productRepository.ProductGroups())
                {
                    model.ProductGroups.Add(new ProductGroupViewModel(productGroup, getPopularity));
                }
            }
            else
            {
                var product = getProductByIdentifier(id);
                if (product != null)
                {
                    if (product.Name.NormalizeCaseSensitiveString().ToUrlSafeString() != id)
                    {
                        return Redirect(string.Format("/LotR/Browse/{0}", product.Name.NormalizeCaseSensitiveString().ToUrlSafeString()));
                    }
                    
                    model.Detail = new BrowseProductViewModel(product);
                }
            }

            return View(model);
        }

        public ActionResult Scenarios(string id)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                if (string.IsNullOrEmpty(id))
                {
                    return Redirect(Url.Action("Scenarios", "LotR"));
                }
                else
                {
                    return Redirect(Url.Action("Scenarios", "LotR", new { action = id }));
                }
            }

            ScenarioListViewModel model;
            var lookupCard = new Func<string, LotRCard>((slug) => { return cardRepository.FindBySlug(slug); });


            if (string.IsNullOrEmpty(id))
            {
                model = scenarioService.GetListViewModel();
                /*
                foreach (var scenarioGroup in scenarioService.ScenarioGroups())
                {
                    model.ScenarioGroups.Add(new ScenarioGroupViewModel(scenarioGroup, lookupCard));
                }
                */
            }
            else
            {
                var scenario = scenarioService.GetScenario(id);

                if (scenario == null)
                {
                    return HttpNotFound("I'm sorry Mario, your Princess is in another castle.\n\nNo scenario found matching this URL");
                }
                else 
                {
                    var escapedTitle = scenario.Title.ToUrlSafeString();
                    if (escapedTitle != id)
                    {
                        var redirectURL = "/LotR/Scenarios/" + escapedTitle;
                        return Redirect(redirectURL);
                    }
                }

                model = new ScenarioListViewModel();
                model.Detail = new ScenarioViewModel(scenario, lookupCard);

                return View(model);
            }

            return View(model);
        }

        private enum Mode
        {
            Easy = 0,
            Normal = 1,
            Nightmare = 2
        }

        private class ScenarioTotalData
        {
            public ScenarioTotalData()
            {
                EasyData = new GameTypeData();
                NormalData = new GameTypeData();
                NightmareData = new GameTypeData();
            }

            public GameTypeData EasyData { get; private set; }
            public GameTypeData NormalData { get; private set; }
            public GameTypeData NightmareData { get; private set; }
        }

        private class GameTypeData
        {
            public GameTypeData()
            {
                ScenarioTitles = new List<string>();
                EnemyTotals = new List<float>();
                LocationTotals = new List<float>();
                TreacheryTotals = new List<float>();
                ObjectiveTotals = new List<float>();
                ObjectiveAllyTotals = new List<float>();
                ObjectiveLocationTotals = new List<float>();
                SideQuestTotals = new List<float>();
                ShadowTotals = new List<float>();
                SurgeTotals = new List<float>();
            }

            public List<string> ScenarioTitles { get; private set; }
            public List<float> EnemyTotals { get; private set; }
            public List<float> LocationTotals { get; private set; }
            public List<float> TreacheryTotals { get; private set; }
            public List<float> ObjectiveTotals { get; private set; }
            public List<float> ObjectiveAllyTotals { get; private set; }
            public List<float> ObjectiveLocationTotals { get; private set; }
            public List<float> SideQuestTotals { get; private set; }
            public List<float> ShadowTotals { get; private set; }
            public List<float> SurgeTotals { get; private set; }
        }

        private bool isPlayerCard(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                case CardType.Player_Side_Quest:
                    return true;
                default:
                    return false;
            }
        }

        public JsonResult ScenarioTotals(string id)
        {
            var data = new ScenarioTotalData();
            
            var groupNames = new string[0];
            if (!string.IsNullOrEmpty(id)) {
                groupNames = id.Split(',');
            }

            var filter = (!string.IsNullOrEmpty(id)) ?
                new Func<ScenarioGroup, bool>((g) => { return !string.IsNullOrEmpty(g.Name) && groupNames.Any(y => y == g.Name); }) :
                new Func<ScenarioGroup, bool>((g) => { return !string.IsNullOrEmpty(g.Name); });
            
            foreach (var scenarioGroup in scenarioService.ScenarioGroups().Where(filter))
            {
                foreach (var scenario in scenarioGroup.Scenarios)
                {
                    data.EasyData.ScenarioTitles.Add(scenario.Title);
                    data.NormalData.ScenarioTitles.Add(scenario.Title);
                    data.NightmareData.ScenarioTitles.Add(scenario.Title);

                    var enemyTotals = new Dictionary<int, float>{{ 0, 0f }, {1, 0f }, {2, 0f }};
                    var locationTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var treacheryTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveAllyTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var objectiveLocationTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var sideQuestTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var shadowTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };
                    var surgeTotals = new Dictionary<int, float> { { 0, 0f }, { 1, 0f }, { 2, 0f } };

                    foreach (var card in scenario.ScenarioCards)
                    {
                        switch (card.Card.CardType)
                        {
                            case CardType.Enemy:
                                enemyTotals[0] += card.EasyQuantity;
                                enemyTotals[1] += card.NormalQuantity;
                                enemyTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Location:
                                locationTotals[0] += card.EasyQuantity;
                                locationTotals[1] += card.NormalQuantity;
                                locationTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Treachery:
                                treacheryTotals[0] += card.EasyQuantity;
                                treacheryTotals[1] += card.NormalQuantity;
                                treacheryTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective:
                                objectiveTotals[0] += card.EasyQuantity;
                                objectiveTotals[1] += card.NormalQuantity;
                                objectiveTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Ally:
                                objectiveAllyTotals[0] += card.EasyQuantity;
                                objectiveAllyTotals[1] += card.NormalQuantity;
                                objectiveAllyTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Location:
                                objectiveLocationTotals[0] += card.EasyQuantity;
                                objectiveLocationTotals[1] += card.NormalQuantity;
                                objectiveLocationTotals[2] += card.NightmareQuantity;
                                break;
                            case CardType.Encounter_Side_Quest:
                                sideQuestTotals[0] += card.EasyQuantity;
                                sideQuestTotals[1] += card.NormalQuantity;
                                sideQuestTotals[2] += card.NightmareQuantity;
                                break;
                            default:
                                break;
                        }

                        if (card.Card.Keywords.Any(x => x != null && x == "Surge.") || (!string.IsNullOrEmpty(card.Card.Text) && card.Card.Text.Contains(" surge")))
                        {
                            surgeTotals[0] += card.EasyQuantity;
                            surgeTotals[1] += card.NormalQuantity;
                            surgeTotals[2] += card.NightmareQuantity;
                        }

                        if (!string.IsNullOrEmpty(card.Card.Shadow))
                        {
                            shadowTotals[0] += card.EasyQuantity;
                            shadowTotals[1] += card.NormalQuantity;
                            shadowTotals[2] += card.NightmareQuantity;
                        }
                    }

                    data.EasyData.EnemyTotals.Add(enemyTotals[0]);
                    data.EasyData.LocationTotals.Add(locationTotals[0]);
                    data.EasyData.TreacheryTotals.Add(treacheryTotals[0]);
                    data.EasyData.ObjectiveTotals.Add(objectiveTotals[0]);
                    data.EasyData.ObjectiveAllyTotals.Add(objectiveAllyTotals[0]);
                    data.EasyData.ObjectiveLocationTotals.Add(objectiveLocationTotals[0]);
                    data.EasyData.SideQuestTotals.Add(sideQuestTotals[0]);
                    data.EasyData.ShadowTotals.Add(shadowTotals[0]);
                    data.EasyData.SurgeTotals.Add(surgeTotals[0]);

                    data.NormalData.EnemyTotals.Add(enemyTotals[1]);
                    data.NormalData.LocationTotals.Add(locationTotals[1]);
                    data.NormalData.TreacheryTotals.Add(treacheryTotals[1]);
                    data.NormalData.ObjectiveTotals.Add(objectiveTotals[1]);
                    data.NormalData.ObjectiveAllyTotals.Add(objectiveAllyTotals[1]);
                    data.NormalData.ObjectiveLocationTotals.Add(objectiveLocationTotals[1]);
                    data.NormalData.SideQuestTotals.Add(sideQuestTotals[1]);
                    data.NormalData.ShadowTotals.Add(shadowTotals[1]);
                    data.NormalData.SurgeTotals.Add(surgeTotals[1]);

                    data.NightmareData.EnemyTotals.Add(enemyTotals[2]);
                    data.NightmareData.LocationTotals.Add(locationTotals[2]);
                    data.NightmareData.TreacheryTotals.Add(treacheryTotals[2]);
                    data.NightmareData.ObjectiveTotals.Add(objectiveTotals[2]);
                    data.NightmareData.ObjectiveAllyTotals.Add(objectiveAllyTotals[2]);
                    data.NightmareData.ObjectiveLocationTotals.Add(objectiveLocationTotals[2]);
                    data.NightmareData.SideQuestTotals.Add(sideQuestTotals[2]);
                    data.NightmareData.ShadowTotals.Add(shadowTotals[2]);
                    data.NightmareData.SurgeTotals.Add(surgeTotals[2]);
                    
                }
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ScenarioDetails(string id)
        {
            try
            {
                var details = new Dictionary<string, object>();
                
                var scenario = scenarioService.GetScenario(id);
                if (scenario != null)
                {
                    details["title"] = scenario.Title;

                    var cardCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var enemyCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var locationCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var treacheryCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveAllyCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var objectiveLocationCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var surgeCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var shadowCounts = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var encounterSideQuestCounts = new Dictionary<int, int> { { 0, 0 }, { 1, 0 }, { 2, 0 } };
                    var hasEasy = false;
                    var hasNightmare = false;

                    foreach (var card in scenario.ScenarioCards)
                    {
                        cardCounts[0] += card.EasyQuantity;
                        cardCounts[1] += card.NormalQuantity;
                        cardCounts[2] += card.NightmareQuantity;

                        if (cardCounts[0] != cardCounts[1])
                        {
                            hasEasy = true;
                        }

                        if (card.Card.Keywords.Any(x => x == "Surge.") || card.Card.Text.Contains(" surge"))
                        {
                            surgeCounts[0] += card.EasyQuantity;
                            surgeCounts[1] += card.NormalQuantity;
                            surgeCounts[2] += card.NightmareQuantity;
                        }
                        if (!string.IsNullOrEmpty(card.Card.Shadow))
                        {
                            shadowCounts[0] += card.EasyQuantity;
                            shadowCounts[1] += card.NormalQuantity;
                            shadowCounts[2] += card.NightmareQuantity;
                        }

                        if (card.Card.CardSet.SetType == SetType.Nightmare_Expansion)
                        {
                            hasNightmare = true;
                        }

                        switch (card.Card.CardType)
                        {
                            case CardType.Enemy:
                                enemyCounts[0] += card.EasyQuantity;
                                enemyCounts[1] += card.NormalQuantity;
                                enemyCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Location:
                                locationCounts[0] += card.EasyQuantity;
                                locationCounts[1] += card.NormalQuantity;
                                locationCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Treachery:
                                treacheryCounts[0] += card.EasyQuantity;
                                treacheryCounts[1] += card.NormalQuantity;
                                treacheryCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective:
                                objectiveCounts[0] += card.EasyQuantity;
                                objectiveCounts[1] += card.NormalQuantity;
                                objectiveCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Ally:
                                objectiveAllyCounts[0] += card.EasyQuantity;
                                objectiveAllyCounts[1] += card.NormalQuantity;
                                objectiveAllyCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Objective_Location:
                                objectiveLocationCounts[0] += card.EasyQuantity;
                                objectiveLocationCounts[1] += card.NormalQuantity;
                                objectiveLocationCounts[2] += card.NightmareQuantity;
                                break;
                            case CardType.Encounter_Side_Quest:
                                encounterSideQuestCounts[0] += card.EasyQuantity;
                                encounterSideQuestCounts[1] += card.NormalQuantity;
                                encounterSideQuestCounts[2] += card.NightmareQuantity;
                                break;
                        }
                    }

                    details["HasEasy"] = hasEasy;
                    details["HasNightmare"] = hasNightmare;

                    for (int i = 0; i < 3; i++)
                    {
                        var mode = (Mode)i;
                        var prefix = mode.ToString();

                        details[prefix + "Cards"] = cardCounts[i];
                        details[prefix + "Enemies"] = enemyCounts[i];
                        details[prefix + "EnemyPercentage"] = ((float)enemyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Locations"] = locationCounts[i];
                        details[prefix + "LocationPercentage"] = ((float)enemyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Treacheries"] = treacheryCounts[i];
                        details[prefix + "TreacheryPercentage"] = ((float)treacheryCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Shadows"] = shadowCounts[i];
                        details[prefix + "ShadowPercentage"] = ((float)shadowCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "Objectives"] = objectiveCounts[i];
                        details[prefix + "ObjectivePercentage"] = ((float)objectiveCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectives"] = (objectiveCounts[i] > 0);
                        details[prefix + "ObjectiveAllies"] = objectiveAllyCounts[i];
                        details[prefix + "ObjectiveAllyPercentage"] = ((float)objectiveAllyCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectiveAllies"] = (objectiveAllyCounts[i] > 0);
                        details[prefix + "ObjectiveLocations"] = objectiveLocationCounts[i];
                        details[prefix + "ObjectiveLocationPercentage"] = ((float)objectiveLocationCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasObjectiveLocations"] = (objectiveLocationCounts[i] > 0);
                        details[prefix + "Surges"] = surgeCounts[i];
                        details[prefix + "SurgePercentage"] = ((float)surgeCounts[i] / (float)cardCounts[i]); //*100;
                        details[prefix + "HasSurge"] = (surgeCounts[i] > 0);
                        details[prefix + "EncounterSideQuests"] = encounterSideQuestCounts[i];
                        details[prefix + "EncounterSideQuestPercentage"] = ((float)encounterSideQuestCounts[i] / (float)cardCounts[i]);
                        details[prefix + "HasEncounterSideQuests"] = (encounterSideQuestCounts[i] > 0);
                    }
                }

                return Json(details, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Search(SearchViewModel model)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                return Redirect(Url.Action("Search", model));
            }

            InitializeSearch(model);

            foreach (var score in searchService.Search(model))
            {
                var viewModel = new CardViewModel(score);
                viewModel.Popularity = ringsDbService.GetPopularity(viewModel.Slug);

                model.Cards.Add(viewModel);
            }

            if (model.View.HasValue && model.View == Models.View.Product)
            {
                var productsByCode = new Dictionary<string, ProductViewModel>();

                Func<string, byte> getPopularity = (slug) => {
                    return ringsDbService.GetPopularity(slug);
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

            return View(model);
        }

        public JsonResult SearchJson(SearchViewModel model)
        {
            Search(model);

            var data = new List<SimpleCard>();

            foreach (var cardViewModel in model.Cards)
            {
                data.Add(new SimpleCard(cardViewModel.Card));
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(SearchViewModel model)
        {
            if (string.IsNullOrEmpty(model.CardSet) || model.CardSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.CardSet = null;
            }
            if (string.IsNullOrEmpty(model.EncounterSet) || model.EncounterSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterSet = null;
            }
            if (string.IsNullOrEmpty(model.Scenario) || model.Scenario == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Scenario = null;
            }
            if (string.IsNullOrEmpty(model.Quest) || model.Quest == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Quest = null;
            }
            if (model.CardType.HasValue && model.CardType.Value == Models.LotR.CardType.None)
            {
                model.CardType = null;
            }
            if (string.IsNullOrEmpty(model.CardSubtype) || model.CardSubtype == SearchViewModel.DEFAULT_FILTER_VALUE || model.CardSubtype == "None")
            {
                model.CardSubtype = null;
            }
            if (model.SetType.HasValue && model.SetType.Value == Models.SetType.None)
            {
                model.SetType = null;
            }
            if (model.Sort.HasValue && model.Sort.Value == Models.LotR.Sort.None)
            {
                model.Sort = null;
            }
            if (model.View.HasValue && model.View.Value == Models.View.None)
            {
                model.View = null;
            }
            if (model.DeckType.HasValue && model.DeckType.Value == Models.DeckType.None)
            {
                model.DeckType = null;
            }
            if (string.IsNullOrEmpty(model.Trait) || model.Trait == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Trait = null;
            }
            if (string.IsNullOrEmpty(model.Keyword) || model.Keyword == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Keyword = null;
            }
            if (string.IsNullOrEmpty(model.Artist) || model.Artist == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Artist = null;
            }
            if (model.Sphere.HasValue && model.Sphere.Value == Models.LotR.Sphere.None)
            {
                model.Sphere = null;
            }
            if (string.IsNullOrEmpty(model.Category) || model.Category == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Category = null;
            }
            if (string.IsNullOrEmpty(model.EncounterCategory) || model.EncounterCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterCategory = null;
            }
            if (string.IsNullOrEmpty(model.QuestCategory) || model.QuestCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.QuestCategory = null;
            }
            if (string.IsNullOrEmpty(model.VictoryPoints) || model.VictoryPoints == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.VictoryPoints = null;
            }

            if (model.IsUnique.HasValue && model.IsUnique.Value == Uniqueness.Any)
            {
                model.IsUnique = null;
            }
            if (model.HasShadow.HasValue && model.HasShadow.Value == HasShadow.Any)
            {
                model.HasShadow = null;
            }

            if (model.ThreatCostOperator.HasValue && model.ThreatCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.ThreatCost) || model.ThreatCost == "Any"))
            {
                model.ThreatCost = null;
                model.ThreatCostOperator = null;
            }
            if (model.CostOperator.HasValue && model.CostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.Cost) || model.Cost == "Any"))
            {
                model.Cost = null;
                model.CostOperator = null;
            }
            if (model.EngagementCostOperator.HasValue && model.EngagementCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.EngagementCost) || model.EngagementCost == "Any"))
            {
                model.EngagementCost = null;
                model.EngagementCostOperator = null;
            }
            if (model.AttackOp.HasValue && model.AttackOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Attack) || model.Attack == "Any"))
            {
                model.Attack = null;
                model.AttackOp = null;
            }
            if (model.DefenseOp.HasValue && model.DefenseOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Defense) || model.Defense == "Any"))
            {
                model.Defense = null;
                model.DefenseOp = null;
            }
            if (model.WillpowerOp.HasValue && model.WillpowerOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Willpower) || model.Willpower == "Any"))
            {
                model.Willpower = null;
                model.WillpowerOp = null;
            }
            if (model.ThreatOp.HasValue && model.ThreatOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Threat) || model.Threat == "Any"))
            {
                model.Threat = null;
                model.ThreatOp = null;
            }
            if (model.HitPointsOp.HasValue && model.HitPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.HitPoints) || model.HitPoints == "Any"))
            {
                model.HitPoints = null;
                model.HitPointsOp = null;
            }
            if (model.QuestPointsOp.HasValue && model.QuestPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.QuestPoints) || model.QuestPoints == "Any"))
            {
                model.QuestPoints = null;
                model.QuestPointsOp = null;
            }
            if (model.PopularityOp.HasValue && model.PopularityOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Popularity) || model.Popularity == "Any" || model.Popularity == "-1"))
            {
                model.Popularity = null;
                model.PopularityOp = null;
            }
            if (model.Errata.HasValue && model.Errata.Value == ErrataVersion.Any)
            {
                model.Errata = null;
            }

            if (model.MEC01.HasValue && !model.MEC01.Value)
            {
                model.MEC01 = null;
            }
            if (model.MEC02.HasValue && !model.MEC02.Value)
            {
                model.MEC02 = null;
            }
            if (model.MEC03.HasValue && !model.MEC03.Value)
            {
                model.MEC03 = null;
            }
            if (model.MEC04.HasValue && !model.MEC04.Value)
            {
                model.MEC04 = null;
            }
            if (model.MEC05.HasValue && !model.MEC05.Value)
            {
                model.MEC05 = null;
            }
            if (model.MEC06.HasValue && !model.MEC06.Value)
            {
                model.MEC06 = null;
            }
            if (model.MEC07.HasValue && !model.MEC07.Value)
            {
                model.MEC07 = null;
            }

            if (model.MEC08.HasValue && !model.MEC08.Value)
            {
                model.MEC08 = null;
            }
            if (model.MEC09.HasValue && !model.MEC09.Value)
            {
                model.MEC09 = null;
            }
            if (model.MEC10.HasValue && !model.MEC10.Value)
            {
                model.MEC10 = null;
            }
            if (model.MEC11.HasValue && !model.MEC11.Value)
            {
                model.MEC11 = null;
            }
            if (model.MEC12.HasValue && !model.MEC12.Value)
            {
                model.MEC12 = null;
            }
            if (model.MEC13.HasValue && !model.MEC13.Value)
            {
                model.MEC13 = null;
            }
            if (model.MEC14.HasValue && !model.MEC14.Value)
            {
                model.MEC14 = null;
            }

            if (model.MEC17.HasValue && !model.MEC17.Value)
            {
                model.MEC17 = null;
            }

            if (model.MEC18.HasValue && !model.MEC18.Value)
            {
                model.MEC18 = null;
            }
            if (model.MEC19.HasValue && !model.MEC19.Value)
            {
                model.MEC19 = null;
            }
            if (model.MEC20.HasValue && !model.MEC20.Value)
            {
                model.MEC20 = null;
            }
            if (model.MEC21.HasValue && !model.MEC21.Value)
            {
                model.MEC21 = null;
            }
            if (model.MEC22.HasValue && !model.MEC22.Value)
            {
                model.MEC22 = null;
            }
            if (model.MEC23.HasValue && !model.MEC23.Value)
            {
                model.MEC23 = null;
            }

            if (model.MEC25.HasValue && !model.MEC25.Value)
            {
                model.MEC25 = null;
            }
            if (model.MEC26.HasValue && !model.MEC26.Value)
            {
                model.MEC26 = null;
            }
            if (model.MEC27.HasValue && !model.MEC27.Value)
            {
                model.MEC27 = null;
            }
            if (model.MEC28.HasValue && !model.MEC28.Value)
            {
                model.MEC28 = null;
            }
            if (model.MEC29.HasValue && !model.MEC29.Value)
            {
                model.MEC29 = null;
            }
            if (model.MEC30.HasValue && !model.MEC30.Value)
            {
                model.MEC30 = null;
            }
            if (model.MEC31.HasValue && !model.MEC31.Value)
            {
                model.MEC31 = null;
            }

            if (model.MEC38.HasValue && !model.MEC38.Value)
            {
                model.MEC38 = null;
            }
            if (model.MEC39.HasValue && !model.MEC39.Value)
            {
                model.MEC39 = null;
            }
            if (model.MEC40.HasValue && !model.MEC40.Value)
            {
                model.MEC40 = null;
            }
            if (model.MEC41.HasValue && !model.MEC41.Value)
            {
                model.MEC41 = null;
            }
            if (model.MEC42.HasValue && !model.MEC42.Value)
            {
                model.MEC42 = null;
            }
            if (model.MEC43.HasValue && !model.MEC43.Value)
            {
                model.MEC43 = null;
            }
            if (model.MEC44.HasValue && !model.MEC44.Value)
            {
                model.MEC44 = null;
            }

            if (model.MEC47.HasValue && !model.MEC47.Value)
            {
                model.MEC47 = null;
            }

            if (model.MEC48.HasValue && !model.MEC48.Value)
            {
                model.MEC48 = null;
            }
            if (model.MEC49.HasValue && !model.MEC49.Value)
            {
                model.MEC49 = null;
            }
            if (model.MEC50.HasValue && !model.MEC50.Value)
            {
                model.MEC50 = null;
            }
            if (model.MEC51.HasValue && !model.MEC51.Value)
            {
                model.MEC51 = null;
            }
            if (model.MEC52.HasValue && !model.MEC52.Value)
            {
                model.MEC52 = null;
            }
            if (model.MEC53.HasValue && !model.MEC53.Value)
            {
                model.MEC53 = null;
            }

            if (model.MEC16.HasValue && !model.MEC16.Value)
            {
                model.MEC16 = null;
            }
            if (model.MEC24.HasValue && !model.MEC24.Value)
            {
                model.MEC24 = null;
            }

            if (model.MEC32.HasValue && !model.MEC32.Value)
            {
                model.MEC32 = null;
            }
            if (model.MEC34.HasValue && !model.MEC34.Value)
            {
                model.MEC34 = null;
            }
            if (model.MEC45.HasValue && !model.MEC45.Value)
            {
                model.MEC45 = null;
            }
            if (model.MEC46.HasValue && !model.MEC46.Value)
            {
                model.MEC46 = null;
            }
            if (model.MEC54.HasValue && !model.MEC54.Value)
            {
                model.MEC54 = null;
            }

            if (model.FA01.HasValue && !model.FA01.Value)
            {
                model.FA01 = null;
            }
            if (model.FA02.HasValue && !model.FA02.Value)
            {
                model.FA02 = null;
            }
            if (model.FA03.HasValue && !model.FA03.Value)
            {
                model.FA03 = null;
            }

            return RedirectToAction("Search", model);
        }

        private bool IsId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            if (id.Length != 36)
                return false;

            if (id[8] != '-' || id[13] != '-' || id[18] != '-')
                return false;

            return true;
        }

        public ActionResult Details(string id)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                return Redirect(Url.Action("Details", new { action = id }));
            }

            CardViewModel model= null;

            LotRCard card = null;
            var redirectURL = string.Empty;

            if (IsId(id))
            {
                card = cardRepository.Find(id);
                if (card != null)
                {
                    redirectURL = string.Format("/LotR/Details/{0}", card.Slug);
                }
            }
            else
            {
                card = cardRepository.FindBySlug(id);
                if (card != null && card.Slug != id)
                {
                    redirectURL = string.Format("/LotR/Details/{0}", card.Slug);
                }
            }

            if (card == null)
            {
                var slug = ringsDbService.GetSlug(id);
                if (!string.IsNullOrEmpty(slug))
                {
                    redirectURL = string.Format("/LotR/Details/{0}", slug);
                }
                else
                {
                    redirectURL = string.Format("/LotR/Search?Query={0}", id.Replace('-', '+'));
                }
            }

            if (!string.IsNullOrEmpty(redirectURL))
            {
                return Redirect(redirectURL);
            }
            else
            {
                model = GetCardViewModel(card);

                var octgnGuid = octgnService.GetCardOctgnGuid(card.Slug);
                if (!string.IsNullOrEmpty(octgnGuid))
                {
                    model.OctgnGuid = octgnGuid;
                }

                model.LoadNotes(noteService.Notes(card.Slug));
                model.LoadTags(tagService.GetTags(card.Slug));

                if (isPlayerCard(card))
                {
                    var cardId = ringsDbService.GetCardId(model.Slug);
                    if (!string.IsNullOrEmpty(cardId))
                    {
                        model.RingsDbUrl = string.Format("http://ringsdb.com/card/{0}", cardId);
                    }

                    var popularity = ringsDbService.GetPopularity(model.Slug);
                    if (popularity > 0)
                    {
                        model.Popularity = popularity;
                    }
                }
            }   

            return View(model);
        }

        private LotRCard getByOctgnGuid(string octgnGuid)
        {
            var slug = octgnService.GetCardSlug(octgnGuid);
            if (slug == null)
            {
                return null;
            }

            return cardRepository.FindBySlug(slug);
        }

        private void AddWithQuantity(StringBuilder xml, string guid, byte quantity)
        {
            var card = getByOctgnGuid(guid);
            if (card == null)
            {
                return;
            }

            xml.AppendFormat("    <card qty=\"{0}\" id=\"{1}\">{2}</card>", quantity, guid, card.Title);
        }

        private void AddHeroes(StringBuilder xml, string heroes)
        {
            xml.Append("  <section name=\"Hero\" shared=\"False\">");
            foreach (var guid in heroes.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 1);
            }
            xml.Append("  </section>");
        }

        private void AddAllies(StringBuilder xml, string allies1, string allies2, string allies3)
        {
            xml.Append("  <section name=\"Ally\" shared=\"False\">");            
            foreach (var guid in allies1.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 1);
            }
            foreach (var guid in allies2.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 2);
            }
            foreach (var guid in allies3.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 3);
            }
            xml.Append("  </section>");
        }

        private void AddAttachments(StringBuilder xml, string attachments1, string attachments2, string attachments3)
        {
            xml.Append("  <section name=\"Attachment\" shared=\"False\">");
            foreach (var guid in attachments1.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 1);
            }
            foreach (var guid in attachments2.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 2);
            }
            foreach (var guid in attachments3.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 3);
            }
            xml.Append("  </section>");
        }

        private void AddEvents(StringBuilder xml, string events1, string events2, string events3)
        {
            xml.Append("  <section name=\"Event\" shared=\"False\">");
            foreach (var guid in events1.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 1);
            }
            foreach (var guid in events2.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 2);
            }
            foreach (var guid in events3.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 3);
            }
            xml.Append("  </section>");
        }

        private void AddSideQuests(StringBuilder xml, string sideQuests)
        {
            xml.Append("  <section name=\"Side Quest\" shared=\"False\">");
            foreach (var guid in sideQuests.SafeSplit(','))
            {
                AddWithQuantity(xml, guid, 1);
            }
            xml.Append("  </section>");
        }

        public FileContentResult SaveOctgnDeck(string name, string heroes, string allies1, string allies2, string allies3, string attachments1, string attachments2, string attachments3, string events1, string events2, string events3, string sideQuests)
        {
            var xml = new StringBuilder();
            xml.Append("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>");
            xml.Append("<deck game=\"a21af4e8-be4b-4cda-a6b6-534f9717391f\" sleeveid=\"0\">");

            AddHeroes(xml, heroes);
            AddAllies(xml, allies1, allies2, allies3);
            AddAttachments(xml, attachments1, attachments2, attachments3);
            AddEvents(xml, events1, events2, events3);
            AddSideQuests(xml, sideQuests);

            xml.Append("  <section name=\"Sideboard\" shared=\"False\" />");
            xml.Append("  <section name=\"Quest\" shared=\"True\" />");
            xml.Append("  <section name=\"Encounter\" shared=\"True\" />");
            xml.Append("  <section name=\"Special\" shared=\"True\" />");
            xml.Append("  <section name=\"Setup\" shared=\"True\" />");
            xml.Append("  <notes><![CDATA[]]></notes>");

            xml.Append("</deck>");

            var result = new FileContentResult(xml.ToString().ToByteArray(), System.Net.Mime.MediaTypeNames.Text.Xml);
            result.FileDownloadName = string.Format("{0}.o8d", name);

            return result;
        }

        /*
        public ActionResult OctgnDeck(Deck deck)
        {
            foreach (var slug in deck.Cards)
            {
                var cardGuid = octgnService.GetCardOctgnGuid(slug);
                if (!string.IsNullOrEmpty(cardGuid))
                {
                    deck.OctgnCards.Add(cardGuid);
                }
            }

            return View(deck);
        }

        private List<DeckItemViewModel> getDeckItems(IEnumerable<string> guids)
        {
            var items = new List<DeckItemViewModel>();

            foreach (var guid in guids)
            {
                var slug = octgnService.GetCardSlug(guid);
                if (!string.IsNullOrEmpty(slug))
                {
                    var card = cardRepository.FindBySlug(slug);
                    if (card != null)
                    {
                        var viewModel = new CardViewModel(card);
                        viewModel.OctgnGuid = guid;
                        items.Add(new DeckItemViewModel(viewModel));
                    }
                }
            }

            return items;
        }*/

        public JsonResult TopDecks(string slug)
        {
            try
            {
                var service = new RingsDbService(this.cardRepository);

                var cardId = service.GetCardId(slug);

                var decks = new List<RingsDbDeck>();

                if (!string.IsNullOrEmpty(cardId) && uint.Parse(cardId) > 0)
                {
                    using (var client = new System.Net.Http.HttpClient())
                    {
                        var url = "http://ringsdb.com/api/public/decklists/top_by_card/" + cardId + ".json";
                        var response = client.GetAsync(url).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = response.Content;
                            string responseString = responseContent.ReadAsStringAsync().Result;

                            decks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RingsDbDeck>>(responseString);

                            //Normalize the URL in each deck
                            foreach (var deck in decks)
                            {
                                deck.url = "http://ringsdb.com" + deck.url;
                            }
                        }
                    }
                }

                return Json(decks, JsonRequestBehavior.AllowGet);
            } catch (Exception)
            {
                return Json(string.Empty, JsonRequestBehavior.AllowGet);
            }
        }

        /*
        public JsonResult DeckItems(string guidList)
        {
            var guids = guidList.SafeSplit(',');
            
            var items = getDeckItems(guids);

            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeckItemsByShortSlugs(string shortSlugList, string type)
        {
            var shortSlugs = shortSlugList.SafeSplit(',');
            var guids = new List<string>();

            var countsByGuid = new Dictionary<string, byte>();

            foreach (var shortSlug in shortSlugs)
            {
                var octgnSlug = shortSlug;

                if (string.IsNullOrEmpty(shortSlug))
                {
                    continue;
                }

                byte count = 1;
                if (shortSlug.Contains('_'))
                {
                    var parts = shortSlug.SafeSplit('_');
                    if (parts.Length == 2)
                    {
                        octgnSlug = parts[0];

                        byte testCount = 0;
                        if (byte.TryParse(parts[1], out testCount))
                        {
                            count = (byte)testCount;
                        }
                    }
                }

                var octgnGuid = octgnService.GetCardOctgnGuidByOctgnSlug(octgnSlug, type);
                if (!string.IsNullOrEmpty(octgnGuid))
                {
                    countsByGuid[octgnGuid] = count;
                    guids.Add(octgnGuid);
                }
            }

            var items = getDeckItems(guids);

            foreach (var item in items)
            {
                if (countsByGuid.ContainsKey(item.OctgnGuid))
                {
                    item.Count = countsByGuid[item.OctgnGuid];
                }
            }
            
            return Json(items, JsonRequestBehavior.AllowGet);
        }
        */
    }
}

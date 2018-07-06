using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Handlers.LotR;
using HallOfBeorn.Models;
using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Tags;
using HallOfBeorn.Services.LotR.Templates;

namespace HallOfBeorn.Controllers
{
    public class LotRController : Controller
    {
        public LotRController()
        {
            cardRepository = (ICardRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository];
            productRepository = (IProductRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.ProductRepository];
            characterRepository = (ICharacterRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CharacterRepository];
            searchService = (ISearchService)System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService];
            playerCategoryService = (ICategoryService<PlayerCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.PlayerCategoryService];
            encounterCategoryService = (ICategoryService<EncounterCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.EncounterCategoryService];
            questCategoryService = (ICategoryService<QuestCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.QuestCategoryService];
            noteService = (INoteService)System.Web.HttpContext.Current.Application[LotRServiceNames.NoteService];
            scenarioService = (IScenarioService)System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService];
            statService = (IStatService)System.Web.HttpContext.Current.Application[LotRServiceNames.StatService];
            octgnService = (IOctgnService)System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService];
            ringsDbService = (IRingsDbService)System.Web.HttpContext.Current.Application[LotRServiceNames.RingsDbService];
            templateService = (ITemplateService)System.Web.HttpContext.Current.Application[LotRServiceNames.TemplateService];
            tagService = (ITagService)System.Web.HttpContext.Current.Application[LotRServiceNames.TagService];

            _charactersHandler = new CharactersHandler(cardRepository, characterRepository);

            _detailsHandler = new DetailsHandler(cardRepository, characterRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService,
                ringsDbService, statService, noteService, tagService, templateService, octgnService);

            _searchHandler = new SearchHandler(searchService, scenarioService, statService, 
                playerCategoryService, encounterCategoryService, questCategoryService, ringsDbService);
        }

        private readonly ISearchService searchService;
        private readonly ICardRepository cardRepository;
        private readonly IProductRepository productRepository;
        private readonly ICharacterRepository characterRepository;
        private readonly ICategoryService<PlayerCategory> playerCategoryService;
        private readonly ICategoryService<EncounterCategory> encounterCategoryService;
        private readonly ICategoryService<QuestCategory> questCategoryService;
        private readonly INoteService noteService;
        private readonly IScenarioService scenarioService;
        private readonly IStatService statService;
        private readonly IOctgnService octgnService;
        private readonly IRingsDbService ringsDbService;
        private readonly ITemplateService templateService;
        private readonly ITagService tagService;

        private readonly CharactersHandler _charactersHandler;
        private readonly DetailsHandler _detailsHandler;
        private readonly SearchHandler _searchHandler;
        
        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return Redirect("/LotR/Search");
        }

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
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return questCategoryService.Categories(slug); });

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
                    
                    model.Detail = new BrowseProductViewModel(product, getPlayerCategories, getEncounterCategories, getQuestCategories);
                }
            }

            return View(model);
        }

        public ActionResult Scenarios(string id, ScenarioView? view)
        {
            try {
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
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return questCategoryService.Categories(slug); });

            if (string.IsNullOrEmpty(id))
            {
                model = scenarioService.GetListViewModel();
                model.View = view.HasValue ? view.Value : ScenarioView.List;

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
                model.Detail = new ScenarioViewModel(scenario, lookupCard, getPlayerCategories, getEncounterCategories, getQuestCategories);

                return View(model);
            }

            return View(model);
            }
            catch (Exception ex) {
                return View(ex.Message);
            }
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

            _searchHandler.HandleSearch(model);

            return View(model);
        }

        public JsonResult SearchJson(SearchViewModel model)
        {
            var jsonData = _searchHandler.HandleJsonSearch(model);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(SearchViewModel model)
        {
            model.Initialize();

            return RedirectToAction("Search", model);
        }

        public ActionResult Details(string id)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                return Redirect(Url.Action("Details", new { action = id }));
            }

            var redirectUrl = _detailsHandler.HandleRedirect(id);
            if (!string.IsNullOrWhiteSpace(redirectUrl))
            {
                return Redirect(redirectUrl);
            }

            var model = _detailsHandler.HandleDetails(id);

            return View(model);
        }

        public ActionResult Characters(string id)
        {
            var model = _charactersHandler.HandleCharacters(id);

            if (model == null)
            {
                var url = string.Format("/Details/{0}", id.ToUrlSafeString());
                return RedirectToAction(url);
            }
            
            return View(model);
        }

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
    }
}

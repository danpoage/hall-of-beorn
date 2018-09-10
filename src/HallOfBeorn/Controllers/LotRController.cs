using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn.Handlers.LotR;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
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
            var cardRepository = (LotRCardRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository];
            var productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.ProductRepository];
            var characterRepository = (ICharacterRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CharacterRepository];
            var searchService = (ISearchService)System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService];
            var playerCategoryService = (ICategoryService<PlayerCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.PlayerCategoryService];
            var encounterCategoryService = (ICategoryService<EncounterCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.EncounterCategoryService];
            var questCategoryService = (ICategoryService<QuestCategory>)System.Web.HttpContext.Current.Application[LotRServiceNames.QuestCategoryService];
            var noteService = (INoteService)System.Web.HttpContext.Current.Application[LotRServiceNames.NoteService];
            var scenarioService = (IScenarioService)System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService];
            var statService = (IStatService)System.Web.HttpContext.Current.Application[LotRServiceNames.StatService];
            var octgnService = (IOctgnService)System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService];
            var ringsDbService = (IRingsDbService)System.Web.HttpContext.Current.Application[LotRServiceNames.RingsDbService];
            var templateService = (ITemplateService)System.Web.HttpContext.Current.Application[LotRServiceNames.TemplateService];
            var tagService = (ITagService)System.Web.HttpContext.Current.Application[LotRServiceNames.TagService];

            _browseHandler = new BrowseHandler(productRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService,
                ringsDbService);

            //TODO: Move this to a CharacterController
            var digitalCardRepository = new Services.Digital.DigitalCardRepository(
                new Services.Digital.DigitalProductRepository()
                );

            _charactersHandler = new CharactersHandler(cardRepository, digitalCardRepository, characterRepository);

            _detailsHandler = new DetailsHandler(cardRepository, characterRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService,
                ringsDbService, statService, noteService, tagService, templateService, octgnService);

            _ringsDbHandler = new RingsDbHandler(ringsDbService);

            _scenariosHandler = new ScenariosHandler(cardRepository, playerCategoryService, encounterCategoryService,
                questCategoryService, scenarioService);

            _searchHandler = new SearchHandler(cardRepository, characterRepository,
                searchService, scenarioService, statService, playerCategoryService, encounterCategoryService, 
                questCategoryService, ringsDbService);
        }

        private readonly BrowseHandler _browseHandler;
        private readonly CharactersHandler _charactersHandler;
        private readonly DetailsHandler _detailsHandler;
        private readonly RingsDbHandler _ringsDbHandler;
        private readonly ScenariosHandler _scenariosHandler;
        private readonly SearchHandler _searchHandler;
        
        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return Redirect("/LotR/Search");
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

            var redirectUrl = _browseHandler.HandleRedirect(id);
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                return Redirect(redirectUrl);
            }
            
            var model = _browseHandler.HandleBrowse(id);

            return View(model);
        }

        public ActionResult Scenarios(string id, ScenarioView? view)
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

            var redirectUrl = _scenariosHandler.HandleRedirect(id);
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                return Redirect(redirectUrl);
            }

            var model = _scenariosHandler.HandleScenarios(id, view);
            if (model == null)
            {
                return HttpNotFound("I'm sorry Mario, your Princess is in another castle.\n\nNo scenario found matching this URL");
            }

            return View(model);
        }

        public JsonResult ScenarioTotals(string id)
        {
            var totals = _scenariosHandler.HandleScenarioTotals(id);

            return Json(totals, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ScenarioDetails(string id)
        {
            var details = _scenariosHandler.HandleScenarioDetails(id);

            return Json(details, JsonRequestBehavior.AllowGet);
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
                var decks = _ringsDbHandler.HandleRingsDbTopDecks(slug);
                return Json(decks, JsonRequestBehavior.AllowGet);
            } catch (Exception)
            {
                return Json(string.Empty, JsonRequestBehavior.AllowGet);
            }
        }
    }
}

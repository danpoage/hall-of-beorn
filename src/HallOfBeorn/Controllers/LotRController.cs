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
using HallOfBeorn.Services.LotR.Community;
using HallOfBeorn.Services.LotR.Design;
using HallOfBeorn.Services.LotR.Links;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Tags;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

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
            var regionService = (ICategoryService<Region>)System.Web.HttpContext.Current.Application[LotRServiceNames.RegionService];
            var archetypeService = (ICategoryService<Archetype>)System.Web.HttpContext.Current.Application[LotRServiceNames.ArchetypeService];
            var linkService = (ILinkService)System.Web.HttpContext.Current.Application[LotRServiceNames.LinkService];
            var noteService = (INoteService)System.Web.HttpContext.Current.Application[LotRServiceNames.NoteService];
            var scenarioService = (IScenarioService)System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService];
            var statService = (IStatService)System.Web.HttpContext.Current.Application[LotRServiceNames.StatService];
            var octgnService = (IOctgnService)System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService];
            var ringsDbService = (IRingsDbService)System.Web.HttpContext.Current.Application[LotRServiceNames.RingsDbService];
            var templateService = (ITemplateService)System.Web.HttpContext.Current.Application[LotRServiceNames.TemplateService];
            var tagService = (ITagService)System.Web.HttpContext.Current.Application[LotRServiceNames.TagService];
            var translationService = (ITranslationService)System.Web.HttpContext.Current.Application[LotRServiceNames.TranslationService];
            var creatorService = (ICreatorService)System.Web.HttpContext.Current.Application[LotRServiceNames.CreatorService];
            var designService = (ICardDesignService)System.Web.HttpContext.Current.Application[LotRServiceNames.CardDesignService];

            _translationHandler = new TranslationHandler(statService, templateService, translationService);

            _productsController = new ProductsHandler(productRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService,
                ringsDbService, _translationHandler);

            _charactersHandler = new CharactersHandler(
                cardRepository, characterRepository, linkService);

            _detailsHandler = new DetailsHandler(_translationHandler, 
                cardRepository, characterRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService,
                ringsDbService, statService, 
                linkService, noteService, tagService, 
                templateService, octgnService);

            _designsHandler = new DesignsHandler(designService, noteService, tagService, linkService);

            _ringsDbHandler = new RingsDbHandler(ringsDbService);

            _scenariosHandler = new ScenariosHandler(cardRepository, 
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService,
                scenarioService);

            _searchHandler = new SearchHandler(cardRepository, characterRepository,
                searchService, scenarioService, linkService, statService, 
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService,
                ringsDbService, designService, creatorService, _translationHandler);

            _creatorsHandler = new CreatorsHandler(creatorService);
        }

        private readonly ProductsHandler _productsController;
        private readonly CharactersHandler _charactersHandler;
        private readonly DetailsHandler _detailsHandler;
        private readonly RingsDbHandler _ringsDbHandler;
        private readonly ScenariosHandler _scenariosHandler;
        private readonly SearchHandler _searchHandler;
        private readonly TranslationHandler _translationHandler;
        private readonly CreatorsHandler _creatorsHandler;
        private readonly DesignsHandler _designsHandler;

        private readonly Language defaultLang = Language.EN;

        private Language getTargetLanguage(Language? lang)
        {
            return lang.HasValue && lang != Language.None ? lang.Value : defaultLang;
        }

        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return Redirect("/LotR/Search");
        }

        public ActionResult Browse(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Redirect(Url.Action("Products", "LotR"));
            }
            else
            {
                return Redirect(Url.Action("Products", "LotR", new { id }));
            }
        }

        public ActionResult Products(string id, ProductView? view, Language? lang)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                if (string.IsNullOrEmpty(id))
                {
                    return Redirect(Url.Action("Products", "LotR"));
                }
                else
                {
                    return Redirect(Url.Action("Products", "LotR", new { id }));
                }
            }

            var redirectUrl = _productsController.HandleRedirect(id);
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                return Redirect(redirectUrl);
            }
            
            var model = _productsController.HandleProducts(id, view, lang);

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
        
        public ActionResult Settings()
        {
            var model = new UserSettingsViewModel();

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

        public JsonResult Version()
        {
            return Json(new { version = "2.13.7", timestamp = DateTime.UtcNow.ToString("u") }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(SearchViewModel model)
        {
            if (HttpContext.Request.Url.AbsolutePath.Contains("/Cards"))
            {
                return Redirect(Url.Action("Search", model));
            }

            var settings = UserSettings.ReadFromSearch(model);
            if (settings == null)
            {
                settings = UserSettings.ReadFromCookies(HttpContext.Request);
            }

            _searchHandler.HandleSearch(model, settings);

            return View(model);
        }

        public JsonResult SearchJson(SearchViewModel model)
        {
            var settings = UserSettings.ReadFromCookies(HttpContext.Request);

            var jsonData = _searchHandler.HandleJsonSearch(model, settings);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search_Post(SearchViewModel model)
        {
            model.Initialize();

            return RedirectToAction("Search", model);
        }

        public ActionResult Details(string id, Language? lang)
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

            var targetLang = getTargetLanguage(lang);

            var model = _detailsHandler.HandleDetails(id, targetLang);

            return View(model);
        }

        public ActionResult Designs(string id, Language? lang)
        {
            var targetLang = getTargetLanguage(lang);

            var model = _designsHandler.HandleDesigns(id, targetLang);

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

        public ActionResult Creators(string id)
        {
            var model = _creatorsHandler.HandleCreators(id);

            if (model == null)
            {
                return RedirectToAction("/Creators");
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

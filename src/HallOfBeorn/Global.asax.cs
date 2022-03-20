using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

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

namespace HallOfBeorn
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            
            System.Web.HttpContext.Current.Application.Lock();
            
            var productRepository = new ProductRepository();
            System.Web.HttpContext.Current.Application[LotRServiceNames.ProductRepository] = productRepository;

            var cardRepository = new LotRCardRepository(productRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository] = cardRepository;

            var characterRepository = new CharacterRepository();
            System.Web.HttpContext.Current.Application[LotRServiceNames.CharacterRepository] = characterRepository;

            var creatorService = new CreatorService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.CreatorService] = creatorService;

            var playerCategoryService = new PlayerCategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.PlayerCategoryService] = playerCategoryService;

            var encounterCategoryService = new EncounterCategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.EncounterCategoryService] = encounterCategoryService;

            var questCategoryService = new QuestCategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.QuestCategoryService] = questCategoryService;

            var regionService = new RegionService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.RegionService] = regionService;

            var archetypeService = new ArchetypeService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.ArchetypeService] = archetypeService;

            var ringsDbService = new RingsDbService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.RingsDbService] = ringsDbService;

            var scenarioService = new ScenarioService(
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService,
                ringsDbService, productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService] = scenarioService;

            var linkService = new LinkService(cardRepository, creatorService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.LinkService] = linkService;

            var noteService = new NoteService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.NoteService] = noteService;

            var filterService = new FilterService(playerCategoryService, encounterCategoryService, questCategoryService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.FilterService] = filterService;

            var translationService = new TranslationService();
            HttpContext.Current.Application[LotRServiceNames.TranslationService] = translationService;

            var templateService = new TemplateService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.TemplateService] = templateService;

            var planService = new PlanService(noteService, scenarioService, 
                playerCategoryService, encounterCategoryService, questCategoryService, regionService, archetypeService, 
                ringsDbService, filterService, translationService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.PlanService] = planService;

            var searchService = new SearchService(cardRepository, planService, translationService, templateService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService] = searchService;

            var statService = new StatService(cardRepository, translationService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.StatService] = statService;

            var octgnService = new OctgnService(productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService] = octgnService;

            var tagService = new TagService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.TagService] = tagService;

            var designService = new CardDesignService(cardRepository, templateService, translationService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.CardDesignService] = designService;

            System.Web.HttpContext.Current.Application.UnLock();
        }
    }
}

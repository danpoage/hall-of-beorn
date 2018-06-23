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
using HallOfBeorn.Services.LotR.Search;

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

            var cardRepository = new CardRepository(productRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository] = cardRepository;

            var characterRepository = new CharacterRepository();
            System.Web.HttpContext.Current.Application[LotRServiceNames.CharacterRepository] = characterRepository;

            var categoryService = new CategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.CategoryService] = categoryService;

            var scenarioService = new ScenarioService(categoryService, productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService] = scenarioService;

            var ringsDbService = new RingsDbService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.RingsDbService] = ringsDbService;

            var advancedSearchService = new AdvancedSearchService(categoryService);
            var sortService = new SearchSortService(ringsDbService);

            var noteService = new NoteService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.NoteService] = noteService;

            var searchService = new SearchService(productRepository, cardRepository, scenarioService, advancedSearchService, categoryService, ringsDbService);
            System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService] = searchService;

            var statService = new StatService(cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.StatService] = statService;

            var octgnService = new OctgnService(productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService] = octgnService;

            var templateService = new TemplateService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.TemplateService] = templateService;

            var tagService = new TagService();
            System.Web.HttpContext.Current.Application[LotRServiceNames.TagService] = tagService;

            System.Web.HttpContext.Current.Application.UnLock();
        }
    }
}
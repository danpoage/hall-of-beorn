using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using HallOfBeorn.Services;

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
            System.Web.HttpContext.Current.Application[Extensions.ProductRepositoryKey] = productRepository;

            var cardRepository = new CardRepository(productRepository);
            System.Web.HttpContext.Current.Application[Extensions.CardRepositoryKey] = cardRepository;

            var categoryService = new CategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.CategoryServiceKey] = categoryService;

            var scenarioService = new ScenarioService(productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.ScenarioServiceKey] = scenarioService;

            var ringsDbService = new RingsDbService(cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.RingsDbKey] = ringsDbService;

            var advancedSearchService = new AdvancedSearchService();
            var sortService = new SearchSortService(ringsDbService);

            var noteService = new NoteService();
            System.Web.HttpContext.Current.Application[Extensions.NoteServiceKey] = noteService;

            var searchService = new SearchService(productRepository, cardRepository, scenarioService, advancedSearchService, sortService, ringsDbService, noteService);
            System.Web.HttpContext.Current.Application[Extensions.SearchServiceKey] = searchService;

            var statService = new StatService(cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.StatServiceKey] = statService;

            var octgnService = new OctgnService(productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.OctgnServiceKey] = octgnService;

            var templateService = new TemplateService();
            System.Web.HttpContext.Current.Application[Extensions.TemplateServiceKey] = templateService;

            var tagService = new TagService();
            System.Web.HttpContext.Current.Application[Extensions.TagServiceKey] = tagService;

            System.Web.HttpContext.Current.Application.UnLock();
        }
    }
}
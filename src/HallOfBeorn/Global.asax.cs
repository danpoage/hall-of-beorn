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

            var deckRepository = new DeckRepository();
            System.Web.HttpContext.Current.Application[Extensions.DeckRepositoryKey] = deckRepository;

            var categoryService = new CategoryService(cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.CategoryServiceKey] = categoryService;

            var scenarioService = new ScenarioService(productRepository, cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.ScenarioServiceKey] = scenarioService;

            var advancedSearchService = new AdvancedSearchService();
            var sortService = new SearchSortService();
            
            var searchService = new SearchService(productRepository, cardRepository, scenarioService, advancedSearchService, sortService);
            System.Web.HttpContext.Current.Application[Extensions.SearchServiceKey] = searchService;

            var statService = new StatService(cardRepository);
            System.Web.HttpContext.Current.Application[Extensions.StatServiceKey] = statService;

            System.Web.HttpContext.Current.Application.UnLock();
        }
    }
}
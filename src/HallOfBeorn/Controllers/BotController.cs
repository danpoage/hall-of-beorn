using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Simple;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.Community;
using HallOfBeorn.Services.LotR.Design;
using HallOfBeorn.Services.LotR.Octgn;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Search;
using HallOfBeorn.Services.LotR.Templates;

namespace HallOfBeorn.Controllers
{
    public class BotController : Controller
    {
        public BotController()
        {
            productRepository = (ProductRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.ProductRepository];
            cardRepository = (LotRCardRepository)System.Web.HttpContext.Current.Application[LotRServiceNames.CardRepository];
            scenarioService = (IScenarioService)System.Web.HttpContext.Current.Application[LotRServiceNames.ScenarioService];
            searchService = (SearchService)System.Web.HttpContext.Current.Application[LotRServiceNames.SearchService];
            cardDesignService = (ICardDesignService)System.Web.HttpContext.Current.Application[LotRServiceNames.CardDesignService];
            octgnService = (IOctgnService)System.Web.HttpContext.Current.Application[LotRServiceNames.OctgnService];
            ringsDbService = GetService<IRingsDbService>(LotRServiceNames.RingsDbService);
            templateService = GetService<ITemplateService>(LotRServiceNames.TemplateService);
            creatorService = GetService<ICreatorService>(LotRServiceNames.CreatorService);

            archetypeService = new ArchetypeService(cardRepository);
            playerCategoryService = new PlayerCategoryService(cardRepository);
            encounterCategoryService = new EncounterCategoryService(cardRepository);
            questCategoryService = new QuestCategoryService(cardRepository);
            regionService = new RegionService(cardRepository);
        }

        private readonly SearchService searchService;
        private readonly ProductRepository productRepository;
        private readonly LotRCardRepository cardRepository;
        private readonly IScenarioService scenarioService;
        private readonly ICardDesignService cardDesignService;
        private readonly IOctgnService octgnService;
        private readonly IRingsDbService ringsDbService;
        private readonly ITemplateService templateService;
        private readonly ICreatorService creatorService;

        private readonly ICategoryService<Archetype> archetypeService;
        private readonly ICategoryService<PlayerCategory> playerCategoryService;
        private readonly ICategoryService<EncounterCategory> encounterCategoryService;
        private readonly ICategoryService<QuestCategory> questCategoryService;
        private readonly ICategoryService<Region> regionService;

        private static T GetService<T>(string key)
        {
            return (T)System.Web.HttpContext.Current.Application[key];
        }

        public ActionResult Cards(string lang)
        {
            Func<string, string> getRingsDbCode = (slug) =>
                    ringsDbService.GetCardId(slug);

            Func<string, string> getOctgnId = (slug) =>
                octgnService.GetCardOctgnGuid(slug);

            var cards = new List<Models.RingsDb.RingsDbCard>();

            Language language;

            if (!Enum.TryParse<Language>(lang, out language))
            {
                language = Language.EN;
            }

            foreach (var design in cardDesignService.Designs(language))
            {
                //Check for designs without an HTML template
                var frontTemplate = design.First.GetFrontHtmlTemplate(language);
                if (string.IsNullOrEmpty(frontTemplate))
                {
                    frontTemplate = templateService.GetFrontHtml(design.First.Slug, language);
                    design.First.WithFrontHtmlTemplate(language, frontTemplate);

                    var backTemplate = templateService.GetBackHtml(design.First.Slug, language);
                    if (!string.IsNullOrEmpty(backTemplate))
                    {
                        design.First.WithBackHtmlTemplate(language, backTemplate);
                    }
                }

                cards.Add(
                    Models.RingsDb.RingsDbCard.FromDesign(design, getRingsDbCode, getOctgnId, language));
            }

            var content = JsonConvert.SerializeObject(cards, 
                Formatting.None, 
                new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                });

            return new ContentResult {
                Content = content,
                ContentEncoding = System.Text.Encoding.UTF8,
                ContentType = "application/json",
            };
        }

        public ActionResult Scenarios(string lang)
        {
            var scenarios = new List<Models.BeornBot.Scenario>();

            foreach (var group in scenarioService.ScenarioGroups())
            {
                var isOfficial = group.IsOfficial;

                foreach (var scenario in group.Scenarios)
                {
                    scenarios.Add(new Models.BeornBot.Scenario
                    {
                        name = scenario.Title,
                        product = scenario.ProductName,
                        is_official = isOfficial,
                        url = string.Format("https://hallofbeorn.com/LotR/Scenarios/{0}", scenario.Slug)
                    });
                }
            }
            
            var content = JsonConvert.SerializeObject(scenarios, 
                Formatting.None, 
                new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                });

            return new ContentResult {
                Content = content,
                ContentEncoding = System.Text.Encoding.UTF8,
                ContentType = "application/json",
            };
        }

        public ActionResult Blogs(string lang)
        {
            var links = new Dictionary<string, List<ILink>>();

            foreach (var blog in creatorService.Blogs())
            {
                links[blog.Name] = new List<ILink>(blog.Links());
            }

            var content = JsonConvert.SerializeObject(links, 
                Formatting.None, 
                new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                });

            return new ContentResult {
                Content = content,
                ContentEncoding = System.Text.Encoding.UTF8,
                ContentType = "application/json",
            };
        }

        public ActionResult Podcasts(string lang)
        {
            var links = new Dictionary<string, List<ILink>>();

            foreach (var podcast in creatorService.Podcasts())
            {
                links[podcast.Name] = new List<ILink>(podcast.Links());
            }

            var content = JsonConvert.SerializeObject(links, 
                Formatting.None, 
                new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                });

            return new ContentResult {
                Content = content,
                ContentEncoding = System.Text.Encoding.UTF8,
                ContentType = "application/json",
            };
        }

        public ActionResult Channels(string lang)
        {
            var links = new Dictionary<string, List<ILink>>();

            foreach (var channel in creatorService.Channels())
            {
                links[channel.Name] = new List<ILink>(channel.Links());
            }

            var content = JsonConvert.SerializeObject(links, 
                Formatting.None, 
                new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                });

            return new ContentResult {
                Content = content,
                ContentEncoding = System.Text.Encoding.UTF8,
                ContentType = "application/json",
            };
        }
    }
}

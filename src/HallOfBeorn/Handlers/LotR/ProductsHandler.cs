using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Handlers.LotR
{
    public class ProductsHandler
    {
        public ProductsHandler(ProductRepository productRepository,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService,
            ICategoryService<QuestCategory> questCategoryService,
            ICategoryService<Region> regionService,
            ICategoryService<Archetype> archetypeService,
            IRingsDbService ringsDbService,
            TranslationHandler translationHandler)
        {
            _productRepository = productRepository;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _regionService = regionService;
            _archetypeService = archetypeService;
            _ringsDbService = ringsDbService;
            _translationHandler = translationHandler;
        }

        private readonly ProductRepository _productRepository;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly ICategoryService<Region> _regionService;
        private readonly ICategoryService<Archetype> _archetypeService;
        private readonly IRingsDbService _ringsDbService;
        private readonly TranslationHandler _translationHandler;

        private Product getProductByIdentifier(string id)
        {
            return _productRepository.Products()
                .Where(prod => 
                    prod.Name.ToUrlSafeString() == id || 
                    prod.Name.NormalizeCaseSensitiveString().ToUrlSafeString() == id ||
                    prod.Code == id
                ).FirstOrDefault();
        }

        public string HandleRedirect(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var product = getProductByIdentifier(id);
                if (product.Name.NormalizeCaseSensitiveString().ToUrlSafeString() != id)
                {
                    return string.Format("/LotR/Products/{0}", product.Name.NormalizeCaseSensitiveString().ToUrlSafeString());
                }
            }
            return string.Empty;
        }

        public ProductListViewModel HandleProducts(string id, ProductView? view, Language? lang)
        {
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });
            var getRegions = new Func<string, IEnumerable<Region>>((slug) => _regionService.Categories(slug));
            var getArchetypes = new Func<string, IEnumerable<Archetype>>(slug => _archetypeService.Categories(slug));

            var model = new ProductListViewModel();

            Func<string, byte> getPopularity = (slug) =>
            {
                return _ringsDbService.GetPopularity(slug);
            };

            Func<string, string> translateTitle = (title) =>
            {
                return _translationHandler.TranslateTitle(lang, title);
            };

            Func<CardType, string> translateCardType = (cardType) =>
            {
                return _translationHandler.TranslateCardType(lang, cardType);
            };

            if (string.IsNullOrWhiteSpace(id))
            {
                foreach (var productGroup in _productRepository.ProductGroups())
                {
                    model.ProductGroups.Add(new ProductGroupViewModel(productGroup, getPopularity));
                }
                model.View = view.HasValue ? view.Value : ProductView.Browse;
            }
            else
            {
                var product = getProductByIdentifier(id);
                if (product != null)
                {
                    model.Detail = new ProductDetailViewModel(product, 
                        getPlayerCategories, getEncounterCategories, getQuestCategories, getRegions, getArchetypes, 
                        lang, translateTitle, translateCardType);
                }
            }

            return model;
        }
    }
}
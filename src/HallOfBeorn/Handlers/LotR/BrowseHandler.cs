using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Handlers.LotR
{
    public class BrowseHandler
    {
        public BrowseHandler(IProductRepository productRepository,
            ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService,
            ICategoryService<QuestCategory> questCategoryService,
            IRingsDbService ringsDbService)
        {
            _productRepository = productRepository;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _ringsDbService = ringsDbService;
        }

        private readonly IProductRepository _productRepository;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly IRingsDbService _ringsDbService;

        private Product getProductByIdentifier(string id)
        {
            return _productRepository.Products()
                .Where(
                    x => x.Name.ToUrlSafeString() == id || 
                    x.Name.NormalizeCaseSensitiveString().ToUrlSafeString() == id ||
                    x.Code == id
                ).FirstOrDefault();
        }

        public string HandleRedirect(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var product = getProductByIdentifier(id);
                if (product.Name.NormalizeCaseSensitiveString().ToUrlSafeString() != id)
                {
                    return string.Format("/LotR/Browse/{0}", product.Name.NormalizeCaseSensitiveString().ToUrlSafeString());
                }
            }
            return string.Empty;
        }

        public BrowseViewModel HandleBrowse(string id)
        {
            var getPlayerCategories = new Func<string, IEnumerable<PlayerCategory>>((slug) => { return _playerCategoryService.Categories(slug); });
            var getEncounterCategories = new Func<string, IEnumerable<EncounterCategory>>((slug) => { return _encounterCategoryService.Categories(slug); });
            var getQuestCategories = new Func<string, IEnumerable<QuestCategory>>((slug) => { return _questCategoryService.Categories(slug); });

            var model = new BrowseViewModel();

            Func<string, byte> getPopularity = (slug) =>
            {
                return _ringsDbService.GetPopularity(slug);
            };

            if (string.IsNullOrWhiteSpace(id))
            {
                foreach (var productGroup in _productRepository.ProductGroups())
                {
                    model.ProductGroups.Add(new ProductGroupViewModel(productGroup, getPopularity));
                }
            }
            else
            {
                var product = getProductByIdentifier(id);
                if (product != null)
                {
                    model.Detail = new BrowseProductViewModel(product, getPlayerCategories, getEncounterCategories, getQuestCategories);
                }
            }

            return model;
        }
    }
}
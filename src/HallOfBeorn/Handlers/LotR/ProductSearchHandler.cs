using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Handlers.LotR
{
    public class ProductSearchHandler
        : ISearchViewHandler
    {
        public ProductSearchHandler(IRingsDbService ringsDbService)
        {
            this.ringsDbService = ringsDbService;
        }

        private readonly IRingsDbService ringsDbService;

        public void HandleSearch(SearchViewModel model, UserSettings settings)
        {
            var productsByCode = new Dictionary<string, ProductViewModel>();

            Func<string, byte> getPopularity = (slug) => {
                return ringsDbService.GetPopularity(slug);
            };

            var key = string.Empty;
            foreach (var cardViewModel in model.Cards)
            {
                key = cardViewModel.Card.CardSet.Product.Code;
                if (!productsByCode.ContainsKey(key))
                {
                    productsByCode[key] = new ProductViewModel(cardViewModel.Card.CardSet.Product, getPopularity);
                }

                productsByCode[key].AddCard(cardViewModel);
            }

            model.Products.AddRange(productsByCode.Values.OrderBy(prod => prod.Code));
        }
    }
}
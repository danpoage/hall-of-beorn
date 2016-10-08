using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.Arkham;
using HallOfBeorn.Models.Arkham.ViewModels;

namespace HallOfBeorn.Services.Arkham
{
    public class ArkhamSearchService
    {
        private readonly ArkhamProductRepository productRepository = new ArkhamProductRepository();

        public IEnumerable<ArkhamSearchResult> Search(ArkhamSearchViewModel model)
        {
            var results = new List<ArkhamSearchResult>();

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    if (model.CardType.HasValue && card.CardType != model.CardType.Value)
                    {
                        continue;
                    }

                    results.Add(new ArkhamSearchResult(card));
                }
            }

            if (!model.Sort.HasValue)
            {
                return results.OrderByDescending(x => x.Score).ToList();
            }

            switch (model.Sort)
            {
                case ArkhamSort.Alphabetical:
                    return results.OrderBy(x => x.Card.Name).ToList();
                case ArkhamSort.Set_Number:
                    return results.OrderBy(x => x.Card.Product.ReleaseDate).ThenBy(x => x.Card.Number).ToList();
                default:
                    return results.OrderByDescending(x => x.Score).ToList();
            }
        }
    }
}
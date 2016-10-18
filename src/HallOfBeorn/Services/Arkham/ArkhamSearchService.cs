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
        public ArkhamSearchService(ArkhamProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        private readonly ArkhamProductRepository productRepository;

        public IEnumerable<ArkhamSearchResult> Search(ArkhamSearchViewModel model)
        {
            var results = new List<ArkhamSearchResult>();

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    if (!string.IsNullOrEmpty(model.Product) && model.Product != "Any" && card.Product.Name != model.Product)
                    {
                        continue;
                    }
                    if (model.CardType.HasValue && model.CardType != ArkhamCardType.None && card.CardType != model.CardType.Value)
                    {
                        continue;
                    }
                    if (model.CardClass.HasValue && model.CardClass != ArkhamClass.None && card.Class != model.CardClass.Value)
                    {
                        continue;
                    }
                    if (model.Willpower.HasValue && model.Willpower.Value > 0 && model.Willpower.Value != card.Willpower)
                    {
                        continue;
                    }
                    if (model.Intellect.HasValue && model.Intellect.Value > 0 && model.Intellect.Value != card.Intellect)
                    {
                        continue;
                    }
                    if (model.Combat.HasValue && model.Combat.Value > 0 && model.Combat.Value != card.Combat)
                    {
                        continue;
                    }
                    if (model.Agility.HasValue && model.Agility.Value > 0 && model.Agility.Value != card.Agility)
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.Trait) && model.Trait != "Any" && !card.Traits().Any(x => x.Replace(".", "") == model.Trait.Replace(".", "")))
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
                case ArkhamSearchSort.Alphabetical:
                    return results.OrderBy(x => x.Card.Name).ToList();
                case ArkhamSearchSort.Set_Number:
                    return results.OrderBy(x => x.Card.Product.ReleaseDate).ThenBy(x => x.Card.Number).ToList();
                default:
                    return results.OrderByDescending(x => x.Score).ToList();
            }
        }
    }
}
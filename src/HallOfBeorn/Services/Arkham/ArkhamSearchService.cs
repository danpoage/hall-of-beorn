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
                    if (model.CardClass.HasValue && model.CardClass != ClassSymbol.None && card.Class != model.CardClass.Value)
                    {
                        continue;
                    }
                    if (model.Willpower.HasValue && model.Willpower.Value > 0 && card.Willpower.HasValue && model.Willpower.Value != card.Willpower.Value.Value)
                    {
                        continue;
                    }
                    if (model.Intellect.HasValue && model.Intellect.Value > 0 && card.Intellect.HasValue && model.Intellect.Value != card.Intellect.Value.Value)
                    {
                        continue;
                    }
                    if (model.Combat.HasValue && model.Combat.Value > 0 && card.Combat.HasValue && model.Combat.Value != card.Combat.Value.Value)
                    {
                        continue;
                    }
                    if (model.Agility.HasValue && model.Agility.Value > 0 && card.Agility.HasValue && model.Agility.Value != card.Agility.Value.Value)
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
                    return results.OrderBy(x => x.Card.Title).ToList();
                case ArkhamSearchSort.Set_Number:
                    return results.OrderBy(x => x.Card.Product.ReleaseDate).ThenBy(x => x.Card.CardNumber).ToList();
                default:
                    return results.OrderByDescending(x => x.Score).ToList();
            }
        }
    }
}
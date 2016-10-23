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

        private bool cardMatchesNumberFilter(string modelValue, Number? cardValue)
        {
            if (!cardValue.HasValue)
            {
                return false;
            }

            var isPerInvestigator = modelValue.EndsWith(ArkhamCardViewModel.PerInvestigatorDescription);
            var isX = modelValue == "X";
            var isNA = modelValue == "-";
            byte value = 0;
            if (!isX && !isNA)
            {
                byte.TryParse(modelValue.Replace(ArkhamCardViewModel.PerInvestigatorDescription, string.Empty).Trim(), out value);
            }

            if (cardValue.Value.Value != value)
            {
                return false;
            }
            if (cardValue.Value.IsX != isX)
            {
                return false;
            }
            if (cardValue.Value.IsPerInvestigator != isPerInvestigator)
            {
                return false;
            }
            if (cardValue.Value.IsNotApplicable != isNA)
            {
                return false;
            }

            return true;
        }

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
                    if (model.LocationSymbol.HasValue && model.LocationSymbol.Value != ConnectionSymbol.None && (!card.LocationSymbol.HasValue || model.LocationSymbol.Value != card.LocationSymbol))
                    {
                        continue;
                    }
                    if (model.ConnectsTo.HasValue && model.ConnectsTo.Value != ConnectionSymbol.None && !card.Connections().Any(x => x == model.ConnectsTo.Value))
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.FightValue) && model.FightValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.FightValue, card.FightValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.HealthValue) && model.HealthValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.HealthValue, card.HealthValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EvadeValue) && model.EvadeValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.EvadeValue, card.EvadeValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Damage) && model.Damage != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Damage, card.Damage))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Horror) && model.Horror != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Horror, card.Horror))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Shroud) && model.Shroud != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Shroud, card.Shroud))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.ClueValue) && model.ClueValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.ClueValue, card.ClueValue))
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
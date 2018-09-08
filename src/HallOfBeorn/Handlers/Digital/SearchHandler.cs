using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ViewModels;
using HallOfBeorn.Services.Digital;

namespace HallOfBeorn.Handlers.Digital
{
    public class SearchHandler
    {
        public SearchHandler(DigitalProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private readonly DigitalProductRepository _productRepository;

        private bool QueryFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            if (!string.IsNullOrEmpty(model.Query))
            {
                if (!card.Title.ContainsLower(model.Query) && !card.Text.ContainsLower(model.Query) && (!card.Trait.HasValue || !card.Trait.Value.ToString().ContainsLower(model.Query)))
                    return false;
            }
            return true;
        }

        public bool CardSetFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return string.IsNullOrEmpty(model.CardSet) 
                || model.CardSet == "Any" 
                || model.CardSet.NormalizeCaseSensitiveString() == card.CardSet.Name.NormalizeCaseSensitiveString();
        }

        private bool CardTypeFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.CardType.HasValue || model.CardType.Value == DigitalCardType.None || model.CardType.Value == card.CardType;
        }

        private bool SphereFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.Sphere.HasValue || model.Sphere.Value == DigitalSphere.Any || model.Sphere.Value == card.Sphere;
        }

        private bool TraitFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.Trait.HasValue || model.Trait.Value == DigitalTrait.None || model.Trait.Value == card.Trait;
        }

        private bool KeywordFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            if (model.Keyword.HasValue && model.Keyword.Value != DigitalKeyword.None)
            {
                var keyword = model.Keyword.Value.ToString().ToLower();
                if (!card.Text.StartsWithLower(keyword) && !card.Text.ContainsLower(" " + keyword))
                    return false;
            }
            return true;
        }

        private bool SlotFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.Slot.HasValue || model.Slot.Value == AttachmentSlot.None || model.Slot.Value == card.Slot;
        }

        private bool RarityFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.Rarity.HasValue || model.Rarity.Value == DigitalRarity.None || model.Rarity.Value == card.Rarity;
        }

        private bool LevelFilter(DigitalSearchViewModel model, DigitalCard card)
        {
            return !model.Level.HasValue || (card.Level.HasValue && model.Level.Value == card.Level.Value);
        }

        private bool NumericFilter(NumericOperator? op, DigitalCard card, byte target, Func<DigitalCard, byte?> getStat)
        {
            if (!op.HasValue)
                return true;

            var stat = getStat(card);
            if (!stat.HasValue)
                return false;

            switch (op.Value)
            {
                case NumericOperator.gt:
                    return stat.Value > target;
                case NumericOperator.gteq:
                    return stat.Value >= target;
                case NumericOperator.lt:
                    return stat.Value < target;
                case NumericOperator.lteq:
                    return stat.Value <= target;
                case NumericOperator.eq:
                default:
                    return stat.Value == target;
            }
        }

        public void HandleSearch(DigitalSearchViewModel model)
        {
            var results = new List<DigitalCardViewModel>();

            byte costTarget = 0;
            var hasCostFilter = byte.TryParse(model.Cost, out costTarget);

            byte threatCostTarget = 0;
            var hasThreatCostFilter = byte.TryParse(model.ThreatCost, out threatCostTarget);

            byte attackTarget = 0;
            var hasAttackFilter = byte.TryParse(model.Attack, out attackTarget);

            byte willpowerTarget = 0;
            var hasWillpowerFilter = byte.TryParse(model.Willpower, out willpowerTarget);

            byte hitPointsTarget = 0;
            var hasHitPointsFilter = byte.TryParse(model.HitPoints, out hitPointsTarget);

            foreach (var cardSet in _productRepository.CardSets())
            {
                foreach (var card in cardSet.Cards)
                {
                    if (!QueryFilter(model, card))
                        continue;

                    if (!CardSetFilter(model, card))
                        continue;

                    if (!CardTypeFilter(model, card))
                        continue;

                    if (!SphereFilter(model, card))
                        continue;

                    if (!TraitFilter(model, card))
                        continue;

                    if (!KeywordFilter(model, card))
                        continue;

                    if (!SlotFilter(model, card))
                        continue;

                    if (!RarityFilter(model, card))
                        continue;

                    if (!LevelFilter(model, card))
                        continue;

                    if (hasCostFilter && !NumericFilter(model.CostOperator, card, costTarget, (c) => c.ResourceCost))
                        continue;

                    if (hasThreatCostFilter && !NumericFilter(model.ThreatCostOperator, card, threatCostTarget, (c) => c.ThreatCost))
                        continue;

                    if (hasAttackFilter && !NumericFilter(model.AttackOp, card, attackTarget, (c) => c.Attack))
                        continue;

                    if (hasWillpowerFilter && !NumericFilter(model.WillpowerOp, card, willpowerTarget, (c) => c.Willpower))
                        continue;

                    if (hasHitPointsFilter && !NumericFilter(model.HitPointsOp, card, hitPointsTarget, (c) => c.HitPoints))
                        continue;

                    results.Add(new DigitalCardViewModel(card));
                }
            }

            if (!model.Sort.HasValue)
                model.Cards = results.ToList();
            else if (model.Sort == DigitalSort.Title)
                model.Cards = results.OrderBy(m => m.Title).ToList();
            else if (model.Sort == DigitalSort.Rarity)
                model.Cards = results.OrderBy(m => m.Rarity).ToList();
            else if (model.Sort == DigitalSort.Sphere_Type_Cost)
                model.Cards = results.OrderBy(m => m.Sphere)
                    .ThenBy(m => m.CardType)
                    .ThenBy(m => m.ThreatCost)
                    .ThenBy(m => m.ResourceCost)
                    .ToList();

        }
    }
}
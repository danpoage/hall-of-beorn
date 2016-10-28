using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.Arkham;
using HallOfBeorn.Models.Arkham.Products;

namespace HallOfBeorn.Services.Arkham
{
    public class ArkhamProductRepository
    {
        public ArkhamProductRepository()
        {
            products.Add(new CoreSet());
            products.Add(new TheDunwichLegacy());
        }

        private readonly List<ArkhamProduct> products = new List<ArkhamProduct>();

        public IEnumerable<ArkhamProduct> Products()
        {
            return products;
        }

        public IEnumerable<ArkhamCard> Cards()
        {
            foreach (var product in products)
                foreach (var card in product.Cards())
                    yield return card;
        }

        public IEnumerable<string> Traits()
        {
            foreach (var card in Cards())
                foreach (var trait in card.Traits())
                    yield return trait;
        }

        public IEnumerable<string> Keywords()
        {
            foreach (var card in Cards())
                foreach (var keyword in card.Keywords())
                    yield return keyword;
        }

        public IEnumerable<string> HealthValues()
        {
            foreach (var card in Cards().Where(x => x.Health > 0))
                yield return card.Health.ToString();
        }

        public IEnumerable<string> SanityValues()
        {
            foreach (var card in Cards().Where(x => x.Sanity > 0))
                yield return card.Sanity.ToString();
        }

        public IEnumerable<string> CostValues()
        {
            foreach (var card in Cards().Where(x => x.Cost.HasValue))
                yield return card.Cost.Value.ToString();
        }

        public IEnumerable<string> VictoryPointsValues()
        {
            foreach (var card in Cards().Where(x => x.VictoryPoints.HasValue))
                yield return string.Format("Victory {0}", card.VictoryPoints.Value);
        }

        public IEnumerable<string> DoomThresholdValues()
        {
            foreach (var card in Cards().Where(x => x.DoomThreshold.HasValue))
                yield return card.DoomThreshold.Value.ToString();
        }

        public IEnumerable<string> ClueThresholdValues()
        {
            foreach (var card in Cards().Where(x => x.ClueThreshold.HasValue))
                yield return card.ClueThreshold.Value.ToString();
        }

        public IEnumerable<string> SkillValues(Skill skill)
        {
            foreach (var card in Cards())
            {
                Func<ArkhamCard, Skill, string> getSkill = (c, sk) =>
                    {
                        switch (sk)
                        {
                            case Skill.Willpower:
                                return c.Willpower.HasValue ? c.Willpower.ToString() : string.Empty;
                            case Skill.Intellect:
                                return c.Intellect.HasValue ? c.Intellect.ToString() : string.Empty;
                            case Skill.Combat:
                                return c.Combat.HasValue ? c.Combat.ToString() : string.Empty;
                            case Skill.Agility:
                                return c.Agility.HasValue ? c.Agility.ToString() : string.Empty;
                            default:
                                return string.Empty;;
                        }
                    };

                yield return getSkill(card, skill);
            }
        }
        public IEnumerable<string> Stats(StatType type, string perInvestigatorSuffix)
        {
            foreach (var card in Cards().Where(x => x.CardType == ArkhamCardType.Enemy || x.CardType == ArkhamCardType.Location || x.CardType == ArkhamCardType.Treachery))
            {
                Func<ArkhamCard, StatType, string> getStat = (c, t) =>
                {
                    switch (t)
                    {
                        case StatType.Shroud:
                            return c.Shroud.HasValue ? c.Shroud.Value.ToString(perInvestigatorSuffix) : string.Empty;
                        case StatType.ClueValue:
                            return c.ClueValue.HasValue ? c.ClueValue.Value.ToString(perInvestigatorSuffix) : string.Empty;
                        case StatType.FightValue:
                            return c.EnemyFightValue.HasValue ? c.EnemyFightValue.Value.ToString(perInvestigatorSuffix) : string.Empty;
                        case StatType.HealthValue:
                            return c.EnemyHealthValue.HasValue ? c.EnemyHealthValue.Value.ToString(perInvestigatorSuffix) : string.Empty;
                        case StatType.EvadeValue:
                            return c.EnemyEvadeValue.HasValue ? c.EnemyEvadeValue.Value.ToString(perInvestigatorSuffix) : string.Empty;
                        case StatType.Damage:
                            return c.Damage.HasValue ? c.Damage.Value.ToString() : string.Empty;
                        case StatType.Horror:
                            return c.Horror.HasValue ? c.Horror.Value.ToString() : string.Empty;
                        default:
                            return string.Empty; ;
                    }
                };

                yield return getStat(card, type);
            }
        }
        public IEnumerable<string> Artists()
        {
            foreach (var card in Cards())
                yield return card.Artist.Name;
        }
    }
}
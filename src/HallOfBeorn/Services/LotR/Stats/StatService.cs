using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Stats
{
    public class StatService : IStatService
    {
        public StatService(ICardRepository<LotRCard> cardRepository)
        {
            cards = cardRepository.Cards();
            foreach (var card in cards)
            {
                Analyze(card);
            }
        }

        private readonly IEnumerable<LotRCard> cards;
        private readonly Dictionary<string, string> keywords = new Dictionary<string, string>();
        private readonly Dictionary<string, string> traits = new Dictionary<string, string>();
        private readonly Dictionary<byte, string> victoryPointsValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> attackStrengthValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> defenseStrengthValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> hitPointsValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> willpowerStrengthValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> threatStrengthValues = new Dictionary<byte, string>();
        private readonly Dictionary<byte, string> questPointsValues = new Dictionary<byte, string>();

        private void Analyze(LotRCard card)
        {
            foreach (var keyword in card.Keywords)
            {
                var keywordKey = keyword.Trim();
                var keywordValue = keywordKey.Replace("~", string.Empty);
                if (!keywords.ContainsKey(keywordKey))
                    keywords.Add(keywordKey, keywordValue);
            }

            foreach (var trait in card.Traits)
            {
                var traitKey = trait.Replace(".", string.Empty).Trim();
                if (!traits.ContainsKey(traitKey))
                    traits.Add(traitKey, trait.Trim());
            }

            if (card.VictoryPoints > 0 && !victoryPointsValues.ContainsKey(card.VictoryPoints))
            {
                var victoryPoint = card.VictoryPoints.IsX() ? "X" : card.VictoryPoints.ToString();
                victoryPointsValues.Add(card.VictoryPoints, string.Format("Victory {0}.", victoryPoint));
            }

            var attackKey = card.Attack.HasValue ? card.Attack.Value : (byte)0;
            var attackValue = card.Attack.HasValue ? card.Attack.Value.ToString() : string.Empty;
            if (card.Attack.IsX())
            {
                attackKey = Models.Card.VALUE_X;
                attackValue = "X";
            }
            else if (card.Attack.IsNA())
            {
                attackKey = Models.Card.VALUE_NA;
                attackValue = "-";
            }

            if (card.Attack.HasValue && !attackStrengthValues.ContainsKey(attackKey))
            {
                attackStrengthValues.Add(attackKey, attackValue);
            }

            var defenseKey = card.Defense.HasValue ? card.Defense.Value : (byte)0;
            var defenseValue = card.Defense.HasValue ? card.Defense.Value.ToString() : string.Empty;
            if (card.Defense.IsX())
            {
                defenseKey = Models.Card.VALUE_X;
                defenseValue = "X";
            }
            else if (card.Defense.IsNA())
            {
                defenseKey = Models.Card.VALUE_NA;
                defenseValue = "-";
            }

            if (card.Defense.HasValue && !defenseStrengthValues.ContainsKey(defenseKey))
            {
                defenseStrengthValues.Add(defenseKey, defenseValue);
            }

            byte hitPointsKey = 0; var hitPointsValue = string.Empty;
            if (card.HitPoints.IsX())
            {
                hitPointsKey = Models.Card.VALUE_X;
                hitPointsValue = "X";
            }
            else if (card.HitPoints.IsNA())
            {
                hitPointsKey = Models.Card.VALUE_NA;
                hitPointsValue = "-";
            }
            else
            {
                hitPointsKey = card.HitPoints.HasValue ? card.HitPoints.Value : (byte)0;
                hitPointsValue = card.HitPoints.HasValue ? hitPointsKey.ToString() : string.Empty;
            }
            if (hitPointsKey != (byte)0 && !string.IsNullOrEmpty(hitPointsValue) && !hitPointsValues.ContainsKey(hitPointsKey))
            {
                hitPointsValues.Add(hitPointsKey, hitPointsValue);
            }

            var willpowerKey = card.Willpower.HasValue ? card.Willpower.Value : (byte)0;
            var willpowerValue = card.Willpower.HasValue ? card.Willpower.Value.ToString() : string.Empty;
            if (card.Willpower.IsX())
            {
                willpowerKey = Models.Card.VALUE_X;
                willpowerValue = "X";
            }
            else if (card.Willpower.IsNA())
            {
                willpowerKey = Models.Card.VALUE_NA;
                willpowerValue = "-";
            }

            if (card.Willpower.HasValue && !willpowerStrengthValues.ContainsKey(willpowerKey))
            {
                willpowerStrengthValues.Add(willpowerKey, willpowerValue);
            }

            var threatKey = card.Threat.HasValue ? card.Threat.Value : (byte)0;
            var threatValue = card.Threat.HasValue ? card.Threat.Value.ToString() : string.Empty;
            if (card.Threat.IsX())
            {
                threatKey = Models.Card.VALUE_X;
                threatValue = "X";
            }
            else if (card.Threat.IsNA())
            {
                threatKey = Models.Card.VALUE_NA;
                threatValue = "-";
            }

            if (card.Threat.HasValue && !threatStrengthValues.ContainsKey(threatKey))
            {
                threatStrengthValues.Add(threatKey, threatValue);
            }

            byte questPointsKey = 0; var questPointsValue = string.Empty;
            if (card.QuestPoints.IsX())
            {
                questPointsKey = Models.Card.VALUE_X;
                questPointsValue = "X";
            }
            else if (card.QuestPoints.IsNA())
            {
                questPointsKey = byte.MaxValue;
                questPointsValue = "-";
            }
            else
            {
                questPointsKey = card.QuestPoints.HasValue ? card.QuestPoints.Value : (byte)0;
                questPointsValue = card.QuestPoints.HasValue ? questPointsKey.ToString() : string.Empty;
            }
            if (!string.IsNullOrEmpty(questPointsValue) && !questPointsValues.ContainsKey(questPointsKey))
            {
                questPointsValues.Add(questPointsKey, questPointsValue);
            }
        }

        public IEnumerable<string> Spheres()
        {
            return typeof(Sphere).GetSelectListItems().Select(x => x.Text);
        }

        public IEnumerable<string> ResourceCosts()
        {
            return cards
                .Where(card => !string.IsNullOrEmpty(card.ResourceCost.Description()))
                .OrderBy(card => card.ResourceCost)
                .Select(card => card.ResourceCost.Description())
                .Distinct();
        }

        public IEnumerable<string> ThreatCosts()
        {
            return cards
                .Where(card => !string.IsNullOrEmpty(card.ThreatCost.Description(false)))
                .OrderBy(card => card.ThreatCost)
                .Select(card => card.ThreatCost.Description(false))
                .Distinct();
        }

        public IEnumerable<string> EngagementCosts()
        {
            return cards
                .Where(card => !string.IsNullOrEmpty(card.EngagementCost.Description(false)))
                .OrderBy(card => card.EngagementCost)
                .Select(card => card.EngagementCost.Description(false))
                .Distinct();
        }

        public IEnumerable<string> Keywords()
        {
            return keywords.Values
                .ToList()
                .OrderBy(keyword => keyword);
        }

        public IEnumerable<string> Traits()
        {
            return traits.Values
                .ToList()
                .OrderBy(trait => trait);
        }

        public IEnumerable<string> VictoryPointsValues()
        {
            return victoryPointsValues.Keys
                .OrderBy(value => value)
                .Select(value => victoryPointsValues[value]);
        }

        public IEnumerable<string> AttackStrengthValues()
        {
            return attackStrengthValues.Keys
                .OrderBy(value => value)
                .Select(value => attackStrengthValues[value]);
        }

        public IEnumerable<string> DefenseStrengthValues()
        {
            return defenseStrengthValues.Keys
                .OrderBy(value => value)
                .Select(value => defenseStrengthValues[value]);
        }

        public IEnumerable<string> HitPointsValues()
        {
            return hitPointsValues.Keys
                .OrderBy(value => value)
                .Select(value => hitPointsValues[value]);
        }

        public IEnumerable<string> WillpowerStrengthValues()
        {
            return willpowerStrengthValues.Keys
                .OrderBy(value => value)
                .Select(value => willpowerStrengthValues[value]);
        }

        public IEnumerable<string> ThreatStrengthValues()
        {
            return threatStrengthValues.Keys
                .OrderBy(value => value)
                .Select(value => threatStrengthValues[value]);
        }

        public IEnumerable<string> QuestPointsValues()
        {
            return questPointsValues.Keys
                .OrderBy(value => value)
                .Select(value => questPointsValues[value]);
        }
    }
}
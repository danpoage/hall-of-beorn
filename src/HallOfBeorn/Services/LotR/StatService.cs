using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class StatService
    {
        public StatService(CardRepository cardRepository)
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
                victoryPointsValues.Add(card.VictoryPoints, string.Format("Victory {0}.", card.VictoryPoints));
            }

            var attackKey = card.Attack.HasValue ? card.Attack.Value : (byte)0;
            var attackValue = card.Attack.HasValue ? card.Attack.Value.ToString() : string.Empty;
            if (card.IsVariableAttack)
            {
                attackKey = (byte)254;
                attackValue = "X";
            }
            else if (card.Attack.HasValue && card.Attack.Value == byte.MaxValue)
            {
                attackKey = byte.MaxValue;
                attackValue = "-";
            }

            if (card.Attack.HasValue && !attackStrengthValues.ContainsKey(attackKey))
            {
                attackStrengthValues.Add(attackKey, attackValue);
            }

            var defenseKey = card.Defense.HasValue ? card.Defense.Value : (byte)0;
            var defenseValue = card.Defense.HasValue ? card.Defense.Value.ToString() : string.Empty;
            if (card.IsVariableDefense)
            {
                defenseKey = (byte)254;
                defenseValue = "X";
            }
            else if (card.Defense.HasValue && card.Defense.Value == byte.MaxValue)
            {
                defenseKey = byte.MaxValue;
                defenseValue = "-";
            }

            if (card.Defense.HasValue && !defenseStrengthValues.ContainsKey(defenseKey))
            {
                defenseStrengthValues.Add(defenseKey, defenseValue);
            }

            byte hitPointsKey = 0; var hitPointsValue = string.Empty;
            if (card.IsVariableHitPoints)
            {
                hitPointsKey = (byte)254;
                hitPointsValue = "X";
            }
            else if (card.HitPoints.HasValue && card.HitPoints.Value == byte.MaxValue)
            {
                hitPointsKey = byte.MaxValue;
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
            if (card.IsVariableWillpower)
            {
                willpowerKey = (byte)254;
                willpowerValue = "X";
            }
            else if (card.Willpower.HasValue && card.Willpower.Value == byte.MaxValue)
            {
                willpowerKey = byte.MaxValue;
                willpowerValue = "-";
            }

            if (card.Willpower.HasValue && !willpowerStrengthValues.ContainsKey(willpowerKey))
            {
                willpowerStrengthValues.Add(willpowerKey, willpowerValue);
            }

            var threatKey = card.Threat.HasValue ? card.Threat.Value : (byte)0;
            var threatValue = card.Threat.HasValue ? card.Threat.Value.ToString() : string.Empty;
            if (card.IsVariableThreat)
            {
                threatKey = (byte)254;
                threatValue = "X";
            }
            else if (card.Threat.HasValue && card.Threat.Value == byte.MaxValue)
            {
                threatKey = byte.MaxValue;
                threatValue = "-";
            }

            if (card.Threat.HasValue && !threatStrengthValues.ContainsKey(threatKey))
            {
                threatStrengthValues.Add(threatKey, threatValue);
            }

            byte questPointsKey = 0; var questPointsValue = string.Empty;
            if (card.QuestPoints.HasValue && card.QuestPoints.Value == Models.Card.VALUE_X)
            {
                questPointsKey = Models.Card.VALUE_X;
                questPointsValue = "X";
            }
            else if (card.QuestPoints.HasValue && card.QuestPoints.Value == byte.MaxValue)
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
            return cards.Where(x => !string.IsNullOrEmpty(x.ResourceCost.Description(x.IsVariableCost))).OrderBy(x => x.ResourceCost).Select(x => x.ResourceCost.Description(x.IsVariableCost)).Distinct();
        }

        public IEnumerable<string> ThreatCosts()
        {
            return cards.Where(x => !string.IsNullOrEmpty(x.ThreatCost.Description(false))).OrderBy(x => x.ThreatCost).Select(x => x.ThreatCost.Description(false)).Distinct();
        }

        public IEnumerable<string> EngagementCosts()
        {
            return cards.Where(x => !string.IsNullOrEmpty(x.EngagementCost.Description(false))).OrderBy(x => x.EngagementCost).Select(x => x.EngagementCost.Description(false)).Distinct();
        }

        public IEnumerable<string> Keywords()
        {
            return keywords.Values.ToList().OrderBy(x => x);
        }

        public IEnumerable<string> Traits()
        {
            return traits.Values.ToList().OrderBy(x => x);
        }

        public IEnumerable<string> VictoryPointsValues()
        {
            return victoryPointsValues.Keys.OrderBy(x => x).Select(y => victoryPointsValues[y]);
        }

        public IEnumerable<string> AttackStrengthValues()
        {
            return attackStrengthValues.Keys.OrderBy(x => x).Select(y => attackStrengthValues[y]);
        }

        public IEnumerable<string> DefenseStrengthValues()
        {
            return defenseStrengthValues.Keys.OrderBy(x => x).Select(y => defenseStrengthValues[y]);
        }

        public IEnumerable<string> HitPointsValues()
        {
            return hitPointsValues.Keys.OrderBy(x => x).Select(y => hitPointsValues[y]);
        }

        public IEnumerable<string> WillpowerStrengthValues()
        {
            return willpowerStrengthValues.Keys.OrderBy(x => x).Select(y => willpowerStrengthValues[y]);
        }

        public IEnumerable<string> ThreatStrengthValues()
        {
            return threatStrengthValues.Keys.OrderBy(x => x).Select(y => threatStrengthValues[y]);
        }

        public IEnumerable<string> QuestPointsValues()
        {
            return questPointsValues.Keys.OrderBy(x => x).Select(y => questPointsValues[y]);
        }
    }
}
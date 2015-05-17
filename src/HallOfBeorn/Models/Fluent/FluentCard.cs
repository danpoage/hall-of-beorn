using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models.Fluent
{
    public class FluentCard
    {
        public FluentCard()
        {
            Stats = new Dictionary<StatType,byte>();
            Effects = new List<Effect>();
        }

        private FluentCard Unique()
        {
            Stats[StatType.Unique] = 1;
            return this;
        }

        private FluentCard ThreatCost(byte value)
        {
            Stats[StatType.Threat_Cost] = value;
            return this;
        }

        private FluentCard ResourceCost(byte value)
        {
            Stats[StatType.Resource_Cost] = value;
            return this;
        }

        private FluentCard EngagementCost(byte value)
        {
            Stats[StatType.Engagement_Cost] = value;
            return this;
        }

        private FluentCard Threat(byte value)
        {
            Stats[StatType.Threat] = value;
            return this;
        }

        private FluentCard Willpower(byte value)
        {
            Stats[StatType.Willpower] = value;
            return this;
        }

        private FluentCard Attack(byte value)
        {
            Stats[StatType.Attack] = value;
            return this;
        }

        private FluentCard Defense(byte value)
        {
            Stats[StatType.Defense] = value;
            return this;
        }

        private FluentCard HitPoints(byte value)
        {
            Stats[StatType.Hit_Points] = value;
            Traits = new List<string>();
            return this;
        }

        public string Title { get; private set; }
        public CardType Type { get; private set; }
        public Dictionary<StatType, byte> Stats { get; private set; }
        public List<string> Traits { get; private set; }
        public List<Effect> Effects { get; private set; }

        public static FluentCard Hero(string title, byte threatCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new FluentCard()
            {
                Title = title,
                Type = CardType.Hero
            }
            .Unique()
            .ThreatCost(threatCost)
            .Willpower(willpower)
            .Attack(attack)
            .Defense(defense)
            .HitPoints(hitPoints);
        }

        public static FluentCard UniqueAlly(string title, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return Ally(title, resourceCost, willpower, attack, defense, hitPoints).Unique();
        }

        public static FluentCard Ally(string title, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new FluentCard()
            {
                Title = title,
                Type = CardType.Ally
            }
            .ResourceCost(resourceCost)
            .Willpower(willpower)
            .Attack(attack)
            .Defense(defense)
            .HitPoints(hitPoints);
        }

        public FluentCard Block(CardEffect effectType)
        {
            //Effects.Add(Effect.New();
            return this;
        }

        public FluentCard Inline(CardEffectType effectType)
        {
            Effects.Add(new Effect(effectType, LayoutType.Inline));
            return this;
        }

        public FluentCard Important(CardEffectType effectType)
        {
            Effects.Add(new Effect(effectType, LayoutType.Important));
            return this;
        }

        public Card ToCard()
        {
            return new Card()
            {
            };
        }

        public string ToHtml()
        {
            var sb = new StringBuilder();
            var card = ToCard();

            foreach (var effect in Effects)
            {
                sb.Append(effect.ToHtml(card));
            }

            return sb.ToString();
        }

        public string ToText()
        {
            var sb = new StringBuilder();
            var card = ToCard();

            foreach (var effect in Effects)
            {
                sb.Append(effect.ToText(card));
            }

            return sb.ToString();
        }
    }
}
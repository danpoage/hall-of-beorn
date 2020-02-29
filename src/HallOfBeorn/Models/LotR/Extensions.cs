using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HallOfBeorn.Models.LotR
{
    public static class Extensions
    {
        private static readonly HashSet<CardType> objectiveCardTypes 
          = new HashSet<CardType> {
          CardType.Objective,
          CardType.Objective_Ally,
          CardType.Objective_Hero,
          CardType.Objective_Location,
        };

        public static bool HasTraits(this LotRCard self, params string[] text)
        {
            if (self == null)
                return false;

            Func<string, string> getCriteria = (criteria) => 
                criteria.EndsWith(".") ? criteria : criteria + ".";

            return text.All(
                value => self.Traits.Any(
                    trait => trait == getCriteria(value)));
        }

        public static bool HasTraitOrText(this LotRCard self, string text)
        {
            return self.HasTraits(text)
                || self.HasText(" " + text + ".") 
                || self.HasText(" " + text + " ");
        }

        public static bool IsPlayerCard(this LotRCard self)
        {
            return self != null && self.CardType.IsPlayerCard();
        }

        public static bool IsObjective(this LotRCard self)
        {
            return self != null && objectiveCardTypes.Contains(self.CardType);
        }

        public static bool HasText(this LotRCard self, string text)
        {
            return self.Text.ContainsLower(text)
                || self.OppositeText.ContainsLower(text);
        }

        public static ILink ToCharacterLink(this LotRCard self)
        {
            var description = self.Sphere.ToSlug() + " " + self.CardType.ToSlug();
            var title = string.Format("{0} ({1})", self.Title, description.Trim());

            return new Link(LinkType.Hall_of_Beorn_LotR_Image, self, title);
        }

        public static string ToSlug(this Sphere self)
        {
            return self != Sphere.None ? self.ToString() : string.Empty;
        }

        public static string ToSlug(this CardType self)
        {
            return self.ToString().Replace("_", "-");
        }

        public static int StatValue(this LotRCard self)
        {
            if (self == null)
                return 0;

            return self.ThreatCost.GetValueOrDefault(0)
                + self.ResourceCost.GetValueOrDefault(0)
                + self.Willpower.GetValueOrDefault(0)
                + self.Attack.GetValueOrDefault(0)
                + self.Defense.GetValueOrDefault(0)
                + self.HitPoints.GetValueOrDefault(0);
        }

        public static int ImportanceScore(this LotRCard self)
        {
            if (self == null)
                return 0;

            var count = 0;
            if (self.CardType.IsPlayerCard())
                count += 1;

            if (self.IsUnique)
                count += 2;

            if (self.CardType == CardType.Hero)
                count += self.StatValue() + 8;

            if (self.CardType == CardType.Ally)
                count += self.StatValue() + 5;

            if (self.CardType == CardType.Attachment 
                || self.CardType == CardType.Player_Side_Quest)
                count += 3;

            if (self.CardType == CardType.Event)
                count += 2;

            if (self.IsObjective())
                count += 2;

            if (self.CardType == CardType.Objective_Ally)
                count += self.StatValue() + 3;

            return count;
        }
    }
}

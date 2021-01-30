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

        public static bool IsCharacter(this LotRCard self)
        {
            var characterTypes = new HashSet<CardType> { CardType.Hero, CardType.Ally, CardType.Objective_Ally, CardType.Objective_Hero, CardType.Ship_Objective };

            return self != null && characterTypes.Contains(self.CardType);
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

            return self.ThreatCost.NormalizeStat()
                + self.ResourceCost.NormalizeStat()
                + self.Willpower.NormalizeStat()
                + self.Attack.NormalizeStat()
                + self.Defense.NormalizeStat()
                + self.HitPoints.NormalizeStat();
        }

        public static byte NormalizeStat(this byte? self)
        {
           return (!self.HasValue || self.Value == Card.VALUE_NA || self.Value == Card.VALUE_X || self.Value == Card.VALUE_ASTERISK)
               ? (byte)0
               : self.Value;
        }

        public static int ImportanceScore(this LotRCard self)
        {
            if (self == null)
                return 0;

            var count = 0;
            if (self.CardType.IsPlayerCard())
                count += 1;

            if (self.IsUnique)
                count += 6;

            if (self.CardType == CardType.Hero)
                count += self.StatValue() + 9;

            if (self.CardType == CardType.Ally)
                count += self.StatValue() + 7;

            if (self.CardType == CardType.Attachment)
                count += 5;

            if (self.CardType == CardType.Treasure
                || self.CardType == CardType.Player_Side_Quest)
                count += 3;

            if (self.CardType == CardType.Event)
                count += 1;

            if (self.IsObjective())
                count += self.StatValue() + 4;

            return count;
        }

        public static string ToCardTypeDescription(this CardType self)
        {
            switch (self)
            {
                case CardType.Encounter_Side_Quest:
                    return "Encounter Side Quest";
                case CardType.GenCon_Setup:
                case CardType.Nightmare_Setup:
                    return "Setup";
                case CardType.Player_Side_Quest:
                    return "Player Side Quest";
                default:
                    return self.ToString().Replace("_", "-");
            }
        }

        public static bool IsCommunity(this SetType self)
        {
            var community = new HashSet<SetType>
            {
                SetType.COMMUNITY, SetType.First_Age, SetType.A_Long_extended_Party
            };

            return community.Contains(self);
        }
    }
}

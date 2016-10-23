using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HallOfBeorn.Models.Arkham.ViewModels
{
    public class ArkhamSearchViewModel
    {
        private readonly List<ArkhamCardViewModel> cards = new List<ArkhamCardViewModel>();

        public string Query { get; set; }
        public ArkhamSearchSort? Sort { get; set; }
        public ArkhamSearchView? View { get; set; }

        public string Product { get; set; }

        public ArkhamCardType? CardType { get; set; }
        public ClassSymbol? CardClass { get; set; }
        public byte? Willpower { get; set; }
        public byte? Intellect { get; set; }
        public byte? Combat { get; set; }
        public byte? Agility { get; set; }
        public string Trait { get; set; }

        public string Shroud { get; set; }
        public string ClueValue { get; set; }
        public ConnectionSymbol? LocationSymbol { get; set; }
        public ConnectionSymbol? ConnectsTo { get; set; }
        public string FightValue { get; set; }
        public string HealthValue { get; set; }
        public string EvadeValue { get; set; }
        public string Damage { get; set; }
        public string Horror { get; set; }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(ArkhamSearchSort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(ArkhamSearchView).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(ArkhamCardType).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> CardClasses
        {
            get { return typeof(ClassSymbol).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> ConnectionSymbols
        {
            get { return typeof(ConnectionSymbol).GetSelectListItems(" "); }
        }

        private static readonly Dictionary<Skill, IEnumerable<SelectListItem>> valuesBySkill = new Dictionary<Skill, IEnumerable<SelectListItem>>();
        public static IEnumerable<SelectListItem> WillpowerValues
        {
            get { return valuesBySkill[Skill.Willpower]; }
        }
        public static IEnumerable<SelectListItem> IntellectValues
        {
            get { return valuesBySkill[Skill.Intellect]; }
        }
        public static IEnumerable<SelectListItem> CombatValues
        {
            get { return valuesBySkill[Skill.Combat]; }
        }
        public static IEnumerable<SelectListItem> AgilityValues
        {
            get { return valuesBySkill[Skill.Agility]; }
        }
        public static void LoadSkillValues(Skill skill, IEnumerable<SelectListItem> values)
        {
            valuesBySkill[skill] = values;
        }

        private static Dictionary<StatType, IEnumerable<SelectListItem>> statsByType = new Dictionary<StatType, IEnumerable<SelectListItem>>();
        public static IEnumerable<SelectListItem> FightValues
        {
            get { return statsByType[StatType.FightValue]; }
        }
        public static IEnumerable<SelectListItem> HealthValues
        {
            get { return statsByType[StatType.HealthValue]; }
        }
        public static IEnumerable<SelectListItem> EvadeValues
        {
            get { return statsByType[StatType.EvadeValue]; }
        }
        public static IEnumerable<SelectListItem> DamageValues
        {
            get { return statsByType[StatType.Damage]; }
        }
        public static IEnumerable<SelectListItem> HorrorValues
        {
            get { return statsByType[StatType.Horror]; }
        }
        public static IEnumerable<SelectListItem> ShroudValues
        {
            get { return statsByType[StatType.Shroud]; }
        }
        public static IEnumerable<SelectListItem> ClueValues
        {
            get { return statsByType[StatType.ClueValue]; }
        }
        public static void LoadCardStats(StatType type, IEnumerable<SelectListItem> values)
        {
            statsByType[type] = values;
        }

        private static readonly List<SelectListItem> traits = new List<SelectListItem>();
        public static IEnumerable<SelectListItem> Traits
        {
            get { return traits; }
        }
        public static void LoadTraits(IEnumerable<SelectListItem> t)
        {
            traits.Clear();
            traits.AddRange(t);
        }

        private static readonly List<SelectListItem> products = new List<SelectListItem>();
        public static IEnumerable<SelectListItem> Products
        {
            get { return products; }
        }
        public static void LoadProducts(IEnumerable<SelectListItem> prods)
        {
            products.Clear();
            products.AddRange(prods);
        }

        public List<ArkhamCardViewModel> Cards()
        {
            return cards;
        }
        public void LoadCards(IEnumerable<ArkhamCardViewModel> cards)
        {
            this.cards.Clear();
            this.cards.AddRange(cards);
        }

        public string GetResultsCount()
        {
            if (cards.Count == 0)
            {
                return "No results";
            }

            return cards.Count == 1 ? "1 result" : string.Format("{0} results", cards.Count);
        }
    }
}
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
        public string EncounterSet { get; set; }

        public ArkhamCardType? CardType { get; set; }
        public ArkhamCardSubtype? CardSubtype { get; set; }
        public ArkhamDeckType? DeckType { get; set; }
        public ClassSymbol? ClassSymbol { get; set; }
        public Uniqueness? IsUnique { get; set; }
        public SkillIcon? SkillIcon { get; set; }
        public AssetSlot? Slot { get; set; }

        public NumericOperator? WillpowerOp { get; set; }
        public byte? Willpower { get; set; }
        public NumericOperator? IntellectOp { get; set; }
        public byte? Intellect { get; set; }
        public NumericOperator? CombatOp { get; set; }
        public byte? Combat { get; set; }
        public NumericOperator? AgilityOp { get; set; }
        public byte? Agility { get; set; }
        public NumericOperator? HealthOp { get; set; }
        public string Health { get; set; }
        public NumericOperator? SanityOp { get; set; }
        public string Sanity { get; set; }
        public NumericOperator? CostOp { get; set; }
        public string Cost { get; set; }
        public NumericOperator? LevelOp { get; set; }
        public string Level { get; set; }


        public string Trait { get; set; }
        public string Keyword { get; set; }
        public string VictoryPoints { get; set; }

        public NumericOperator? ShroudOp { get; set; }
        public string Shroud { get; set; }
        public NumericOperator? ClueValueOp { get; set; }
        public string ClueValue { get; set; }
        public ConnectionSymbol? LocationSymbol { get; set; }
        public ConnectionSymbol? ConnectsTo { get; set; }
        public NumericOperator? EnemyFightValueOp { get; set; }
        public string EnemyFightValue { get; set; }
        public NumericOperator? EnemyHealthValueOp { get; set; }
        public string EnemyHealthValue { get; set; }
        public NumericOperator? EnemyEvadeValueOp { get; set; }
        public string EnemyEvadeValue { get; set; }
        public NumericOperator? DamageOp { get; set; }
        public string Damage { get; set; }
        public NumericOperator? HorrorOp { get; set; }
        public string Horror { get; set; }
        public NumericOperator? DoomThresholdOp { get; set; }
        public string DoomThreshold { get; set; }
        public NumericOperator? ClueThresholdOp { get; set; }
        public string ClueThreshold { get; set; }

        public string Artist { get; set; }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(ArkhamSearchSort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(ArkhamSearchView).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> NumericOperators
        {
            get {
                Func<NumericOperator, string> mapFunction = (n) =>
                {
                    switch (n) {
                        case NumericOperator.eq:
                        default:
                            return "=";
                        case NumericOperator.gt:
                            return ">";
                        case NumericOperator.gteq:
                            return ">=";
                        case NumericOperator.lt:
                            return "<";
                        case NumericOperator.lteq:
                            return "<=";
                    }
                };
                return typeof(NumericOperator).GetSelectListItems<NumericOperator>(mapFunction); 
            }
        }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(ArkhamCardType).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> CardSubtypes
        {
            get { return typeof(ArkhamCardSubtype).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> EncounterSets
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> DeckTypes
        {
            get { return typeof(ArkhamDeckType).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> UniquenessValues
        {
            get { return typeof(Uniqueness).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> ClassSymbolValues
        {
            get { return typeof(ClassSymbol).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> ConnectionSymbols
        {
            get { return typeof(ConnectionSymbol).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> HealthValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> SanityValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> CostValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> DoomThresholdValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> ClueThresholdValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> LevelValues
        {
            get { return new List<string>{ "0", "1", "2", "3", "4", "5" }.GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> SkillIconValues
        {
            get { return typeof(SkillIcon).GetSelectListItems(" "); }
        }

        public static IEnumerable<SelectListItem> SlotValues
        {
            get { return typeof(AssetSlot).GetSelectListItems(" "); }
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
        public static IEnumerable<SelectListItem> EnemyFightValues
        {
            get { return statsByType[StatType.FightValue]; }
        }
        public static IEnumerable<SelectListItem> EnemyHealthValues
        {
            get { return statsByType[StatType.HealthValue]; }
        }
        public static IEnumerable<SelectListItem> EnemyEvadeValues
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
            get;
            set;
        }

        private static readonly List<SelectListItem> keywords = new List<SelectListItem>();
        public static IEnumerable<SelectListItem> Keywords
        {
            get;
            set;
        }

        private static readonly List<SelectListItem> products = new List<SelectListItem>();
        public static IEnumerable<SelectListItem> Products
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> VictoryPointsValues
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> ArtistValues
        {
            get;
            set;
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
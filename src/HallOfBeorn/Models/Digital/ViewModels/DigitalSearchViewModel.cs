using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn.Models.Digital.ViewModels
{
    public class DigitalSearchViewModel
    {
        public string Query { get; set; }

        public DigitalSort? Sort { get; set; }
        public DigitalView? View { get; set; }

        public string CardSet { get; set; }
        public DigitalCardType? CardType { get; set; }
        public DigitalSphere? Sphere { get; set; }

        public DigitalTrait? Trait { get; set; }
        public DigitalKeyword? Keyword { get; set; }
        public AttachmentSlot? Slot { get; set; }
        public DigitalRarity? Rarity { get; set; }

        public NumericOperator? CostOperator { get; set; }
        public string Cost { get; set; }

        public NumericOperator? ThreatCostOperator { get; set; }
        public string ThreatCost { get; set; }

        public NumericOperator? AttackOp { get; set; }
        public string Attack { get; set; }

        public NumericOperator? WillpowerOp { get; set; }
        public string Willpower { get; set; }

        public NumericOperator? HitPointsOp { get; set; }
        public string HitPoints { get; set; }

        public List<DigitalCardViewModel> Cards { get; set; }

        //public List<DigitalProductViewModel> Products { get; set; }

        //public List<CharacterViewModel> Characters { get; set; }

        public void Initialize()
        {
            if (Sort != null && Sort == DigitalSort.None)
                Sort = null;

            if (View != null && View == DigitalView.None)
                View = null;

            if (CardSet != null && (CardSet == "Any" || CardSet == "None"))
                CardSet = null;

            if (CardType != null && CardType == DigitalCardType.None)
                CardType = null;

            if (Sphere != null && Sphere == DigitalSphere.Any)
                Sphere = null;

            if (Trait != null && Trait == DigitalTrait.None)
                Trait = null;

            if (Keyword != null && Keyword == DigitalKeyword.None)
                Keyword = null;

            if (Slot != null && Slot == AttachmentSlot.None)
                Slot = null;

            if (Rarity != null && Rarity == DigitalRarity.None)
                Rarity = null;

            if (ThreatCost != null && ThreatCost == "Any")
            {
                ThreatCost = null;
                ThreatCostOperator = null;
            }

            if (Cost != null && Cost == "Any")
            {
                Cost = null;
                CostOperator = null;
            }

            if (Attack != null && Attack == "Any")
            {
                Attack = null;
                AttackOp = null;
            }

            if (Willpower != null && Willpower == "Any")
            {
                Willpower = null;
                WillpowerOp = null;
            }

            if (HitPoints != null && HitPoints == "Any")
            {
                HitPoints = null;
                HitPointsOp = null;
            }
        }

        public string GetResultsCount() {
            if (Cards == null || Cards.Count == 0)
                return "No Results";

            return Cards.Count > 1 ? string.Format("{0} Results", Cards.Count) : "1 Result";
        }

        public bool? IsCardView { get; set; }
        public bool? IsProductView { get; set; }
        public bool? IsCharacterView { get; set; }

        public static IEnumerable<SelectListItem> Slots
        {
            get { return typeof(AttachmentSlot).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> ThreatCosts
        {
            get { return new List<string>{"8","9", "10", "11"}.GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> ResourceCosts
        {
            get { return new List<string>{"0", "1", "2", "3", "4", "5"}.GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> AttackValues
        {
            get { return new List<string>{"0","1", "2"}.GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> WillpowerValues
        {
            get { return new List<string>{"0", "1", "2", "3"}.GetSelectListItems(); }
        }

                public static IEnumerable<SelectListItem> HitPointsValues
        {
            get { return new List<string>{"2", "3", "4", "5", "6", "8", "9", "10", "11"}.GetSelectListItems(); }
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

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(DigitalSort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(DigitalView).GetSelectListItems(); }
        }
        
        public static IEnumerable<SelectListItem> CardSets
        {
            get { return new List<string>{
                "Starter", 
                //"Valor Cards", 
                "Dwalin Pack", "Eowyn Pack", "Faramir Pack", "Legolas Pack" 
            }.GetSelectListItems(); }
        }
        
        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(DigitalCardType).GetSelectListItems(); }
        }
        
        public static IEnumerable<SelectListItem> Spheres
        {
            get { return typeof(DigitalSphere).GetSelectListItems(); }
        }
        
        public static IEnumerable<SelectListItem> Traits
        {
            get { return typeof(DigitalTrait).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Keywords
        {
            get { return typeof(DigitalKeyword).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Rarities
        {
            get { return typeof(DigitalRarity).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Levels
        {
            get { return new string[]{"1", "2", "3"}.GetSelectListItems(); }
        }
    }
}

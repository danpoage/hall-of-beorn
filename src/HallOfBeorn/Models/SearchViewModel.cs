using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using HallOfBeorn.Models.Search;

namespace HallOfBeorn.Models
{
    public class FilterViewModel
    {
        [Display(Name="Search")]
        public string Query { get; set; }

        [Display(Name="Type")]
        public CardType CardType { get; set; }

        [Display(Name = "Set")]
        public string CardSet { get; set; }
    }

    public class SearchViewModel
    {
        public SearchViewModel()
        {
        }

        public Func<Scenario> GetScenario { get; set; }

        public void Initialize()
        {
            /*
            definitions.Add(new QueryFilterDefinition());

            definitions.Add(new SimpleFilterDefinition("Card Set", (m) => { return m.CardSet; }, (s, c) => { return s.CardSetMatches(c); }, 100));
            definitions.Add(new SimpleFilterDefinition("Scenario", (m) => { return m.Scenario; }, (s, c) => { return c.BelongsToScenario(s.GetScenario()); }, 100));
            definitions.Add(new SimpleFilterDefinition("Encounter Set", (m) => { return m.EncounterSet; }, (s, c) => { return c.EncounterSet == s.EncounterSet; }, 100));

            definitions.Add(new EnumFilterDefinition("Card Type", (m) => { return m.CardType.Value; }, (s, c) => { return s.CardTypeMatches(c); }, 100));
            definitions.Add(new EnumFilterDefinition("Card Subtype", (m) => { return m.CardSubtype.Value; }, (s, c) => { return s.CardTypeMatches(c); }, 100));
            definitions.Add(new EnumFilterDefinition("Deck Type", (m) => { return m.DeckType.Value; }, (s, c) => { return s.DeckType.Value == c.GetDeckType(); }, 100));

            definitions.Add(new EnumFilterDefinition("Sphere", (m) => { return m.Sphere; }, (s, c) => { return s.Sphere.Value == c.Sphere; }, 100));
            definitions.Add(new SimpleFilterDefinition("Unique", (m) => { return m.IsUnique; }, (s, c) => { return c.IsUnique == (s.IsUnique != null && s.IsUnique == Uniqueness.Yes); }, 100));
            definitions.Add(new EnumFilterDefinition("Set Type", (m) => { return m.SetType; }, (s, c) => { return (s.SetType == Models.SetType.OFFICIAL && c.CardSet.SetType != Models.SetType.CUSTOM) || (s.SetType.Value == c.CardSet.SetType); }, 100));
            */

            /*
            //definitions.Add(new EnumFilterDefinition("Scenario", (m) => { return m.Scenario; }, (s, c) => { return s.Scenario == c.ScenarioTitle; }));
            definitions.Add(new EnumFilterDefinition("Encounter Set", (m) => { return m.EncounterSet; }));

            definitions.Add(new EnumFilterDefinition("Card Type", (m) => { return m.CardType; }));
            definitions.Add(new EnumFilterDefinition("Card Subtype", (m) => { return m.CardSubtype; }));
            definitions.Add(new EnumFilterDefinition("Deck Type", (m) => { return m.DeckType; }));

            definitions.Add(new EnumFilterDefinition("Sphere", (m) => { return m.Sphere; }));
            definitions.Add(new FilterDefinition("Unique", (m) => { return m.IsUnique; }));
            definitions.Add(new FilterDefinition("Set Type", (m) => { return m.SetType; }));

            definitions.Add(new FilterDefinition("Cost", (m) => { return m.Cost; }, (m) => { return m.CostOperator; }));
            definitions.Add(new FilterDefinition("ThreatCost", (m) => { return m.ThreatCost; }, (m) => { return m.ThreatCostOperator; }));
            definitions.Add(new FilterDefinition("EngagementCost", (m) => { return m.EngagementCost; }, (m) => { return m.EngagementCostOperator; }));
            
            definitions.Add(new FilterDefinition("Attack", (m) => { return m.Attack; }, (m) => { return m.AttackOp; }));
            definitions.Add(new FilterDefinition("Defense", (m) => { return m.Defense; }, (m) => { return m.DefenseOp; }));
            definitions.Add(new FilterDefinition("HitPoints", (m) => { return m.HitPoints; }, (m) => { return m.HitPointsOp; }));
            
            definitions.Add(new FilterDefinition("Willpower", (m) => { return m.Willpower; }, (m) => { return m.WillpowerOp; }));
            definitions.Add(new FilterDefinition("Threat", (m) => { return m.Threat; }, (m) => { return m.ThreatOp; }));
            definitions.Add(new FilterDefinition("Quest Points", (m) => { return m.QuestPoints; }, (m) => { return m.QuestPointsOp; }));

            definitions.Add(new FilterDefinition("Trait", (m) => { return m.Trait; }));
            definitions.Add(new FilterDefinition("Keyword", (m) => { return m.Keyword; }));
            definitions.Add(new FilterDefinition("Victory Points", (m) => { return m.VictoryPoints; }));

            definitions.Add(new FilterDefinition("Player Card Category", (m) => { return m.Category; }));
            definitions.Add(new FilterDefinition("Encounter Card Category", (m) => { return m.EncounterCategory; }));
            definitions.Add(new FilterDefinition("Quest Card Category", (m) => { return m.QuestCategory; }));

            definitions.Add(new FilterDefinition("Artist", (m) => { return m.Artist; }));
            */
        }

        private readonly List<FilterDefinition> definitions = new List<FilterDefinition>();

        public bool HasValues()
        {
            return definitions.Any(x => x.HasValue(this));
        }

        public List<SearchFilter> Filters()
        {
            var filters = new List<SearchFilter>();

            foreach (var def in definitions)
            {
                if (def.HasValue(this))
                {
                    filters.AddRange(def.Filters(this));
                }
            }

            return filters;
        }

        public const string DEFAULT_FILTER_VALUE = "Any";
        public const string RANDOM_KEYWORD = "+random";

        [Display(Name = "Search")]
        public string Query { get; set; }

        [Display(Name = "Type")]
        public CardType? CardType { get; set; }

        [Display(Name = "Subtype")]
        public CardSubtype? CardSubtype { get; set; }

        [Display(Name="Deck Type")]
        public DeckType? DeckType { get; set; }

        [Display(Name = "Set")]
        public string CardSet { get; set; }

        [Display(Name="Scenario")]
        public string Scenario { get; set; }

        [Display(Name = "Trait")]
        public string Trait { get; set; }

        [Display(Name = "Keyword")]
        public string Keyword { get; set; }

        [Display(Name = "Cost")]
        public string Cost { get; set; }

        [Display(Name = "Cost Operator")]
        public NumericOperator? CostOperator { get; set; }

        [Display(Name = "Threat Cost")]
        public string ThreatCost { get; set; }

        [Display(Name = "Threat Cost Operator")]
        public NumericOperator? ThreatCostOperator { get; set; }

        [Display(Name = "Engagement Cost")]
        public string EngagementCost { get; set; }

        [Display(Name = "Engagement Cost Operator")]
        public NumericOperator? EngagementCostOperator { get; set; }

        [Display(Name = "Attack Strength")]
        public string Attack { get; set; }

        [Display(Name = "Attack Strength Operator")]
        public NumericOperator? AttackOp { get; set; }

        [Display(Name = "Defense Strength")]
        public string Defense { get; set; }

        [Display(Name = "Defense Strength Operator")]
        public NumericOperator? DefenseOp { get; set; }

        [Display(Name = "Hit Points")]
        public string HitPoints { get; set; }

        [Display(Name = "Hit Points Operator")]
        public NumericOperator? HitPointsOp { get; set; }

        [Display(Name = "Willpower Strength")]
        public string Willpower { get; set; }

        [Display(Name = "Willpower Strength Operator")]
        public NumericOperator? WillpowerOp { get; set; }

        [Display(Name = "Threat Strength")]
        public string Threat { get; set; }

        [Display(Name = "Threat Strength Operator")]
        public NumericOperator? ThreatOp { get; set; }

        [Display(Name = "Quest Points")]
        public string QuestPoints { get; set; }

        [Display(Name = "Quest Points Operator")]
        public NumericOperator? QuestPointsOp { get; set; }

        [Display(Name = "Sphere")]
        public Sphere? Sphere { get; set; }

        //[Display(Name = "Unique")]
        //public bool Unique { get; set; }

        [Display(Name = "Unique")]
        public Uniqueness? IsUnique { get; set; }

        [Display(Name = "Set Type")]
        public SetType? SetType { get; set; }

        [Display(Name = "Sort")]
        public Sort? Sort { get; set; }

        [Display(Name = "View")]
        public View? View { get; set; }

        public bool IsCardView()
        {
            return (!View.HasValue || (View != Models.View.Product));
        }

        public bool IsProductView()
        {
            return (View.HasValue && View == Models.View.Product);
        }

        [Display(Name = "Artist")]
        public string Artist { get; set; }

        [Display(Name="Encounter Set")]
        public string EncounterSet { get; set; }

        [Display(Name="Player Category")]
        public string Category { get; set; }

        [Display(Name="Player Card Popularity")]
        public string Popularity { get; set; }

        [Display(Name = "Popularity Operator")]
        public NumericOperator? PopularityOp { get; set; }

        public static IEnumerable<SelectListItem> PopularityValues
        {
            get
            {
                return new List<byte>()
                {
                    1, 2, 3, 4, 5
                }.GetSelectListItems();
            }
        }

        public string ItemWidth()
        {
            if (this.View.HasValue && View == Models.View.Card_Image)
            {
                return "200px;";
            }
            else return "80%";
        }

        public Category GetCategory()
        {
            var category = HallOfBeorn.Models.Category.None;
            if (string.IsNullOrEmpty(this.Category))
                return category;

            var decoded = HttpUtility.HtmlDecode(this.Category).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.Category>(decoded, true, out category);
            
            return category;
        }

        [Display(Name="Encounter Category")]
        public string EncounterCategory { get; set; }

        public EncounterCategory GetEncounterCategory()
        {
            var encCategory = HallOfBeorn.Models.EncounterCategory.None;
            if (string.IsNullOrEmpty(this.EncounterCategory))
                return encCategory;

            var decoded = HttpUtility.HtmlDecode(this.EncounterCategory).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.EncounterCategory>(decoded, true, out encCategory);

            return encCategory;
        }

        [Display(Name = "Quest Category")]
        public string QuestCategory { get; set; }

        public QuestCategory GetQuestCategory()
        {
            var questCategory = HallOfBeorn.Models.QuestCategory.None;
            if (string.IsNullOrEmpty(this.QuestCategory))
                return questCategory;

            var decoded = HttpUtility.HtmlDecode(this.QuestCategory).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.QuestCategory>(decoded, true, out questCategory);

            return questCategory;
        }

        public bool IsRandom()
        {
            return (!string.IsNullOrEmpty(this.Query) && this.Query.ContainsLower(RANDOM_KEYWORD)) || (this.Random.HasValue && this.Random.Value);
        }

        public List<CardViewModel> Cards { get; set; }

        public List<ProductViewModel> Products { get; set; }

        //[Display(Name = "Custom")]
        //public bool Custom { get; set; }

        [Display(Name = "Victory")]
        public string VictoryPoints { get; set; }

        public bool? Random { get; set; }

        public HasShadow? HasShadow { get; set; }

        public string Quest { get; set; }

        public bool HasQuest()
        {
            return !string.IsNullOrEmpty(this.Quest);
        }

        public bool HasQuery()
        {
            return !string.IsNullOrEmpty(this.Query);
        }

        public bool HasCardType()
        {
            return this.CardType.HasValue && this.CardType.Value != Models.CardType.None;
        }

        public bool HasCardSubtype()
        {
            return this.CardSubtype.HasValue && this.CardSubtype.Value != Models.CardSubtype.None;
        }

        public bool HasDeckType()
        {
            return this.DeckType.HasValue && this.DeckType.Value != Models.DeckType.None;
        }

        public bool HasCardSet()
        {
            return !string.IsNullOrEmpty(this.CardSet) && this.CardSet != DEFAULT_FILTER_VALUE;
        }

        public bool HasScenario()
        {
            return !string.IsNullOrEmpty(this.Scenario) && this.Scenario != DEFAULT_FILTER_VALUE;
        }

        public bool HasTrait()
        {
            return !string.IsNullOrEmpty(this.Trait) && this.Trait != DEFAULT_FILTER_VALUE;
        }

        public bool HasKeyword()
        {
            return !string.IsNullOrEmpty(this.Keyword) && this.Keyword != DEFAULT_FILTER_VALUE;
        }

        public bool HasSphere()
        {
            return this.Sphere.HasValue && this.Sphere.Value != Models.Sphere.None;
        }

        public bool HasCategory()
        {
            return this.GetCategory() != Models.Category.None;
        }

        public bool HasEncounterCategory()
        {
            return this.GetEncounterCategory() != Models.EncounterCategory.None;
        }

        public bool HasQuestCategory()
        {
            return this.GetQuestCategory() != Models.QuestCategory.None;
        }

        public bool HasResourceCost()
        {
            return !string.IsNullOrEmpty(this.Cost) && this.Cost != DEFAULT_FILTER_VALUE;
        }

        public bool HasThreatCost()
        {
            return !string.IsNullOrEmpty(this.ThreatCost) && this.ThreatCost != DEFAULT_FILTER_VALUE;
        }

        public bool HasEngagementCost()
        {
            return !string.IsNullOrEmpty(this.EngagementCost) && this.EngagementCost != DEFAULT_FILTER_VALUE;
        }

        public bool HasHitPoints()
        {
            return !string.IsNullOrEmpty(this.HitPoints) && this.HitPoints != DEFAULT_FILTER_VALUE;
        }

        public bool HasArtist()
        {
            return !string.IsNullOrEmpty(this.Artist) && this.Artist != DEFAULT_FILTER_VALUE;
        }

        public bool HasEncounterSet()
        {
            return !string.IsNullOrEmpty(this.EncounterSet) && this.EncounterSet != DEFAULT_FILTER_VALUE;
        }

        public bool HasVictoryPoints()
        {
            return !string.IsNullOrEmpty(this.VictoryPoints) && this.VictoryPoints != DEFAULT_FILTER_VALUE;
        }

        public bool HasFilter()
        {
            if (HasQuery())
                return true;

            if (HasCardType())
                return true;

            if (HasCardSet())
                return true;

            if (HasTrait())
                return true;

            if (HasKeyword())
                return true;

            if (HasSphere())
                return true;

            if (HasCategory())
                return true;

            if (HasResourceCost())
                return true;

            //if (this.Unique)
            //    return true;

            if (this.IsUnique.HasValue && this.IsUnique.Value != Uniqueness.Any)
                return true;

            if (HasArtist())
                return true;

            if (HasEncounterSet())
                return true;

            if (HasVictoryPoints())
                return true;

            return false;
        }

        public bool CardTypeMatches(Card card)
        {
            if (!CardType.HasValue)
            {
                return false;
            }

            if (CardType.Value == Models.CardType.Player)
            {
                return card.CardType == Models.CardType.Hero || card.CardType == Models.CardType.Ally || card.CardType == Models.CardType.Attachment || card.CardType == Models.CardType.Event || card.CardType == Models.CardType.Player_Side_Quest;
            }
            else if (CardType.Value == Models.CardType.Character)
            {
                return card.CardType == Models.CardType.Hero || card.CardType == Models.CardType.Ally || card.CardType == Models.CardType.Objective_Ally || (card.CardType == Models.CardType.Objective && card.HitPoints > 0);
            }
            else if (CardType.Value == Models.CardType.Encounter)
            {
                return card.CardType == Models.CardType.Enemy || card.CardType == Models.CardType.Location || card.CardType == Models.CardType.Treachery || card.CardType == Models.CardType.Objective || card.CardType == Models.CardType.Objective_Ally || card.CardType == Models.CardType.Objective_Location || card.CardType == Models.CardType.Encounter_Side_Quest || card.CardType == Models.CardType.Ship_Objective || card.CardType == Models.CardType.Ship_Enemy;
            }
            else if (CardType.Value == Models.CardType.Objective)
            {
                return card.CardType == Models.CardType.Objective || card.CardType == Models.CardType.Objective_Ally;
            }
            else
                return CardType == card.CardType;
        }

        public bool CardSetMatches(Card card)
        {
            return card.CardSet.Name == this.CardSet || (!string.IsNullOrEmpty(card.CardSet.AlternateName) && card.CardSet.AlternateName == this.CardSet) || (!string.IsNullOrEmpty(card.CardSet.NormalizedName) && card.CardSet.NormalizedName == this.CardSet) || (!string.IsNullOrEmpty(card.CardSet.Cycle) && card.CardSet.Cycle.ToUpper() == this.CardSet);
        }

        public bool CardIsCustom(Card card)
        {
            /*
            if ((this.CardSet == null || this.CardSet == "Any") 
                && (this.EncounterSet == null || this.EncounterSet == "Any") 
                && this.Sphere != Sphere.Mastery 
                && (this.Trait == null || this.Trait == "Any") 
                && (this.Keyword == null || this.Keyword == "Any")
                && (this.Attack == null || this.Attack == "Any")
                && (this.Defense == null || this.Defense == "Any")
                && (this.HitPoints == null || this.HitPoints == "Any")
                && (this.Willpower == null || this.Willpower == "Any")
                && (this.Threat == null || this.Threat == "Any"))
            {
                return card.CardSet.SetType == SetType.CUSTOM;
            }

            return false;*/

            return card.CardSet.SetType == Models.SetType.CUSTOM;
        }

        public bool VictoryPointsMatch(Card card)
        {
            if (!HasVictoryPoints())
                return false;

            byte victoryPoints = 0;
            if (byte.TryParse(this.VictoryPoints.Replace("Victory", string.Empty).Trim('.'), out victoryPoints))
            {
                return card.VictoryPoints == victoryPoints;
            }

            return false;
        }

        public bool IsAdvancedSearch()
        {
            if (string.IsNullOrEmpty(this.Query))
                return false;

            return (this.Query.StartsWith("-") || this.Query.StartsWith("+") || this.Query.Contains(" -") || this.Query.Contains(" +"));
        }

        private string basicQuery;

        public string BasicQuery()
        {
            if (basicQuery == null)
            {
                if (IsAdvancedSearch())
                {
                    var parts = this.Query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => !x.StartsWith("-") && !x.StartsWith("+") && !x.StartsWith("~")).ToListSafe();

                    if (parts.Count == 0)
                        return string.Empty;

                    basicQuery = string.Join(" ", parts).ToLowerSafe();
                }
                else
                {
                    basicQuery = this.Query.ToLowerSafe();
                }
            }

            return basicQuery;
        }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(CardType).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> CardSubtypes
        {
            get { return typeof(CardSubtype).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> DeckTypes
        {
            get { return typeof(DeckType).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> GameTypes { get; set; }

        public static IEnumerable<SelectListItem> Keywords
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> Traits
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> Categories
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> EncounterCategories
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> QuestCategories
        {
            get;
            set;
        }

        //Core Set
        public bool? MEC01 { get; set; }

        //Shadows of Mirkwood
        //public bool? MESOM { get; set; }
        
        public bool? MEC02 { get; set; }
        public bool? MEC03 { get; set; }
        public bool? MEC04 { get; set; }
        public bool? MEC05 { get; set; }
        public bool? MEC06 { get; set; }
        public bool? MEC07 { get; set; }
        
        //Khazad-dum
        public bool? MEC08 { get; set; }

        //Dwarrowdelf
        //public bool? MEDWD { get; set; }

        public bool? MEC09 { get; set; }
        public bool? MEC10 { get; set; }
        public bool? MEC11 { get; set; }
        public bool? MEC12 { get; set; }
        public bool? MEC13 { get; set; }
        public bool? MEC14 { get; set; }
        
        //Heirs of Numenor
        public bool? MEC17 { get; set; }

        //Against the Shadow
        //public bool? MEATS { get; set; }

        public bool? MEC18 { get; set; }
        public bool? MEC19 { get; set; }
        public bool? MEC20 { get; set; }
        public bool? MEC21 { get; set; }
        public bool? MEC22 { get; set; }
        public bool? MEC23 { get; set; }
        
        //The Voice of Isengard
        public bool? MEC25 { get; set; }

        //Ring-maker
        //public bool? MERMK { get; set; }

        public bool? MEC26 { get; set; }
        public bool? MEC27 { get; set; }
        public bool? MEC28 { get; set; }
        public bool? MEC29 { get; set; }
        public bool? MEC30 { get; set; }
        public bool? MEC31 { get; set; }

        //The Lost Realm
        public bool? MEC38 { get; set; }

        //Angmar Awakened
        //public bool? MEAAW { get; set; }

        public bool? MEC39 { get; set; }
        public bool? MEC40 { get; set; }
        public bool? MEC41 { get; set; }
        public bool? MEC42 { get; set; }
        public bool? MEC43 { get; set; }
        public bool? MEC44 { get; set; }

        //The Grey Havens
        public bool? MEC47 { get; set; }

        //The Dream-chaser
        //public bool? MEDCH { get; set; }

        //The Hobbit
        //public bool? MEHOB { get; set; }
        public bool? MEC16 { get; set; }
        public bool? MEC24 { get; set; }
        
        //The Lord of the Rings
        //public bool? MELTR { get; set; }
        public bool? MEC32 { get; set; }
        public bool? MEC34 { get; set; }
        public bool? MEC45 { get; set; }
        public bool? MEC46 { get; set; }

        //First Age
        public bool? FA01 { get; set; }
        public bool? FA02 { get; set; }
        public bool? FA03 { get; set; }

        public string GetResultsCount()
        {
            var count = 0;

            if (!View.HasValue || View != Models.View.Product)
            {
                count = Cards != null ? Cards.Count : 0;
            }
            else if (View.HasValue && View == Models.View.Product)
            {
                count = Products != null ? Products.Count : 0;
            }
            
            switch (count)
            {
                case 0:
                    return "No Results Found";
                case 1:
                    return "1 Result Found";
                default:
                    return string.Format("{0} Results Found", count);
            }
        }

        public static IEnumerable<SelectListItemExtends> CardSets { get; set; }
        public static IEnumerable<SelectListItem> Scenarios { get; set; }
        public static IEnumerable<SelectListItem> EncounterSets { get; set; }

        public static IEnumerable<SelectListItem> ResourceCosts { get; set; }
        public static IEnumerable<SelectListItem> ThreatCosts { get; set; }
        public static IEnumerable<SelectListItem> EngagementCosts { get; set; }

        public static IEnumerable<SelectListItem> AttackStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> DefenseStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> HitPointsValues { get; set; }
        public static IEnumerable<SelectListItem> WillpowerStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> ThreatStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> QuestPointsValues { get; set; }

        public static IEnumerable<SelectListItem> Spheres
        {
            get { return typeof(Sphere).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(Sort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(View).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> UniquenessValues
        {
            get { return typeof(Uniqueness).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> SetTypeValues
        {
            get { return typeof(SetType).GetSelectListItems(); }
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

        public static IEnumerable<SelectListItem> Artists
        {
            get
            {
                yield return new SelectListItem { Text = "Any", Value = "Any" };

                foreach (var artist in HallOfBeorn.Models.Artist.All())
                    yield return new SelectListItem { Text = artist.Name, Value = artist.Name };
            }
        }

        public static IEnumerable<SelectListItem> VictoryPointValues { get; set; }
    }
}
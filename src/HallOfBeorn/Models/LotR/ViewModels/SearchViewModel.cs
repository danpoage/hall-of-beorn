﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Search;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    /*
    public class FilterViewModel
    {
        [Display(Name="Search")]
        public string Query { get; set; }

        [Display(Name="Type")]
        public CardType CardType { get; set; }

        [Display(Name = "Set")]
        public string CardSet { get; set; }
    }
    */

    public class SearchViewModel
    {
        public SearchViewModel()
        {
        }

        public Func<Scenario> GetScenario { get; set; }

        public void Initialize()
        {
            var model = this;

            if (string.IsNullOrEmpty(model.CardSet) || model.CardSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.CardSet = null;
            }
            if (string.IsNullOrEmpty(model.EncounterSet) || model.EncounterSet == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterSet = null;
            }
            if (string.IsNullOrEmpty(model.Cycle) || model.Cycle == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Cycle = null;
            }
            if (string.IsNullOrEmpty(model.Scenario) || model.Scenario == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Scenario = null;
            }
            if (string.IsNullOrEmpty(model.Quest) || model.Quest == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Quest = null;
            }
            if (string.IsNullOrEmpty(model.CardType) || model.CardType == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.CardType = null;
            }
            if (string.IsNullOrEmpty(model.CardSubtype) || model.CardSubtype == SearchViewModel.DEFAULT_FILTER_VALUE || model.CardSubtype == "None")
            {
                model.CardSubtype = null;
            }
            if (model.SetType.HasValue && model.SetType.Value == Models.SetType.None)
            {
                model.SetType = null;
            }
            if (model.Sort.HasValue && model.Sort.Value == Models.LotR.Sort.None)
            {
                model.Sort = null;
            }
            if (model.View.HasValue && model.View.Value == Models.View.None)
            {
                model.View = null;
            }
            if (model.Lang.HasValue && model.Lang.Value == Models.Language.None)
            {
                model.Lang = null;
            }
            if (model.DeckType.HasValue && model.DeckType.Value == Models.DeckType.None)
            {
                model.DeckType = null;
            }
            if (string.IsNullOrEmpty(model.Trait) || model.Trait == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Trait = null;
            }
            if (string.IsNullOrEmpty(model.Keyword) || model.Keyword == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Keyword = null;
            }
            if (string.IsNullOrEmpty(model.Artist) || model.Artist == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Artist = null;
            }
            if (model.Sphere.HasValue && model.Sphere.Value == Models.LotR.Sphere.None)
            {
                model.Sphere = null;
            }
            if (string.IsNullOrEmpty(model.Category) || model.Category == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Category = null;
            }
            if (string.IsNullOrEmpty(model.EncounterCategory) || model.EncounterCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.EncounterCategory = null;
            }
            if (string.IsNullOrEmpty(model.QuestCategory) || model.QuestCategory == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.QuestCategory = null;
            }
            if (string.IsNullOrEmpty(model.Region) || model.Region == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Region = null;
            }
            if (string.IsNullOrEmpty(model.Archetype) || model.Archetype == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Archetype = null;
            }
            if (string.IsNullOrEmpty(model.Age) || model.Age == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Age = null;
            }
            if (string.IsNullOrEmpty(model.VictoryPoints) || model.VictoryPoints == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.VictoryPoints = null;
            }
            if (model.Status.HasValue && model.Status.Value == CardStatus.None)
            {
                model.Status = null;
            }
            if (string.IsNullOrEmpty(model.Character) || model.Character == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Character = null;
            }
            if (string.IsNullOrEmpty(model.Creator) || model.Creator == SearchViewModel.DEFAULT_FILTER_VALUE)
            {
                model.Creator = null;
            }

            if (model.IsUnique.HasValue && model.IsUnique.Value == Uniqueness.Any)
            {
                model.IsUnique = null;
            }
            
            if (model.ThreatCostOperator.HasValue && model.ThreatCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.ThreatCost) || model.ThreatCost == "Any"))
            {
                model.ThreatCost = null;
                model.ThreatCostOperator = null;
            }
            if (model.CostOperator.HasValue && model.CostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.Cost) || model.Cost == "Any"))
            {
                model.Cost = null;
                model.CostOperator = null;
            }
            if (model.EngagementCostOperator.HasValue && model.EngagementCostOperator == NumericOperator.eq && (string.IsNullOrEmpty(model.EngagementCost) || model.EngagementCost == "Any"))
            {
                model.EngagementCost = null;
                model.EngagementCostOperator = null;
            }
            if (model.AttackOp.HasValue && model.AttackOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Attack) || model.Attack == "Any"))
            {
                model.Attack = null;
                model.AttackOp = null;
            }
            if (model.DefenseOp.HasValue && model.DefenseOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Defense) || model.Defense == "Any"))
            {
                model.Defense = null;
                model.DefenseOp = null;
            }
            if (model.WillpowerOp.HasValue && model.WillpowerOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Willpower) || model.Willpower == "Any"))
            {
                model.Willpower = null;
                model.WillpowerOp = null;
            }
            if (model.ThreatOp.HasValue && model.ThreatOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Threat) || model.Threat == "Any"))
            {
                model.Threat = null;
                model.ThreatOp = null;
            }
            if (model.HitPointsOp.HasValue && model.HitPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.HitPoints) || model.HitPoints == "Any"))
            {
                model.HitPoints = null;
                model.HitPointsOp = null;
            }
            if (model.QuestPointsOp.HasValue && model.QuestPointsOp == NumericOperator.eq && (string.IsNullOrEmpty(model.QuestPoints) || model.QuestPoints == "Any"))
            {
                model.QuestPoints = null;
                model.QuestPointsOp = null;
            }
            if (model.PopularityOp.HasValue && model.PopularityOp == NumericOperator.eq && (string.IsNullOrEmpty(model.Popularity) || model.Popularity == "Any" || model.Popularity == "-1"))
            {
                model.Popularity = null;
                model.PopularityOp = null;
            }
            if (model.Errata.HasValue && model.Errata.Value == ErrataVersion.Any)
            {
                model.Errata = null;
            }

            if (model.Project.HasValue && model.Project.Value == LotR.Project.Any)
            {
                model.Project = null;
            }

            if (model.MEC01.HasValue && !model.MEC01.Value)
            {
                model.MEC01 = null;
            }
            if (model.MEC02.HasValue && !model.MEC02.Value)
            {
                model.MEC02 = null;
            }
            if (model.MEC03.HasValue && !model.MEC03.Value)
            {
                model.MEC03 = null;
            }
            if (model.MEC04.HasValue && !model.MEC04.Value)
            {
                model.MEC04 = null;
            }
            if (model.MEC05.HasValue && !model.MEC05.Value)
            {
                model.MEC05 = null;
            }
            if (model.MEC06.HasValue && !model.MEC06.Value)
            {
                model.MEC06 = null;
            }
            if (model.MEC07.HasValue && !model.MEC07.Value)
            {
                model.MEC07 = null;
            }

            if (model.MEC08.HasValue && !model.MEC08.Value)
            {
                model.MEC08 = null;
            }
            if (model.MEC09.HasValue && !model.MEC09.Value)
            {
                model.MEC09 = null;
            }
            if (model.MEC10.HasValue && !model.MEC10.Value)
            {
                model.MEC10 = null;
            }
            if (model.MEC11.HasValue && !model.MEC11.Value)
            {
                model.MEC11 = null;
            }
            if (model.MEC12.HasValue && !model.MEC12.Value)
            {
                model.MEC12 = null;
            }
            if (model.MEC13.HasValue && !model.MEC13.Value)
            {
                model.MEC13 = null;
            }
            if (model.MEC14.HasValue && !model.MEC14.Value)
            {
                model.MEC14 = null;
            }

            if (model.MEC17.HasValue && !model.MEC17.Value)
            {
                model.MEC17 = null;
            }

            if (model.MEC18.HasValue && !model.MEC18.Value)
            {
                model.MEC18 = null;
            }
            if (model.MEC19.HasValue && !model.MEC19.Value)
            {
                model.MEC19 = null;
            }
            if (model.MEC20.HasValue && !model.MEC20.Value)
            {
                model.MEC20 = null;
            }
            if (model.MEC21.HasValue && !model.MEC21.Value)
            {
                model.MEC21 = null;
            }
            if (model.MEC22.HasValue && !model.MEC22.Value)
            {
                model.MEC22 = null;
            }
            if (model.MEC23.HasValue && !model.MEC23.Value)
            {
                model.MEC23 = null;
            }

            if (model.MEC25.HasValue && !model.MEC25.Value)
            {
                model.MEC25 = null;
            }
            if (model.MEC26.HasValue && !model.MEC26.Value)
            {
                model.MEC26 = null;
            }
            if (model.MEC27.HasValue && !model.MEC27.Value)
            {
                model.MEC27 = null;
            }
            if (model.MEC28.HasValue && !model.MEC28.Value)
            {
                model.MEC28 = null;
            }
            if (model.MEC29.HasValue && !model.MEC29.Value)
            {
                model.MEC29 = null;
            }
            if (model.MEC30.HasValue && !model.MEC30.Value)
            {
                model.MEC30 = null;
            }
            if (model.MEC31.HasValue && !model.MEC31.Value)
            {
                model.MEC31 = null;
            }

            if (model.MEC38.HasValue && !model.MEC38.Value)
            {
                model.MEC38 = null;
            }
            if (model.MEC39.HasValue && !model.MEC39.Value)
            {
                model.MEC39 = null;
            }
            if (model.MEC40.HasValue && !model.MEC40.Value)
            {
                model.MEC40 = null;
            }
            if (model.MEC41.HasValue && !model.MEC41.Value)
            {
                model.MEC41 = null;
            }
            if (model.MEC42.HasValue && !model.MEC42.Value)
            {
                model.MEC42 = null;
            }
            if (model.MEC43.HasValue && !model.MEC43.Value)
            {
                model.MEC43 = null;
            }
            if (model.MEC44.HasValue && !model.MEC44.Value)
            {
                model.MEC44 = null;
            }

            if (model.MEC47.HasValue && !model.MEC47.Value)
            {
                model.MEC47 = null;
            }

            if (model.MEC48.HasValue && !model.MEC48.Value)
            {
                model.MEC48 = null;
            }
            if (model.MEC49.HasValue && !model.MEC49.Value)
            {
                model.MEC49 = null;
            }
            if (model.MEC50.HasValue && !model.MEC50.Value)
            {
                model.MEC50 = null;
            }
            if (model.MEC51.HasValue && !model.MEC51.Value)
            {
                model.MEC51 = null;
            }
            if (model.MEC52.HasValue && !model.MEC52.Value)
            {
                model.MEC52 = null;
            }
            if (model.MEC53.HasValue && !model.MEC53.Value)
            {
                model.MEC53 = null;
            }

            if (model.MEC16.HasValue && !model.MEC16.Value)
            {
                model.MEC16 = null;
            }
            if (model.MEC24.HasValue && !model.MEC24.Value)
            {
                model.MEC24 = null;
            }

            if (model.MEC32.HasValue && !model.MEC32.Value)
            {
                model.MEC32 = null;
            }
            if (model.MEC34.HasValue && !model.MEC34.Value)
            {
                model.MEC34 = null;
            }
            if (model.MEC45.HasValue && !model.MEC45.Value)
            {
                model.MEC45 = null;
            }
            if (model.MEC46.HasValue && !model.MEC46.Value)
            {
                model.MEC46 = null;
            }
            if (model.MEC54.HasValue && !model.MEC54.Value)
            {
                model.MEC54 = null;
            }

            if (model.FA01.HasValue && !model.FA01.Value)
            {
                model.FA01 = null;
            }
            if (model.FA02.HasValue && !model.FA02.Value)
            {
                model.FA02 = null;
            }
            if (model.FA03.HasValue && !model.FA03.Value)
            {
                model.FA03 = null;
            }
        }

        /*
        public void addDefinitions()
        {
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
        }
        */

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

        private string query;
        [Display(Name = "Search")]
        public string Query
        { 
            get { return !string.IsNullOrEmpty(query) ? query.Replace("’", "'") : string.Empty; }
            set { query = value; }
        }

        [Display(Name = "Type")]
        public string CardType { get; set; }

        [Display(Name = "Subtype")]
        public string CardSubtype { get; set; }

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

        [Display(Name = "Errata")]
        public ErrataVersion? Errata { get; set; }

        public int? Limit { get; set; }
        public int? Offset { get; set; }

        public bool IsCardView()
        {
            return (!View.HasValue || (View != Models.View.Product && View != Models.View.Character));
        }

        public bool IsProductView()
        {
            return (View.HasValue && View == Models.View.Product);
        }

        public bool IsCharacterView()
        {
            return (View.HasValue && View == Models.View.Character);
        }

        public bool IsCommunityView()
        {
            return (View.HasValue && View == Models.View.Community);
        }

        public bool IsAltArtView()
        {
            return View.GetValueOrDefault(Models.View.None) == Models.View.Alt_Art;
        }

        public bool IsRingsDbView()
        {
            return View.GetValueOrDefault(Models.View.None) == Models.View.RingsDB;
        }

        public bool IsCardDesignView()
        {
            return View.GetValueOrDefault(Models.View.None) == Models.View.Card_Design;
        }

        [Display(Name = "Artist")]
        public string Artist { get; set; }

        [Display(Name="Encounter Set")]
        public string EncounterSet { get; set; }

        [Display(Name="Cycle")]
        public string Cycle { get; set; }

        [Display(Name="Player Category")]
        public string Category { get; set; }

        [Display(Name="Player Card Popularity")]
        public string Popularity { get; set; }

        [Display(Name = "Popularity Operator")]
        public NumericOperator? PopularityOp { get; set; }

        [Display(Name = "Region")]
        public string Region { get; set; }

        [Display(Name="Archetype")]
        public string Archetype { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }

        public static IEnumerable<SelectListItem> PopularityValues
        {
            get
            {
                return new List<byte>()
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                }.GetSelectListItems();
            }
        }

        public string ItemWidth(CardType type)
        {
            if (this.View.HasValue && View == Models.View.Card_Image)
            {
                if (type == LotR.CardType.Quest || type == LotR.CardType.Encounter_Side_Quest || type == LotR.CardType.Player_Side_Quest)
                    return "400px;";
                return "200px;";
            }
            else return "80%";
        }

        public PlayerCategory GetCategory()
        {
            var category = HallOfBeorn.Models.LotR.PlayerCategory.None;
            if (string.IsNullOrEmpty(this.Category))
                return category;

            var decoded = HttpUtility.HtmlDecode(this.Category).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.LotR.PlayerCategory>(decoded, true, out category);
            
            return category;
        }

        [Display(Name="Encounter Category")]
        public string EncounterCategory { get; set; }

        public EncounterCategory GetEncounterCategory()
        {
            var encCategory = HallOfBeorn.Models.LotR.EncounterCategory.None;
            if (string.IsNullOrEmpty(this.EncounterCategory))
                return encCategory;

            var decoded = HttpUtility.HtmlDecode(this.EncounterCategory).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.LotR.EncounterCategory>(decoded, true, out encCategory);

            return encCategory;
        }

        [Display(Name = "Quest Category")]
        public string QuestCategory { get; set; }

        public Language? Lang { get; set; }

        public Project? Project { get; set; }
        
        public QuestCategory GetQuestCategory()
        {
            var questCategory = HallOfBeorn.Models.LotR.QuestCategory.None;
            if (string.IsNullOrEmpty(this.QuestCategory))
                return questCategory;

            var decoded = HttpUtility.HtmlDecode(this.QuestCategory).Replace(' ', '_');

            Enum.TryParse<HallOfBeorn.Models.LotR.QuestCategory>(decoded, true, out questCategory);

            return questCategory;
        }

        public bool IsRandom()
        {
            return (!string.IsNullOrEmpty(this.Query) && this.Query.ContainsLower(RANDOM_KEYWORD)) || (this.Random.HasValue && this.Random.Value);
        }

        public List<CardViewModel> Cards { get; set; }

        public List<ProductViewModel> Products { get; set; }

        public List<CharacterViewModel> Characters { get; set; }

        public List<LinkViewModel> Links { get; set; }

        public List<RingsDbDeckViewModel> RingsDbDecks { get; set; }

        public List<CardDesignViewModel> CardDesigns { get; set; }

        //[Display(Name = "Custom")]
        //public bool Custom { get; set; }

        [Display(Name = "Victory")]
        public string VictoryPoints { get; set; }

        //TODO: Add this
        //public string XP { get; set; }

        [Display(Name = "Status")]
        public CardStatus? Status { get; set; }

        [Display(Name = "Character")]
        public string Character { get; set; }

        [Display(Name="Creator")]
        public string Creator { get; set; }

        public bool? Random { get; set; }

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
            return !string.IsNullOrEmpty(this.CardType) && this.CardType != "Any";
        }

        public bool HasCardSubtype()
        {
            return !string.IsNullOrEmpty(this.CardSubtype) && this.CardSubtype != "Any";
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
            return this.Sphere.HasValue && this.Sphere.Value != Models.LotR.Sphere.None;
        }

        public bool HasCategory()
        {
            return this.GetCategory() != Models.LotR.PlayerCategory.None;
        }

        public bool HasEncounterCategory()
        {
            return this.GetEncounterCategory() != Models.LotR.EncounterCategory.None;
        }

        public bool HasQuestCategory()
        {
            return this.GetQuestCategory() != Models.LotR.QuestCategory.None;
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

        public bool CardTypeMatches(LotRCard card)
        {
            if (string.IsNullOrEmpty(CardType) || CardType == "Any")
            {
                return false;
            }

            CardType parsedType;
            if (!Enum.TryParse<CardType>(this.CardType, out parsedType))
            {
                return false;
            }

            if (parsedType == Models.LotR.CardType.Player)
            {
                return card.CardType == Models.LotR.CardType.Hero || card.CardType == Models.LotR.CardType.Ally || card.CardType == Models.LotR.CardType.Attachment || card.CardType == Models.LotR.CardType.Event || card.CardType == Models.LotR.CardType.Player_Side_Quest;
            }
            else if (parsedType == Models.LotR.CardType.Character)
            {
                return card.CardType == Models.LotR.CardType.Hero || card.CardType == Models.LotR.CardType.Ally || card.CardType == Models.LotR.CardType.Objective_Ally || (card.CardType == Models.LotR.CardType.Objective && card.HitPoints > 0);
            }
            else if (parsedType == Models.LotR.CardType.Encounter)
            {
                return card.CardType == Models.LotR.CardType.Enemy || card.CardType == Models.LotR.CardType.Location || card.CardType == Models.LotR.CardType.Treachery || card.CardType == Models.LotR.CardType.Objective || card.CardType == Models.LotR.CardType.Objective_Ally || card.CardType == Models.LotR.CardType.Objective_Location || card.CardType == Models.LotR.CardType.Encounter_Side_Quest || card.CardType == Models.LotR.CardType.Ship_Objective || card.CardType == Models.LotR.CardType.Ship_Enemy;
            }
            else if (parsedType == Models.LotR.CardType.Objective)
            {
                return card.CardType == Models.LotR.CardType.Objective || card.CardType == Models.LotR.CardType.Objective_Ally;
            }
            else
                return parsedType == card.CardType;
        }

        //public bool CardSetMatches(LotRCard card)
        //{
            //return card.MatchesCardSet(this.CardSet);
            //return card.CardSet.Name == this.CardSet || (!string.IsNullOrEmpty(card.CardSet.AlternateName) && card.CardSet.AlternateName == this.CardSet) || (!string.IsNullOrEmpty(card.CardSet.NormalizedName) && card.CardSet.NormalizedName == this.CardSet) || (!string.IsNullOrEmpty(card.CardSet.Cycle) && card.CardSet.Cycle.ToUpper() == this.CardSet);
        //}

        /*
        public bool CardIsCustom(LotRCard card)
        {
            var custom = new HashSet<Models.SetType> { Models.SetType.COMMUNITY, Models.SetType.First_Age, Models.SetType.A_Long_extended_Party };

            return custom.Contains(card.CardSet.SetType);
        }
        */

        public bool VictoryPointsMatch(LotRCard card)
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
            get;
            set;
        }

        public static IEnumerable<SelectListItem> CardSubtypes
        {
            get { return typeof(CardSubtype).GetSelectListItems(new Tuple<string,string>("No Subtype", "No Subtype")); }
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

        public static IEnumerable<SelectListItem> Regions
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> Archetypes
        {
            get; set; 
        }

        public static IEnumerable<SelectListItem> Ages { get; set; }

        public static IEnumerable<SelectListItem> Projects { get; set; }

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

        public bool? MEC48 { get; set; }
        public bool? MEC49 { get; set; }
        public bool? MEC50 { get; set; }
        public bool? MEC51 { get; set; }
        public bool? MEC52 { get; set; }
        public bool? MEC53 { get; set; }

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
        public bool? MEC54 { get; set; }

        //First Age
        public bool? FA01 { get; set; }
        public bool? FA02 { get; set; }
        public bool? FA03 { get; set; }

        public string GetResultsCount()
        {
            var count = Cards.Count;
            var label = count == 1 ? "Card" : "Cards";

            var subCount = 0;
            var subLabel = string.Empty;

            if (View.GetValueOrDefault(Models.View.None) == Models.View.Alt_Art)
            {
                subCount = Cards.Sum(c => c.CommunityImages().Count());
                subLabel = subCount == 1 ? "Alt Art" : "Alt Arts";
            }
            if (View.GetValueOrDefault(Models.View.None) == Models.View.Character)
            {
                subCount = Characters != null ? Characters.Count : 0;
                subLabel = subCount == 1 ? "Character" : "Characters";
            }
            if (View.GetValueOrDefault(Models.View.None) == Models.View.Community)
            {
                subCount = Links != null ? Links.Count : 0;
                subLabel = subCount == 1 ? "Link" : "Links";
            }
            if (View.GetValueOrDefault(Models.View.None) == Models.View.Product)
            {
                subCount = Products != null ? Products.Count : 0;
                subLabel = subCount == 1 ? "Product" : "Products";
            }
            if (View.GetValueOrDefault(Models.View.None) == Models.View.RingsDB)
            {
                subCount = RingsDbDecks != null ? RingsDbDecks.Count : 0;
                subLabel = subCount == 1 ? "Deck" : "Decks";
            }

            var results = new System.Text.StringBuilder();

            results.AppendFormat("Results: {0} {1}", count, label);

            if (!string.IsNullOrWhiteSpace(subLabel))
            {
                results.AppendFormat(" - {0} {1}", subCount, subLabel);
            }

            return results.ToString();
        }

        public static IEnumerable<SelectListItemExtends> CardSets { get; set; }
        public static IEnumerable<SelectListItem> Scenarios { get; set; }
        public static IEnumerable<SelectListItem> EncounterSets { get; set; }
        public static IEnumerable<SelectListItem> Cycles { get; set; }

        public static IEnumerable<SelectListItem> ResourceCosts { get; set; }
        public static IEnumerable<SelectListItem> ThreatCosts { get; set; }
        public static IEnumerable<SelectListItem> EngagementCosts { get; set; }

        public static IEnumerable<SelectListItem> AttackStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> DefenseStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> HitPointsValues { get; set; }
        public static IEnumerable<SelectListItem> WillpowerStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> ThreatStrengthValues { get; set; }
        public static IEnumerable<SelectListItem> QuestPointsValues { get; set; }

        public static IEnumerable<SelectListItem> ErrataVersions
        {
            get { return typeof(ErrataVersion).GetSelectListItems(); }
        }

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

        public static IEnumerable<SelectListItem> Languages
        {
            get { return typeof(Language).GetSelectListItems(); }
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

        public static IEnumerable<SelectListItem> Statuses { get; set; }

        public static IEnumerable<SelectListItem> CharacterValues { get; set; }

        public static IEnumerable<SelectListItem> CreatorValues { get; set; }
    }
}

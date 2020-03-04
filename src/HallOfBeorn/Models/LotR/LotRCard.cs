using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class LotRCard : Card
    {
        public LotRCard()
        {
            IncludedEncounterSets = new List<EncounterSet>();

            StageLetter = 'A';

            //Html = string.Empty;
            //Html2 = string.Empty;

            AlternateEncounterSet = string.Empty;
        }

        protected override string getSlug()
        {
            var title = !string.IsNullOrEmpty(NormalizedTitle) ? NormalizedTitle.ToUrlSafeString() : Title.ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty(SlugSuffix) ? string.Format("{0}-", SlugSuffix.ToUrlSafeString()) : string.Empty;
            var set = CardSet.Abbreviation.ToString().ToUrlSafeString();
            return string.Format("{0}-{1}{2}", title, suffix, set);
        }

        /*
        private string html;
        public string Html
        {
            get
            {
                if (string.IsNullOrEmpty(html))
                {
                    var renderedHtml = GetHtml(DefaultLang);
                    if (!string.IsNullOrEmpty(renderedHtml))
                    {
                        html = renderedHtml;
                    }
                }

                return html;
            }
            set { html = value; }
        }
        */

        public string GetFrontHtml(Language lang)
        {
            var template = GetFrontHtmlTemplate(lang);
            return !string.IsNullOrEmpty(template) ?
                new TextTemplate(this).RenderHtml(template)
                : string.Empty;
        }

        private readonly Dictionary<Language, string> frontHtmlTemplates = new Dictionary<Language, string>();

        public string HtmlTemplate
        {
            get { return GetFrontHtmlTemplate(DefaultLang); }
            set { frontHtmlTemplates[DefaultLang] = value;  }
        }

        public string GetFrontHtmlTemplate(Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLang;

            if (frontHtmlTemplates.ContainsKey(useLang))
                return frontHtmlTemplates[useLang];

            return frontHtmlTemplates.ContainsKey(DefaultLang) ?
                frontHtmlTemplates[DefaultLang]
                : string.Empty;
        }

        public LotRCard WithFrontHtmlTemplate(Language lang, string template)
        {
            frontHtmlTemplates[lang] = template;
            return this;
        }

        public string GetBackHtml(Language lang)
        {
            var template = GetBackHtmlTemplate(lang);
            return !string.IsNullOrEmpty(template) ?
                new TextTemplate(this).RenderHtml(template)
                : string.Empty;
        }

        private readonly Dictionary<Language, string> backHtmlTemplates = new Dictionary<Language, string>();

        public string HtmlTemplate2
        {
            get { return GetBackHtmlTemplate(DefaultLang); }
            set { backHtmlTemplates[DefaultLang] = value;  }
        }

        public string GetBackHtmlTemplate(Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLang;

            if (backHtmlTemplates.ContainsKey(useLang))
                return backHtmlTemplates[useLang];

            return backHtmlTemplates.ContainsKey(DefaultLang) ?
                backHtmlTemplates[DefaultLang]
                : string.Empty;
        }

        public LotRCard WithBackHtmlTemplate(Language lang, string template)
        {
            backHtmlTemplates[lang] = template;
            return this;
        }

        /*
        private string html2;
        public string Html2
        {
            get
            {
                if (!string.IsNullOrEmpty(HtmlTemplate2) && string.IsNullOrEmpty(html2))
                {
                    html2 = new TextTemplate(this).RenderBackHtml();
                }

                return html2;
            }
            set { html2 = value; }
        }
        public string HtmlTemplate2;
         */

        public bool HasThumbnail { get; private set; }

        public override string CardSetName { get { return cardSet != null ? cardSet.Name : string.Empty; } }
        public override bool IsCampaign { get { return this.CardType == LotR.CardType.Campaign; } }
        public override bool IsQuest { get { return this.CardType == LotR.CardType.Quest; } }
        public override uint StageNumber { get; set; }
        public override char StageLetter { get; protected set; }

        public char? BackStageLetter { get; set; }

        private CardSet cardSet;
        public CardSet CardSet {
            get { return cardSet; } 
            set {
                cardSet = value;
                NamedProduct = value;
            }
        }

        public CardType CardType { get; set; }
        public CardSubtype CardSubtype { get; set; }
        public Sphere Sphere { get; set; }

        public byte? MaxPerDeck { get; set; }
        public byte? ThreatCost { get; set; }
        public byte? ResourceCost { get; set; }
        public byte? EngagementCost { get; set; }

        public byte? EncounterCost { get; set; }
        public byte? EncounterSetNumber { get; set; }

        public byte? Threat { get; set; }
        public byte? Willpower { get; set; }
        public byte? Attack { get; set; }
        public byte? Defense { get; set; }
        public byte? HitPoints { get; set; }
        public byte? QuestPoints { get; set; }

        public double StatScore()
        {
            Func<byte, byte, double> defensiveValue = (def, hp) =>
                {
                    return (double)(0.7272D * def) + (0.3636D * (hp - 1));
                };

            Func<byte, double> hazardInsurance = (hp) =>
                {
                    return Math.Log((double)hp, 2D);
                };

            Func<byte, double> statValue = (stat) => Math.Pow(stat, 2);

            var willpower = Willpower.GetValueOrDefault(0);
            var attack = Attack.GetValueOrDefault(0);
            var defense = Defense.GetValueOrDefault(0);
            var hitPoints = HitPoints.GetValueOrDefault(0);

            if (CardType == LotR.CardType.Hero || CardType == LotR.CardType.Objective_Hero)
            {
                return Math.Sqrt(
                    statValue(willpower)
                    + statValue(attack)
                    + defensiveValue(defense, hitPoints)
                    + hazardInsurance(hitPoints)
                    );
            }
            else if (CardType == LotR.CardType.Ally || CardType == CardType.Objective_Ally)
            {
                return Math.Sqrt(
                    statValue(willpower)
                    + statValue(attack)
                    + defensiveValue(defense, hitPoints)
                    + Math.Sqrt(hazardInsurance(hitPoints))
                    );
            }
            else return 0;
        }

        public string Shadow { get; set; }
        public string EncounterSet { get; set; }
        public string AlternateEncounterSet { get; set; }
        public List<EncounterSet> IncludedEncounterSets { get; set; }
        public bool? PassValue { get; private set; }
        public byte? EyeIcon { get; private set; }
        public byte? EasyModeQuantity { get; set; }
        public byte? NightmareModeQuantity { get; set; }
        public byte? SiegePoints { get; set; }

        public bool HasErrata { get; set; }
        public string Direction { get; set; }

        private DeckType deckType = DeckType.None;
        public DeckType DeckType
        {
            get {
                if (deckType != DeckType.None) {
                    return deckType;
                }

                switch (CardType)
                {
                    case LotR.CardType.Hero:
                    case LotR.CardType.Ally:
                    case LotR.CardType.Attachment:
                    case LotR.CardType.Event:
                    case LotR.CardType.Treasure:
                    case LotR.CardType.Player_Side_Quest:
                        return DeckType.Player;
                    case LotR.CardType.Enemy:
                    case LotR.CardType.Location:
                    case LotR.CardType.Treachery:
                    case LotR.CardType.Objective:
                    case LotR.CardType.Objective_Ally:
                    case LotR.CardType.Objective_Hero:
                    case LotR.CardType.Objective_Location:
                    case LotR.CardType.Encounter_Side_Quest:
                    case LotR.CardType.Ship_Objective:
                    case LotR.CardType.Ship_Enemy:
                        return DeckType.Encounter;
                    case LotR.CardType.Quest:
                    case LotR.CardType.Campaign:
                    case LotR.CardType.GenCon_Setup:
                    case LotR.CardType.Nightmare_Setup:
                        return DeckType.Quest;
                    default:
                        return DeckType.None;
                }
            }
        }

        public bool MatchesCardSet(string targetCardSet)
        {
            return CardSet.Name == targetCardSet || (!string.IsNullOrEmpty(CardSet.AlternateName) && CardSet.AlternateName == targetCardSet) || (!string.IsNullOrEmpty(CardSet.NormalizedName) && CardSet.NormalizedName == targetCardSet) || (!string.IsNullOrEmpty(CardSet.Cycle) && CardSet.Cycle.ToUpper() == targetCardSet);
        }

        public byte SortCost()
        {
            switch (CardType)
            {
                case LotR.CardType.Hero:
                    return ThreatCost.HasValue ? ThreatCost.Value : (byte)0;
                case LotR.CardType.Ally:
                case LotR.CardType.Attachment:
                case LotR.CardType.Event:
                case LotR.CardType.Player_Side_Quest:
                    return ResourceCost.HasValue ? ResourceCost.Value : (byte)0;
                case LotR.CardType.Enemy:
                case LotR.CardType.Ship_Enemy:
                    return EngagementCost.HasValue ? EngagementCost.Value : (byte)0;
                default:
                    return 0;
            }
        }

        #region Static Fluent Helpers

        public static LotRCard Hero(string title, string id, Sphere sphere, byte threatCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Hero,
                Title = title,
                Id = id,
                IsUnique = true,
                Sphere = sphere,
                ThreatCost = threatCost,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard Ally(string title, Sphere sphere, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Ally,
                Title = title,
                Sphere = sphere,
                ResourceCost = resourceCost,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard Attachment(string title, string id, Sphere sphere, byte resourceCost)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Attachment,
                Title = title,
                Id = id,
                Sphere = sphere,
                ResourceCost = resourceCost
            };
        }

        public static LotRCard Event(string title, string id, Sphere sphere, byte resourceCost)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Event,
                Title = title,
                Id = id,
                Sphere = sphere,
                ResourceCost = resourceCost
            };
        }

        public static LotRCard Contract(string title)
        {
            return new LotRCard
            {
                CardType = Models.LotR.CardType.Contract,
                Title = title,
                Sphere = Sphere.Neutral
            };
        }

        public static LotRCard ObjectiveHero(string title, string encounterSet, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Objective_Hero,
                Title = title,
                Id = string.Empty,
                EncounterSet = encounterSet,
                IsUnique = true,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard Enemy(string title, string id, string encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Enemy,
                Title = title,
                Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                EngagementCost = engagementCost,
                Threat = threat,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard Location(string title, string id, string encounterSet, byte? threat, byte? questPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Location,
                Title = title,
                Id = id,
                Threat = threat,
                QuestPoints = questPoints,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard Treachery(string title, string id, string encounterSet)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Treachery,
                Title = title,
                Id = id,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard EncounterSideQuest(string title, string id, string encounterSet, byte? questPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Encounter_Side_Quest,
                Title = title,
                Id = id,
                EncounterSet = encounterSet,
                QuestPoints = questPoints
            };
        }

        public static LotRCard PlayerSideQuest(string title, string id, Sphere sphere, byte resourceCost, byte questPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Player_Side_Quest,
                Title = title,
                Id = id,
                Sphere = sphere,
                ResourceCost = resourceCost,
                QuestPoints = questPoints
            };
        }

        public static LotRCard Quest(string title, uint stageNumber, string encounterSet, byte? questPoints)
        {
            return Quest(title, stageNumber, encounterSet, questPoints, 'A');
        }

        public static LotRCard Quest(string title, uint stageNumber, string encounterSet, byte? questPoints, char stageLetter)
        {
            return new LotRCard()
            {
                CardType = CardType.Quest,
                Title = title,
                EncounterSet = encounterSet,
                QuestPoints = questPoints,
                StageNumber = stageNumber,
                StageLetter = stageLetter,
                SlugSuffix = stageLetter == 'A' ? string.Empty : stageLetter.ToString()
            };
        }

        public static LotRCard Campaign(string title, string encounterSet, string oppositeTitle)
        {
            return new LotRCard()
            {
                CardType = CardType.Campaign,
                Title = title,
                EncounterSet = encounterSet,
                SlugSuffix = "Campaign",
                OppositeTitle = oppositeTitle
            };
        }

        public static LotRCard NightmareSetup(string title, string encounterSet)
        {
            return new LotRCard()
            {
                CardType = CardType.Nightmare_Setup,
                Title = title,
                Id = string.Empty,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard GenConSetup(string title, string encounterSet)
        {
            return new LotRCard()
            {
                CardType = CardType.GenCon_Setup,
                Title = title,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard Scenario(string title, int scenarioNumber, string encounterSet, string oppositeTitle)
        {
            return new LotRCard()
            {
                CardType = CardType.Scenario,
                Title = title,
                EncounterSet = encounterSet,
                OppositeTitle = oppositeTitle
            };
        }

        public static LotRCard Objective(string title, string id, string encounterSet)
        {
            return new LotRCard()
            {
                CardType = CardType.Objective,
                Title = title,
                Id = id,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard ObjectiveAlly(string title, string id, string encounterSet, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Objective_Ally,
                Title = title,
                Id = id,
                EncounterSet = encounterSet,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard ObjectiveLocation(string title, string encounterSet, byte? questPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Objective_Location,
                Title = title,
                Id = string.Empty,
                EncounterSet = encounterSet,
                QuestPoints = questPoints
            };
        }

        public static LotRCard ShipObjective(string title, string encounterSet, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Ship_Objective,
                Title = title,
                Id = string.Empty,
                EncounterSet = encounterSet,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard ShipEnemy(string title, string encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Ship_Enemy,
                Title = title,
                Id = string.Empty,
                EncounterSet = encounterSet,
                EngagementCost = engagementCost,
                Threat = threat,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public LotRCard WithAlternateSlug(string slug)
        {
            this.AlternateSlug = slug;
            return this;
        }

        public LotRCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public LotRCard WithEasyModeQuantity(byte quantity)
        {
            this.EasyModeQuantity = quantity;
            return this;
        }

        public LotRCard WithTraits(params string[] traits)
        {
            addTraits(traits);
            return this;
        }
        
        public LotRCard WithTraits(Language lang, params string[] traits)
        {
            addTraits(traits, lang);
            return this;
        }

        public LotRCard WithVictoryPoints(byte victoryPoints)
        {
            this.VictoryPoints = victoryPoints;
            return this;
        }

        public LotRCard WithTurn()
        {
            this.Direction = "TURN";
            return this;
        }

        public LotRCard WithStraight()
        {
            this.Direction = "STRAIGHT";
            return this;
        }

        public LotRCard WithWild()
        {
            this.Direction = "WILD";
            return this;
        }

        public LotRCard WithKeywords(params string[] keywords)
        {
            addKeywords(keywords);
            return this;
        }

        public LotRCard WithKeywords(Language lang, params string[] keywords)
        {
            addKeywords(keywords, lang);
            return this;
        }

        public LotRCard WithText(string text)
        {
            SetText(DefaultLang, text);
            return this;
        }

        public LotRCard WithText(string text, Language lang)
        {
            SetText(lang, text);
            return this;
        }

        public LotRCard WithTextLine(string text)
        {
            if (string.IsNullOrEmpty(this.Text))
                this.Text = text + Environment.NewLine;
            else
                this.Text = this.Text + text + Environment.NewLine;
            return this;
        }

        public LotRCard WithTitle(Language lang, string title)
        {
            SetTitle(lang, title);
            return this;
        }

        public LotRCard WithOppositeTitle(string title)
        {
            this.OppositeTitle = title;
            this.SlugSuffix = title;
        
            return this;
        }

        public LotRCard WithOppositeText(string text)
        {
            this.OppositeText = text;
            return this;
        }

        public LotRCard WithOppositeTextLine(string text)
        {
            if (string.IsNullOrEmpty(this.Text))
                this.OppositeText = text + Environment.NewLine;
            else
                this.OppositeText = this.OppositeText + text + Environment.NewLine;
            return this;
        }

        public LotRCard WithBackArtist(Artist artist)
        {
            this.BackArtist = artist;
            return this;
        }

        public LotRCard WithAlternateEncounterSet(string alternateEncounterSet)
        {
            this.AlternateEncounterSet = alternateEncounterSet;
            return this;
        }

        public LotRCard WithIncludedEncounterSets(params EncounterSet[] sets)
        {
            foreach (var set in sets)
                this.IncludedEncounterSets.Add(set);

            return this;
        }

        public LotRCard WithShadow(string shadow)
        {
            const string prefix = "Shadow: ";

            if (!shadow.StartsWith(prefix))
                shadow = prefix + shadow;

            this.Shadow = shadow;
            return this;
        }

        public LotRCard WithYear(ushort year)
        {
            this.Year = year;
            return this;
        }

        public LotRCard WithInfo(byte number, byte quantity, Artist artist)
        {
            this.CardNumber = number;
            this.Quantity = quantity;
            this.Artist = artist;

            return this;
        }

        public LotRCard WithBoon()
        {
            this.CardSubtype = CardSubtype.Boon;
            return this;
        }

        public LotRCard WithBurden()
        {
            this.CardSubtype = CardSubtype.Burden;
            return this;
        }

        public LotRCard WithEyeIcon(byte count)
        {
            this.EyeIcon = count;
            return this;
        }

        public LotRCard WithErrata()
        {
            this.HasErrata = true;
            return this;
        }

        public LotRCard WithTemplate(string htmlTemplate)
        {
            this.HtmlTemplate = htmlTemplate;
            return this;
        }

        public LotRCard WithTemplate(string htmlTemplate, Language lang)
        {
            this.HtmlTemplate = htmlTemplate;
            return this;
        }

        public LotRCard WithTemplate2(string htmlTemplate)
        {
            this.HtmlTemplate2 = htmlTemplate;
            return this;
        }

        public LotRCard WithFlavor(string flavor)
        {
            this.FlavorText = flavor;
            return this;
        }

        public LotRCard WithFlavor(string flavor, string source)
        {
            this.FlavorText = flavor + Environment.NewLine + "–" + source;
            return this;
        }

        public LotRCard WithFlavorLine(string flavor)
        {
            if (string.IsNullOrWhiteSpace(FlavorText))
            {
                FlavorText = flavor;
            }
            else
            {
                FlavorText += Environment.NewLine + flavor;
            }

            return this;
        }

        public LotRCard WithOppositeFlavor(string flavor)
        {
            this.OppositeFlavorText = flavor;
            return this;
        }

        public LotRCard WithOppositeFlavorLine(string flavor)
        {
            if (string.IsNullOrWhiteSpace(OppositeFlavorText))
            {
                OppositeFlavorText = flavor;
            }
            else
            {
                OppositeFlavorText += Environment.NewLine + flavor;
            }

            return this;
        }

        public LotRCard WithSlugSuffix(string suffix)
        {
            this.SlugSuffix = suffix;
            return this;
        }

        public LotRCard WithBackStageLetter(char letter)
        {
            BackStageLetter = letter;
            return this;
        }

        public LotRCard WithThumbnail()
        {
            this.HasThumbnail = true;
            return this;
        }

        public LotRCard WithSiegePoints(byte value)
        {
            this.SiegePoints = value;
            return this;
        }

        public LotRCard WithSetNumberAndCost(byte? setNumber, byte? encounterCost)
        {
            this.EncounterSetNumber = setNumber;
            this.EncounterCost = encounterCost;
            return this;
        }

        public LotRCard WithPassValue()
        {
            PassValue = true;
            return this;
        }

        #endregion
    }
}
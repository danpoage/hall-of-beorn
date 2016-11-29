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
            Text = string.Empty;
            NormalizedTraits = new List<string>();
            NormalizedKeywords = new List<string>();
            Categories = new List<Category>();
            EncounterCategories = new List<EncounterCategory>();
            QuestCategories = new List<QuestCategory>();
            IncludedEncounterSets = new List<EncounterSet>();

            StageLetter = 'A';

            Html = string.Empty;
            Html2 = string.Empty;

            AlternateEncounterSet = string.Empty;
            Suffix = string.Empty;
            AlternateSlug = string.Empty;
        }

        #region Effect Functions

        private readonly List<Effect> effects = new List<Effect>();
        public void RenderEffects()
        {
            if (effects.Count == 0)
            {
                return;
            }

            var text = new StringBuilder();
            var html = new StringBuilder();

            foreach (var effect in effects)
            {
                text.Append(effect.ToText(this));
                html.Append(effect.ToHtml(this));
            }

            this.Text = text.ToString();
            this.Html = html.ToString();
        }

        private string html;
        private string html2;

        private void insertToken(StringBuilder sb, string type, string key, string label)
        {
            if (string.IsNullOrEmpty(type))
            {
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                key = type;
            }

            if (string.IsNullOrEmpty(label))
            {
                label = key;
            }

            key = key.Replace("'", "%27");
            label = label.Replace("'", "%27");

            var innerText = string.Empty;
            switch (type.ToLowerSafe())
            {
                case "query":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?Query={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "search":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "card":
                    sb.AppendFormat("<a title='Card: {0}' href='/Cards/Details/{1}' target='_blank'>{0}</a>", label, key.Replace("%27", "&#39;"));
                    break;
                case "title":
                    sb.AppendFormat("<a title='Search: {0} Title' href='/Cards/Search?Query=%2Btitle%3A{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "title-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Query=%2Btitle%3A{1}&CardType=Hero' target='_blank'>{0}</a>", label, key);
                    break;
                case "self":
                    //sb.AppendFormat("<a title='Card: {0}' href='/Cards/Details/{1}' target='_blank'>{0}</a>", label, key);
                    sb.AppendFormat(label.Replace("%27", "'"));
                    break;
                case "trait":
                    sb.AppendFormat("<a title='Search: {0} Trait' href='/Cards/Search?Trait={1}' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-search":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?{1}' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/Cards/Search?Trait={1}&CardType=Character' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-attachment":
                    sb.AppendFormat("<a title='Search: {0} Attachment' href='/Cards/Search?Trait={1}&CardType=Attachment' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "unique-trait-character":
                    sb.AppendFormat("<a title='Search: Unique {0} Character' href='/Cards/Search?Trait={1}&CardType=Character&IsUnique=Yes' target='_blank'>unique <b><i>{0}</i></b> character</a>", label, key);
                    break;
                case "trait-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Trait={1}&CardType=Hero' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "traits-character":
                    {
                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Character' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Character' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> character</a>", trait1, trait2, key);
                    }
                    break;
                case "traits-hero":
                    {
                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Hero' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Hero' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> hero</a>", trait1, trait2, key);
                    }
                    break;
                case "traits-attachment":
                    {
                        if (string.IsNullOrEmpty(label))
                        {
                            label = "attachment";
                        }
                        var join = "or";
                        if (label == "attachments")
                        {
                            join = "and";
                        }

                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Attachment' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Attachment' target='_blank'><b><i>{0}</i></b> {4} <b><i>{1}</i></b> {3}</a>", trait1, trait2, key, label, join);
                    }
                    break;
                case "trait-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/Cards/Search?Trait={1}&CardType=Ally' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-location":
                    sb.AppendFormat("<a title='Search: {0} Location' href='/Cards/Search?Trait={1}&CardType=Location' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "keyword":
                    sb.AppendFormat("<a title='Search: {0} Keyword' href='/Cards/Search?Keyword={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "keyword-hero":
                    sb.AppendFormat("<a title='Search: Hero with {0} Keyword' href='/Cards/Search?Keyword={1}&CardType=Hero' target='_blank'>hero with {0}</a>", label, key);
                    break;
                case "type":
                    sb.AppendFormat("<a title='Search: {0} Type' href='/Cards/Search?CardType={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "sphere":
                    sb.AppendFormat("<a title='Search: {0} Sphere' href='/Cards/Search?Sphere={0}' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /></a>", key);
                    break;
                case "sphere-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/Cards/Search?Sphere={0}&CardType=Character' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> character</a>", key);
                    break;
                case "sphere-hero":
                    innerText = (!string.IsNullOrEmpty(label) && label == "!") ? string.Empty : " hero";
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Sphere={0}&CardType=Hero' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' />{1}</a>", key, innerText);
                    break;
                case "sphere-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/Cards/Search?Sphere={0}&CardType=Ally' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> ally</a>", key);
                    break;
                case "sphere-event":
                    sb.AppendFormat("<a title='Search: {0} Event' href='/Cards/Search?Sphere={0}&CardType=Event' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> event</a>", key);
                    break;
                case "willpower":
                    sb.Append("<img src='/Images/willpower.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "threat":
                    sb.Append("<img src='/Images/threat.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "attack":
                    sb.Append("<img src='/Images/attack.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "defense":
                    sb.Append("<img src='/Images/defense.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "victory":
                    sb.AppendFormat("<div class='victory-text'><a style='text-decoration:none;' href='/Cards/Search?VictoryPoints=Victory+{0}.' target='_blank' title='Victory: {0}'><span style='padding-left:4px;padding-right:4px;border-style:solid;border-width:1px;border-color:black;'>Victory {0}</span></a></div>", key);
                    break;
                case "pass":
                    sb.Append("<div class='pass-text'><b>PASS</b></div>");
                    break;
                case "shadow":
                    sb.Append("<img src='/Images/ShadowDivider.png' title='Shadow Effect' style='display:block;margin-left:auto;margin-right:auto;width:285px;'/>");
                    break;
                case "sailing-success":
                    sb.Append("<div class='sailing-success'><img src='/Images/sailing-success.png' title='Sailing Test Success'/></div>");
                    break;
                case "sailing-success2":
                    sb.Append("<div class='sailing-success'><img src='/Images/sailing-success.png' title='Sailing Test Success'/><img src='/Images/sailing-success.png' title='Sailing Test Success'/></div>");
                    break;
                case "sailing-success-small":
                    sb.Append("<img style='height:15px; width:15px; margin-bottom:-2px;' src='/Images/sailing-success.png' title='Sailing Test Success'/>");
                    break;
                case "heading-sunny":
                    sb.Append("<img class='heading-icon heading-sunny-icon' src='/Images/heading-sunny.png' title='Sunny Heading' />");
                    break;
                case "heading-cloudy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-cloudy.png' title='Cloudy Heading' />");
                    break;
                case "heading-rainy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-rainy.png' title='Rainy Heading' />");
                    break;
                case "heading-stormy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-stormy.png' title='Stormy Heading' />");
                    break;
                case "heading-sunny2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-sunny2.png' title='Sunny Heading' />");
                    break;
                case "heading-cloudy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-cloudy2.png' title='Cloudy Heading' />");
                    break;
                case "heading-rainy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-rainy2.png' title='Rainy Heading' />");
                    break;
                case "heading-stormy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-stormy2.png' title='Stormy Heading' />");
                    break;
                case "compass-rose":
                    sb.Append("<img src='/Images/compass-rose.png'/>");
                    break;
                default:
                    sb.Append("<p>UNRECOGNIZED TYPE: " + type.ToLowerSafe() + "</p>");
                    break;
            }
        }

        private string renderHtmlTemplate(string template)
        {            
            if (string.IsNullOrEmpty(template))
            {
                return string.Empty;
            }

            var s = new StringBuilder();
            var t = template;

            var isToken = false;
            var isType = false;
            var type = string.Empty;
            var isKey = false;
            var key = string.Empty;
            var isLabel = false;
            var label = string.Empty;

            for (var i = 0; i < t.Length; i++)
            {
                if (t[i] == '{') {
                    isToken = true;
                    isType = true;
                } else {
                    if (isToken) {
                        switch (t[i]) {
                            case '}':
                                isToken = false;
                                isType = false;
                                isKey = false;
                                isLabel = false;
                                if (type == "self")
                                {
                                    if (string.IsNullOrEmpty(key))
                                    {
                                        key = this.Slug;
                                    }
                                    if (string.IsNullOrEmpty(label))
                                    {
                                        label = this.Title;
                                    }
                                }

                                insertToken(s, type, key, label);
                                type = string.Empty;
                                key = string.Empty;
                                label = string.Empty;
                                break;
                            case ':':
                                isType = false;
                                isKey = true;
                                isLabel = false;
                                break;
                            case '@':
                                isType = false;
                                isKey = false;
                                isLabel = true;
                                break;
                            default:
                                {
                                    if (isType)
                                    {
                                        type += t[i];
                                    }
                                    else if (isKey)
                                    {
                                        key += t[i];
                                    }
                                    else if (isLabel)
                                    {
                                        label += t[i];
                                    }
                                }
                                break;
                        }
                    } else {
                        s.Append(t[i]);
                    }
                }
            }

            return s.ToString();
        }

        public string Html
        {
            get
            {
                if (!string.IsNullOrEmpty(HtmlTemplate) && string.IsNullOrEmpty(html)) 
                {
                    html = renderHtmlTemplate(HtmlTemplate);
                }

                return html;
            }
            set { html = value; }
        }

        public string HtmlTemplate;

        public string Html2
        {
            get
            {
                if (!string.IsNullOrEmpty(HtmlTemplate2) && string.IsNullOrEmpty(html2))
                {
                    html2 = renderHtmlTemplate(HtmlTemplate2);
                }

                return html2;
            }
            set { html2 = value; }
        }

        public string HtmlTemplate2;

        public LotRCard WithTemplate(string htmlTemplate)
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

        public LotRCard WithOppositeFlavor(string flavor)
        {
            this.OppositeFlavorText = flavor;
            return this;
        }

        public LotRCard WithSuffix(string suffix)
        {
            this.Suffix = suffix;
            return this;
        }

        public LotRCard WithSecondImage(string secondImagePath)
        {
            this.hasSecondImage = true;
            this.secondImagePath = secondImagePath;
            return this;
        }

        public LotRCard Flavor(string flavor)
        {
            effects.Add(new Effect(CardEffectType.Flavor_Text, LayoutType.Block).Flavor(flavor));
            return this;
        }

        public LotRCard Important(string important)
        {
            effects.Add(new Effect(CardEffectType.Flavor_Text, LayoutType.Important).Text(important));
            return this;
        }

        public LotRCard Effect(Effect effect)
        {
            effects.Add(effect);
            return this;
        }

        public LotRCard WithStageLetter(char letter)
        {
            StageLetter = letter;
            return this;
        }

        #endregion


        public string Id { get; set; }

        public string ShortSlug { get; set; }
        public string OctgnSlug { get; set; }
        public int ScenarioNumber { get; set; }

        public string Title { get; set; }
        public string NormalizedTitle { get; set; }
        public string OppositeTitle { get; set; }
        public string NormalizedOppositeTitle { get; set; }

        public uint Number { get; set; }
        public uint StageNumber { get; set; }
        public char StageLetter { get; set; }
        
        public string ImageName { get; set; }
        public ImageType ImageType { get; set; }

        public CardSet CardSet { get; set; }

        public CardType CardType { get; set; }
        public CardSubtype CardSubtype { get; set; }
        public Sphere Sphere { get; set; }

        private byte maxPerDeck;
        public byte MaxPerDeck
        {
            get
            {
                if (maxPerDeck > 0)
                {
                    return maxPerDeck;
                }

                switch (CardType)
                {
                    case Models.LotR.CardType.Hero:
                    case Models.LotR.CardType.Player_Side_Quest:
                        return 1;
                    case Models.LotR.CardType.Ally:
                    case Models.LotR.CardType.Attachment:
                    case Models.LotR.CardType.Event:
                        return 3;
                    default:
                        return 0;
                }
            }
            set
            {
                maxPerDeck = value;
            }
        }

        public byte? ThreatCost { get; set; }
        public byte? ResourceCost { get; set; }
        public byte? EngagementCost { get; set; }
        public byte? Threat { get; set; }
        public bool IsVariableCost { get; set; }
        public bool IsVariableThreat { get; set; }
        public bool IsVariableQuestPoints { get; set; }
        public bool IsVariableWillpower { get; set; }
        public bool IsVariableAttack { get; set; }
        public bool IsVariableDefense { get; set; }
        public bool IsVariableHitPoints { get; set; }
        public bool IsVariableVictoryPoints { get; set; }
        public byte? Willpower { get; set; }
        public byte? Attack { get; set; }
        public byte? Defense { get; set; }
        public byte? HitPoints { get; set; }
        public byte? QuestPoints { get; set; }

        public List<string> NormalizedTraits { get; set; }

        public List<string> NormalizedKeywords { get; set; }

        public List<Category> Categories { get; private set; }
        public List<EncounterCategory> EncounterCategories { get; private set; }
        public List<QuestCategory> QuestCategories { get; private set; }

        public string OppositeText { get; set; }
        public string OppositeFlavorText { get; set; }
        public string Shadow { get; set; }
        public string EncounterSet { get; set; }
        public string AlternateEncounterSet { get; set; }
        public List<EncounterSet> IncludedEncounterSets { get; set; }
        public bool? PassValue { get; set; }
        public byte Quantity { get; set; }
        public byte? EasyModeQuantity { get; set; }
        public byte? NightmareModeQuantity { get; set; }
        public string Setup { get; set; }

        public string FlavorText { get; set; }
        public Artist SecondArtist { get; set; }
        
        public ushort Year { get; set; }
        public bool SlugIncludesOppositeTitle { get; set; }
        public bool SlugIncludesType { get; set; }
        public string Suffix { get; set; }

        private bool hasSecondImage;
        public bool HasSecondImage {
            get
            {
                if (CardType == Models.LotR.CardType.Quest)
                {
                    return true;
                }

                return hasSecondImage;
            }
            set { hasSecondImage = value; }
        }

        private string secondImagePath;

        public string SecondImagePath
        {
            get { return secondImagePath; }
        }

        public string Slug
        {
            get
            {
                var title = !string.IsNullOrEmpty(NormalizedTitle) ?  NormalizedTitle.ToUrlSafeString() : Title.ToUrlSafeString();
                var subtitle = SlugIncludesOppositeTitle ? string.Format("{0}-", OppositeTitle.ToUrlSafeString()) : string.Empty;
                var type = SlugIncludesType ? string.Format("{0}-", CardType.ToString().ToUrlSafeString()) : string.Empty;
                var suffix = !string.IsNullOrEmpty(Suffix) ? string.Format("{0}-", Suffix) : string.Empty;
                var set = CardSet.Abbreviation.ToString().ToUrlSafeString();
                return string.Format("{0}-{1}{2}{3}{4}", title, subtitle, suffix, type, set);
            }
        }

        public string AlternateSlug
        {
            get;
            set;
        }

        public bool HasErrata { get; set; }

        protected DeckType deckType = DeckType.None;
        public DeckType DeckType
        {
            get {
                if (deckType != DeckType.None) {
                    return deckType;
                }

                switch (CardType)
                {
                    case Models.LotR.CardType.Hero:
                    case Models.LotR.CardType.Ally:
                    case Models.LotR.CardType.Attachment:
                    case Models.LotR.CardType.Event:
                    case Models.LotR.CardType.Treasure:
                    case Models.LotR.CardType.Player_Side_Quest:
                        return DeckType.Player;
                    case Models.LotR.CardType.Enemy:
                    case Models.LotR.CardType.Location:
                    case Models.LotR.CardType.Treachery:
                    case Models.LotR.CardType.Objective:
                    case Models.LotR.CardType.Objective_Ally:
                    case Models.LotR.CardType.Objective_Hero:
                    case Models.LotR.CardType.Objective_Location:
                    case Models.LotR.CardType.Encounter_Side_Quest:
                        return DeckType.Encounter;
                    case Models.LotR.CardType.Quest:
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Nightmare_Setup:
                        return DeckType.Quest;
                    default:
                        return DeckType.None;
                }
            }
        }

        public static LotRCard Hero(string title, string id, Sphere sphere, byte threatCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Hero,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                IsUnique = true,
                Sphere = sphere,
                ThreatCost = threatCost,
                Willpower = willpower,
                IsVariableWillpower = (willpower == 254),
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard Ally(string title, string id, Sphere sphere, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Ally,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                IsUnique = true,
                Sphere = sphere,
                ResourceCost = resourceCost,
                Willpower = willpower,
                IsVariableWillpower = (willpower == 254),
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                Sphere = sphere,
                ResourceCost = resourceCost
            };
        }

        public static LotRCard ObjectiveHero(string title, string encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Objective_Hero,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.Empty,
                EncounterSet = encounterSet,
                IsUnique = true,
                Willpower = willpower,
                IsVariableWillpower = (willpower == 254),
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard Enemy(string title, string id, string encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            var isVariableThreat = threat.HasValue && threat.Value == byte.MaxValue;
            var isVariableAttack = attack.HasValue && attack.Value == byte.MaxValue;
            var isVariableDefense = defense.HasValue && defense.Value == byte.MaxValue;
            var isVariableHitPoints = hitPoints.HasValue && hitPoints.Value == byte.MaxValue;

            if (threat == 254)
            {
                threat = 255;
            }

            if (attack == 254)
            {
                attack = 255;
            }

            if (defense == 254)
            {
                defense = 255;
            }

            if (hitPoints == 254)
            {
                hitPoints = 255;
            }

            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Enemy,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                EngagementCost = engagementCost,
                Threat = threat,
                IsVariableThreat = isVariableThreat,
                Attack = attack,
                IsVariableAttack = isVariableAttack,
                Defense = defense,
                IsVariableDefense = isVariableDefense,
                HitPoints = hitPoints,
                IsVariableHitPoints = isVariableHitPoints,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard Location(string title, string id, string encounterSet, byte? threat, byte questPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Location,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                Threat = threat,
                IsVariableThreat = threat.HasValue && threat.Value == (byte)254,
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard EncounterSideQuest(string title, string id, string encounterSet, byte questPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Encounter_Side_Quest,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id,
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                Sphere = sphere,
                ResourceCost = resourceCost,
                QuestPoints = questPoints
            };
        }

        public static LotRCard Quest(string title, string id, int scenarioNumber, uint stageNumber, string encounterSet, byte? questPoints)
        {
            return Quest(title, id, scenarioNumber, stageNumber, encounterSet, questPoints, 'A');
        }

        public static LotRCard Quest(string title, string id, int scenarioNumber, uint stageNumber, string encounterSet, byte? questPoints, char stageLetter)
        {
            return new LotRCard()
            {
                CardType = CardType.Quest,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                HasSecondImage = true,
                Id = id,
                EncounterSet = encounterSet,
                QuestPoints = questPoints,
                IsVariableQuestPoints = questPoints == (byte)254,
                ScenarioNumber = scenarioNumber,
                StageNumber = stageNumber,
                StageLetter = stageLetter
            };
        }

        public static LotRCard Campaign(string title, string id, int scenarioNumber, string encounterSet, string oppositeTitle)
        {
            return new LotRCard()
            {
                CardType = CardType.Campaign,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                HasSecondImage = true,
                Id = id,
                EncounterSet = encounterSet,
                ScenarioNumber = scenarioNumber,
                SlugIncludesType = true,
                OppositeTitle = oppositeTitle
            };
        }

        public static LotRCard NightmareSetup(string title, string encounterSet)
        {
            return new LotRCard()
            {
                CardType = CardType.Nightmare_Setup,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                HasSecondImage = true,
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                HasSecondImage = true,
                Id = string.Empty,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard Scenario(string title, int scenarioNumber, string encounterSet, string oppositeTitle)
        {
            return new LotRCard()
            {
                CardType = CardType.Scenario,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                HasSecondImage = true,
                Id = string.Empty,
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
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                EncounterSet = encounterSet
            };
        }

        public static LotRCard ObjectiveAlly(string title, string id, string encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Objective_Ally,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = id,
                EncounterSet = encounterSet,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard ObjectiveLocation(string title, string encounterSet, byte questPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Objective_Location,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.Empty,
                EncounterSet = encounterSet,
                QuestPoints = questPoints
            };
        }

        public static LotRCard ShipObjective(string title, string encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = CardType.Ship_Objective,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                IsUnique = true,
                Id = string.Empty,
                EncounterSet = encounterSet,
                Willpower = willpower,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public static LotRCard ShipEnemy(string title, string encounterSet, byte engagementCost, byte threat, byte attack, byte defense, byte hitPoints)
        {
            return new LotRCard()
            {
                CardType = Models.LotR.CardType.Ship_Enemy,
                Title = title,
                NormalizedTitle = title.NormalizeCaseSensitiveString(),
                Id = string.Empty,
                EncounterSet = encounterSet,
                EngagementCost = engagementCost,
                Threat = threat,
                Attack = attack,
                Defense = defense,
                HitPoints = hitPoints
            };
        }

        public LotRCard ClearText()
        {
            this.Text = string.Empty;
            return this;
        }

        public LotRCard WithShortSlug(string shortSlug)
        {
            this.ShortSlug = shortSlug;
            return this;
        }

        public LotRCard WithOctgnSlug(string octgnSlug)
        {
            this.OctgnSlug = octgnSlug;
            return this;
        }

        public LotRCard WithGeneric()
        {
            this.IsUnique = false;
            return this;
        }

        public LotRCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public LotRCard WithSlugIncludesType()
        {
            this.SlugIncludesType = true;
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

            foreach (var trait in traits)
            {
                if (trait != trait.NormalizeString())
                {
                    this.NormalizedTraits.Add(trait.NormalizeString());
                }
            }

            return this;
        }

        public LotRCard WithVictoryPoints(byte victoryPoints)
        {
            this.VictoryPoints = victoryPoints;
            return this;
        }

        public LotRCard WithNormalizedTitle(string normalizedTitle)
        {
            this.NormalizedTitle = normalizedTitle;
            return this;
        }

        public LotRCard WithKeywords(params string[] keywords)
        {
            addKeywords(keywords);
            return this;
        }

        public LotRCard WithText(string text)
        {
            this.Text = text;
            return this;
        }

        public LotRCard WithOppositeTitle(string title, bool includedInSlug)
        {
            this.OppositeTitle = title;
            this.SlugIncludesOppositeTitle = includedInSlug;
            return this;
        }

        public LotRCard WithOppositeText(string text)
        {
            this.OppositeText = text;
            return this;
        }

        public LotRCard WithBackArtist(Artist artist)
        {
            this.BackArtist = artist;
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
            return this.WithEffect(CardEffectType.Shadow, shadow);
        }

        public LotRCard WithEffect(CardEffectType type, string effect)
        {
            switch (type)
            {
                case CardEffectType.Shadow:
                    {
                        var trigger = type.ToString().Replace('_', ' ') + ": ";
                        if (!string.IsNullOrEmpty(effect) && !effect.StartsWith(trigger))
                        {
                            this.Shadow = string.Format("{0}{1}", trigger, effect);
                        }
                        else
                        {
                            this.Shadow = effect;
                        }
                    }
                    break;
                case CardEffectType.Action:
                case CardEffectType.Combat_Action:
                case CardEffectType.Encounter_Action:
                case CardEffectType.Forced:
                case CardEffectType.Planning_Action:
                case CardEffectType.Quest_Action:
                case CardEffectType.Refresh_Action:
                case CardEffectType.Resource_Action:
                case CardEffectType.Response:
                case CardEffectType.Setup:
                case CardEffectType.Travel:
                case CardEffectType.Travel_Action:
                case CardEffectType.When_Revealed:
                    {
                        var trigger = type.ToString().Replace('_', ' ') + ": ";
                        if (!string.IsNullOrEmpty(effect) && !effect.StartsWith(trigger))
                        {
                            this.Text += string.Format("{0}{1}", trigger, effect);
                        }
                        else
                        {
                            this.Text += effect;
                        }
                    }
                    break;
                case CardEffectType.Flavor_Text:
                    this.FlavorText = effect;
                    break;
                default:
                case CardEffectType.None:
                case CardEffectType.Passive:
                    {
                        if (string.IsNullOrEmpty(this.Text))
                        {
                            this.Text = string.Empty;
                        }
                        else
                        {
                            this.Text += "\r\n";
                        }

                        this.Text += effect;
                    }
                    break;
            }

            return this;
        }

        public LotRCard WithYear(ushort year)
        {
            this.Year = year;
            return this;
        }

        public LotRCard WithInfo(uint number, byte quantity, Artist artist)
        {
            this.Number = number;
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

        public LotRCard WithErrata()
        {
            this.HasErrata = true;
            return this;
        }

        public LotRCard WithTypeBasedSlug()
        {
            this.SlugIncludesType = true;
            return this;
        }

        public byte? Popularity(Func<string, byte> lookup)
        {
            return lookup(this.Slug);
        }
    }
}
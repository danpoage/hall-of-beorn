using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Arkham.ViewModels
{
    public class ArkhamCardViewModel
    {
        public ArkhamCardViewModel(ArkhamCard card)
        {
            this.card = card;
        }

        private readonly ArkhamCard card;

        private const string arkhamCardImages = "https://s3.amazonaws.com/hallofbeorn-resources/Images/Arkham/Cards";

        public bool IsUnique { get { return card.IsUnique; } }

        public string DisplayName
        { 
            get
            {
                return (card.Level.HasValue && card.Level.Value > 0) ?
                    string.Format("{0} ({1})", card.Title, (sbyte)card.Level)
                    : card.Title;
            }
        }

        public string Subtitle
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Location:
                    case ArkhamCardType.Act:
                    case ArkhamCardType.Agenda:
                        return card.Subtitle;
                    default:
                        return card.CardSubtype != ArkhamCardSubtype.None ? card.CardSubtype.ToString().Replace("_", " ") : string.Empty;
                }
            }
        }

        public string Willpower { get { return card.Willpower.ToString(); } }
        public string Intellect { get { return card.Intellect.ToString(); } }
        public string Combat { get { return card.Combat.ToString(); } }
        public string Agility { get { return card.Agility.ToString(); } }
        
        public string Victory
        {
            get
            {
                return card.VictoryPoints.HasValue && card.VictoryPoints.Value > 0 ?
                    string.Format("Victory {0}", card.VictoryPoints.Value)
                    : string.Empty;
            }
        }

        private string getProductImagePath()
        {
            var product = card.Product.Name.ToUrlSafeString();
            return string.Format("{0}/{1}", arkhamCardImages, product);
        }

        private string getEncounterSetImage()
        {
            if (card.EncounterSet == null)
                return string.Empty;

            var product = getProductImagePath();
            var set = card.EncounterSet.Name.ToUrlSafeString();

            return string.Format("{0}/{1}.png", product, set);
        }

        private string getCardImagePath()
        {
            var product = getProductImagePath();
            var slug = card.Title.ToUrlSafeString();
            var level = (card.Level.HasValue && card.Level.Value > 0) ? card.Level.ToString() : string.Empty;
            var sequence = card.Sequence.HasValue ? string.Format("-{0}", card.Sequence) : string.Empty;

            return string.Format("{0}/{1}{2}{3}", product, slug, level, sequence);
        }

        public string SearchUrl
        {
            get { return string.Format("/Arkham/Details/{0}", card.Slug); }
        }

        public string ImagePathFront
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Act:
                    case ArkhamCardType.Agenda:
                        return string.Format("{0}a.jpg", getCardImagePath());
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Location:
                    case ArkhamCardType.Scenario_Reference:
                    case ArkhamCardType.Campaign_Rules:
                        return string.Format("{0}-Front.jpg", getCardImagePath());
                    default:
                        return string.Format("{0}.jpg", getCardImagePath());
                }
            }
        }

        public string ImagePathBack
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Act:
                    case ArkhamCardType.Agenda:
                        return string.Format("{0}b.jpg", getCardImagePath());
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Location:
                        return !string.IsNullOrEmpty(card.Subtitle) ? string.Format("{0}-{1}-Back.jpg", getCardImagePath(), card.Subtitle.ToUrlSafeString()) : string.Format("{0}-Back.jpg", getCardImagePath());
                    case ArkhamCardType.Scenario_Reference:
                    case ArkhamCardType.Campaign_Rules:
                        return string.Format("{0}-Back.jpg", getCardImagePath());
                    default:
                        return string.Empty;
                }
            }
        }

        public int ImageHeight
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Agenda:
                    case ArkhamCardType.Act:
                        return 212;
                    default:
                        return 300;
                }
            }
        }

        public int ImageWidth
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Agenda:
                    case ArkhamCardType.Act:
                        return 300;
                    default:
                        return 212;
                }
            }
        }

        public int ImageHeightBack
        {
            get
            {
                var type = card.BackCardType.HasValue ? card.BackCardType : card.CardType;

                switch (type)
                {
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Agenda:
                    case ArkhamCardType.Act:
                        return 212;
                    default:
                        return 300;
                }
            }
        }

        public int ImageWidthBack
        {
            get
            {
                var type = card.BackCardType.HasValue ? card.BackCardType : card.CardType;

                switch (type)
                {
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Agenda:
                    case ArkhamCardType.Act:
                        return 300;
                    default:
                        return 212;
                }
            }
        }

        public string SlotImagePath
        {
            get
            {
                return card.Slot.HasValue && card.Slot.Value != AssetSlot.None ?
                    string.Format("/Images/Arkham/Slot{0}.png", card.Slot.Value.ToString())
                    : string.Empty;
            }
        }

        public string SlotSearch
        {
            get
            {
                return card.Slot.HasValue && card.Slot.Value != AssetSlot.None ?
                    string.Format("/Arkham?Slot={0}", card.Slot.Value)
                    : string.Empty;
            }
        }

        public string CardType
        {
            get { return card.CardType.ToString(); }
        }

        public string CardSubtype
        {
            get { 
                return card.CardSubtype != ArkhamCardSubtype.None ? 
                    card.CardSubtype.ToString().Replace("_", " ") 
                    : string.Empty; 
            }
        }

        public string BackCardType
        {
            get { return card.BackCardType.HasValue ? card.BackCardType.Value.ToString().Replace("_", " ") : string.Empty; }
        }

        public string ClassName
        {
            get
            {
                if (card.CardSubtype == ArkhamCardSubtype.Basic_Weakness)
                    return "Basic Weakness";
                else if (card.EncounterSet != null)
                    return card.EncounterSet.Name;

                return card.ClassSymbol != ClassSymbol.None ? card.ClassSymbol.ToString() : string.Empty;
            }
        }

        public string ClassUrl
        {
            get
            {
                if (card.CardSubtype == ArkhamCardSubtype.Basic_Weakness)
                    return "/Arkham?CardSubtype=Basic_Weakness";
                else if (card.EncounterSet != null)
                    return string.Format("/Arkham?EncounterSet={0}", card.EncounterSet.Name);

                return card.ClassSymbol != ClassSymbol.None ? string.Format("/Arkham?ClassSymbol={0}", card.ClassSymbol) : string.Empty;
            }
        }

        public string ClassIcon
        {
            get
            {
                if (card.CardSubtype == ArkhamCardSubtype.Basic_Weakness)
                    return "<img src='/Images/Arkham/Basic_Weakness.png' width='32' height='28' title='Basic Weakness'/>";
                else if (card.EncounterSet != null)
                    return string.Format("<img src='{0}' width='32' height='32' title='{1}'/>", getEncounterSetImage(), ClassName);

                return card.ClassSymbol != ClassSymbol.None ? string.Format("<img src='/Images/Arkham/{0}.png' width='32' height='32' title='{0} Class'/>", ClassName) : string.Empty; 
            }
        }

        public string Cost
        {
            get { return (card.Cost.HasValue) ? card.Cost.Value.ToString() : string.Empty; }
        }

        public string Text
        {
            get
            {
                var text = new System.Text.StringBuilder();
                if (!string.IsNullOrEmpty(card.FrontText))
                {
                }

                return text.ToString();
            }
        }

        public string Health
        {
            get
            {
                return card.Health.HasValue ? card.Health.Value.ToString(string.Empty) : string.Empty;
            }
        }

        public string Sanity
        {
            get
            {
                return card.Sanity.HasValue ? card.Sanity.Value.ToString(string.Empty) : string.Empty;
            }
        }

        public string FightValue
        {
            get { return card.EnemyFightValue.HasValue ? card.EnemyFightValue.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public string HealthValue
        {
            get { return card.EnemyHealthValue.HasValue ? card.EnemyHealthValue.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public string EvadeValue
        {
            get { return card.EnemyEvadeValue.HasValue ? card.EnemyEvadeValue.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public byte Damage
        {
             get { return card.Damage.HasValue ? card.Damage.Value.Value : (byte)0; }
        }

        public byte Horror
        {
            get { return card.Horror.HasValue ? card.Horror.Value.Value : (byte)0; }
        }

        public string Sequence
        {
            get { return card.Sequence.HasValue ? card.Sequence.ToString() : string.Empty; }
        }

        public string DoomThreshold 
        {
            get { return card.DoomThreshold.HasValue ? card.DoomThreshold.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public string ClueThreshold
        {
            get { return card.ClueThreshold.HasValue ? card.ClueThreshold.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public bool HasTraits()
        {
            return card.Traits().Count() > 0;
        }

        public IEnumerable<LinkViewModel> Traits()
        {
            foreach (var trait in card.Traits())
                yield return new LinkViewModel() { Name = trait, Title = "Trait Search: " + trait, Target = "_blank", Href = "/Arkham?Trait=" + trait, CssClass = "arkham-trait" };
        }

        public IEnumerable<LinkViewModel> ConnectsTo()
        {
            foreach (var connection in card.Connections())
                yield return new LinkViewModel() { Name = connection.ToString().Replace("_", " "), Title = "Connects To", Target = "_blank", Href = "/Arkham?ConnectsTo=" +  connection.ToString() };
        }

        public bool HasSkillIcons()
        {
            return card.SkillIcons().Count() > 0;
        }

        public IEnumerable<string> SkillIcons()
        {
            foreach (var icon in card.SkillIcons())
                yield return string.Format("<a href='/Arkham?SkillIcon={0}'><img src='/Images/Arkham/{0}.png' title='{0}' class='arkham-skillIcon'/></a>", icon);
        }

        public const string PerInvestigatorBlackIcon = "<img src='/Images/Arkham/PerInvestigatorBlack.png' class='arkham-perInvestigator'/>";
        public const string PerInvestigatorWhiteIcon = "<img src='/Images/Arkham/PerInvestigatorWhite.png' class='arkham-perInvestigator'/>";
        public const string PerInvestigatorDescription = "Per Investigator";

        public string Shroud
        {
            get { return card.Shroud.HasValue ? card.Shroud.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public string ClueValue
        {
            get { return card.ClueValue.HasValue ? card.ClueValue.Value.ToString(PerInvestigatorBlackIcon) : string.Empty; }
        }

        public string EnemyStatHtml()
        {
            var html = new System.Text.StringBuilder();

            if (card.CardType == ArkhamCardType.Enemy || (card.BackCardType.HasValue && card.BackCardType.Value == ArkhamCardType.Enemy))
            {
                var fight = card.EnemyFightValue.HasValue ? card.EnemyFightValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;
                var health = card.EnemyHealthValue.HasValue ? card.EnemyHealthValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;
                var evade = card.EnemyEvadeValue.HasValue ? card.EnemyEvadeValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;

                html.AppendFormat("<div class='arkham-enemyFightValue' title='Fight Value'>{0}</div><div class='arkham-enemyHealthValue' title='Health Value'>{1}</div><div class='arkham-enemyEvadeValue' title='Evade Value'>{2}</div>", fight, health, evade);
            }

            return html.ToString();
        }

        private Dictionary<string, string> getTemplateMap()
        {
            var map = new Dictionary<string, string>();

            map["\r\n"] = "<br/>";
            map[" - "] = "&nbsp;&ndash;&nbsp;";
            map[" -- "] = "&nbsp;&mdash;&nbsp;";
            
            //Triggers
            map["{Action}"] = "<img title='Action' src='/Images/Arkham/Action.png' height='12' width='17'>";
            map["{Free Action}"] = "<img title='Free Action' src='/Images/Arkham/Free_Action.png' height='12' width='27'>";
            map["{Forced}"] = "<b>Forced</b>";
            map["{Reaction}"] = "<img title='Reaction' src='/Images/Arkham/Reaction.png' height='12' width='19'>";
            map["{Revelation}"] = "<b>Revelation</b>";
            
            //Symbols
            map["{Per Investigator}"] = "<img title='Reaction' src='/Images/Arkham/PerInvestigatorBlack.png' height='12' width='12'>";

            //Actions
            map["{Evade}"] = "<b>Evade</b>";
            map["{Fight}"] = "<b>Fight</b>";
            map["{Investigate}"] = "<b>Investigate</b>";
            map["{Parley}"] = "<b>Parley</b>";
            map["{Resign}"] = "<b>Resign.</b>";

            //Skills
            map["{Agility}"]  = "<img title='Agility Skill' src='/Images/Arkham/Agility_small.png'>";
            map["{Combat}"]  = "<img title='Combat Skill' src='/Images/Arkham/Combat_small.png'>";
            map["{Intellect}"]  = "<img title='Intellect Skill' src='/Images/Arkham/Intellect_small.png'>";
            map["{Willpower}"]  = "<img title='Willpower Skill' src='/Images/Arkham/Willpower_small.png'>";

            //Chaos Tokens
            map["{Cultist}"]  = "<img src='/Images/Arkham/Cultist.png'>";
            map["{Elder Sign}"] = "<img src='/Images/Arkham/Elder_Sign.png'>";
            map["{Elder Thing}"]  = "<img src='/Images/Arkham/Elder_Thing.png'>";
            map["{Skull}"] = "<img src='/Images/Arkham/Skull.png'>";
            map["{Tablet}"]  = "<img src='/Images/Arkham/Tablet.png'>";
            map["{Tentacle}"] = "<img src='/Images/Arkham/Tentacle.png'>";

            //Traits
            map["{t:Ancient One}"] = "<a href='/Arkham?Trait=Ancient+One.' target='_blank'><b><i>Ancient One</i></b></a>";
            map["{t:Bayou}"] = "<a href='/Arkham?Trait=Bayou.' target='_blank'><b><i>Bayou</i></b></a>";
            map["{t:Cultist}"] = "<a href='/Arkham?Trait=Cultist.' target='_blank'><b><i>Cultist</i></b></a>";
            map["{t:Elite}"] = "<a href='/Arkham?Trait=Elite.' target='_blank'><b><i>Elite</i></b></a>";
            map["{t:Ghoul}"] = "<a href='/Arkham?Trait=Ghoul.' target='_blank'><b><i>Ghoul</i></b></a>";
            map["{t:Madness}"] = "<a href='/Arkham?Trait=Madness.' target='_blank'><b><i>Madness</i></b></a>";
            map["{t:Monster}"] = "<a href='/Arkham?Trait=Monster.' target='_blank'><b><i>Monster</i></b></a>";
            map["{t:Tome}"] = "<a href='/Arkham?Trait=Tome.' target='_blank'><b><i>Tome</i></b></a>";
            map["{t:Trap}"] = "<a href='/Arkham?Trait=Trap.' target='_blank'><b><i>Trap</i></b></a>";

            //Keywords
            map["{k:Fast}"] = "<a href='/Arkham?Keyword=Fast.' target='_blank'>Fast.</a>";
            map["{k:Hunter}"] = "<a href='/Arkham?Keyword=Hunter.' target='_blank'>Hunter.</a>";
            map["{k:Surge}"] = "<a href='/Arkham?Keyword=Surge.' target='_blank'>Surge.</a>";

            return map;
        }

        public string FrontBodyHtml()
        {
            var body = new System.Text.StringBuilder();

            var map = getTemplateMap();
            
            if (!string.IsNullOrEmpty(card.FrontText))
            {
                var lines = card.FrontText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines) {
                    var text = line;
                    foreach(var item in map) {
                        text = text.Replace(item.Key, map[item.Key]);
                    }

                    body.AppendFormat("<p class='arkham-cardText'>{0}</p>", text);
                }
            }

            if (!string.IsNullOrEmpty(card.FrontFlavor))
            {
                var text = card.FrontFlavor.Replace("\r\n", "<br/>");
                body.AppendFormat("<p class='arkham-flavorText'>{0}</p>", text);
            }

            return body.ToString();
        }

        public string BodyHtml()
        {
            var body = new System.Text.StringBuilder();

            var map = getTemplateMap();
            
            if (!string.IsNullOrEmpty(card.FrontText))
            {
                var lines = card.FrontText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines) {
                    var text = line;
                    foreach(var item in map) {
                        text = text.Replace(item.Key, map[item.Key]);
                    }

                    body.AppendFormat("<p class='arkham-cardText'>{0}</p>", text);
                }
            }

            if (!string.IsNullOrEmpty(card.FrontFlavor))
            {
                body.AppendFormat("<p class='arkham-flavorText'>{0}</p>", card.FrontFlavor);
            }
            
            if (!string.IsNullOrEmpty(card.BackText))
            {
                var lines = card.BackText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines) {
                    var text = line;
                    foreach(var item in map) {
                        text = text.Replace(item.Key, map[item.Key]);
                    }

                    body.AppendFormat("<p class='arkham-cardText'>{0}</p>", text);
                }
            }

            if (!string.IsNullOrEmpty(card.BackFlavor))
            {
                if (body.Length > 0 && string.IsNullOrEmpty(card.BackText))
                {
                    //body.Append("---");
                }

                body.AppendFormat("<p class='arkham-flavorText'>{0}</p>", card.BackFlavor);
            }

            return body.ToString();
        }
    }
}
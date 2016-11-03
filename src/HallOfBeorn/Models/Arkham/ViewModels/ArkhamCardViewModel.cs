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
                        return string.Empty;
                }
            }
        }

        public string Willpower { get { return card.Willpower.ToString(); } }
        public string Intellect { get { return card.Intellect.ToString(); } }
        public string Combat { get { return card.Combat.ToString(); } }
        public string Agility { get { return card.Agility.ToString(); } }

        private string getBaseImagePath()
        {
            var slug = card.Title.ToUrlSafeString();
            var product = card.Product.Name.ToUrlSafeString();
            var level = (card.Level.HasValue && card.Level.Value > 0) ? card.Level.ToString() : string.Empty;
            var sequence = card.Sequence.HasValue ? string.Format("-{0}", card.Sequence) : string.Empty;

            return string.Format("{0}/{1}/{2}{3}{4}", arkhamCardImages, product, slug, level, sequence);
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
                        return string.Format("{0}a.jpg", getBaseImagePath());
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Location:
                        return string.Format("{0}-Front.jpg", getBaseImagePath());
                    default:
                        return string.Format("{0}.jpg", getBaseImagePath());
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
                        return string.Format("{0}b.jpg", getBaseImagePath());
                    case ArkhamCardType.Investigator:
                    case ArkhamCardType.Location:
                        return string.Format("{0}-Back.jpg", getBaseImagePath());
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
            get
            {
                return card.CardType.ToString();
            }
        }

        public string ClassName
        {
            get { return card.ClassSymbol != ClassSymbol.None ? card.ClassSymbol.ToString() : string.Empty; }
        }

        public string ClassIcon
        {
            get { return card.ClassSymbol != ClassSymbol.None ? string.Format("/Images/Arkham/{0}.png", ClassName) : string.Empty; }
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

        public string Damage
        {
             get { return card.Damage.HasValue ? card.Damage.Value.ToString() : string.Empty; }
        }

        public string Horror
        {
            get { return card.Horror.HasValue ? card.Horror.Value.ToString() : string.Empty; }
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

            if (card.CardType == ArkhamCardType.Enemy)
            {
                var fight = card.EnemyFightValue.HasValue ? card.EnemyFightValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;
                var health = card.EnemyHealthValue.HasValue ? card.EnemyHealthValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;
                var evade = card.EnemyEvadeValue.HasValue ? card.EnemyEvadeValue.Value.ToString(PerInvestigatorWhiteIcon) : string.Empty;

                html.AppendFormat("<div class='arkham-enemyFightValue'>{0}</div><div class='arkham-enemyHealthValue'>{1}</div><div class='arkham-enemyEvadeValue'>{2}</div>", fight, health, evade);
            }

            return html.ToString();
        }

        private Dictionary<string, string> getTemplateMap()
        {
            var map = new Dictionary<string, string>();

            map["\r\n"] = "<br/>";
            map[" - "] = "&mdash;";
            
            //Triggers
            map["{Forced}"] = "<b>Forced</b>";
            map["{Revelation}"] = "<b>Revelation</b>";
            map["{Free Action}"] = "<img title='Free Action' src='/Images/Arkham/Free_Action.png' height='12' width='27'>";
            map["{Action}"] = "<img title='Action' src='/Images/Arkham/Action.png' height='12' width='17'>";
            map["{Reaction}"] = "<img title='Reaction' src='/Images/Arkham/Reaction.png' height='12' width='19'>";

            //Actions
            map["{Fight}"] = "<b>Fight</b>";
            map["{Evade}"] = "<b>Evade</b>";
            map["{Investigate}"] = "<b>Investigate</b>";

            //Skills
            map["{Willpower}"]  = "<img title='Willpower Skill' src='/Images/Arkham/Willpower_small.png'>";
            map["{Intellect}"]  = "<img title='Intellect Skill' src='/Images/Arkham/Intellect_small.png'>";
            map["{Combat}"]  = "<img title='Combat Skill' src='/Images/Arkham/Combat_small.png'>";
            map["{Agility}"]  = "<img title='Agility Skill' src='/Images/Arkham/Agility_small.png'>";

            //Chaos Tokens
            map["{Skull}"] = "<img src='/Images/Arkham/Skull.png'>";
            map["{Cultist}"]  = "<img src='/Images/Arkham/Cultist.png'>";
            map["{Tablet}"]  = "<img src='/Images/Arkham/Tablet.png'>";
            map["{Elder Thing}"]  = "<img src='/Images/Arkham/Elder_Thing.png'>";
            map["{Elder Sign}"] = "<img src='/Images/Arkham/Elder_Sign.png'>";
            map["{Tentacle}"] = "<img src='/Images/Arkham/Tentacle.png'>";

            //Traits
            map["{t:Tome}"] = "<a href='/Arkham?Trait=Tome.' target='_blank'><b><i>Tome</i></b></a>";

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

            if (!string.IsNullOrEmpty(card.FrontText))
            {
                body.AppendFormat("<p class='arkham-cardText'>{0}</p>", card.FrontText);
            }

            if (!string.IsNullOrEmpty(card.FrontFlavor))
            {
                body.AppendFormat("<p class='arkham-flavorText'>{0}</p>", card.FrontFlavor);
            }

            if (!string.IsNullOrEmpty(card.BackText))
            {
                if (body.Length > 0)
                {
                    //body.Append("---");
                }

                body.AppendFormat("<p class='arkham-cardText'>{0}</p>", card.BackText);
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
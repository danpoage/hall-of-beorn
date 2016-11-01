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
                        return 240;
                    default:
                        return 300;
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
                if  (!card.Health.HasValue)
                    return string.Empty;
                
                return card.Health.Value > 0 ? card.Health.ToString() : "-";
            }
        }

        public string Sanity
        {
            get
            {
                if (!card.Sanity.HasValue)
                    return string.Empty;

                return card.Sanity.Value > 0 ? card.Sanity.ToString() : "-";
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
                yield return new LinkViewModel() { Name = trait, Title = "Trait Search: " + trait, Target = "_blank", Href = "/Arkham/Search?Trait=" + trait, CssClass = "arkham-trait" };
        }

        public IEnumerable<LinkViewModel> ConnectsTo()
        {
            foreach (var connection in card.Connections())
                yield return new LinkViewModel() { Name = connection.ToString().Replace("_", " "), Title = "Connects To", Target = "_blank", Href = "/Arkham/Search?ConnectsTo=" +  connection.ToString() };
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

            if (!string.IsNullOrEmpty(card.FrontFlavor))
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
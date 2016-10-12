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
                return (card.Level != Level.NA && card.Level != Level.Zero) ?
                    string.Format("{0} ({1})", card.Name, (sbyte)card.Level)
                    : card.Name;
            }
        }

        public string Subtitle
        {
            get
            {
                switch (card.CardType)
                {
                    case ArkhamCardType.Investigator:
                        return card.NickName;
                    default:
                        return string.Empty;
                }
            }
        }

        public string Willpower { get { return ((sbyte)card.Willpower).ToString(); } }
        public string Intellect { get { return ((sbyte)card.Intellect).ToString(); } }
        public string Combat { get { return ((sbyte)card.Combat).ToString(); } }
        public string Agility { get { return ((sbyte)card.Agility).ToString(); } }

        private string getBaseImagePath()
        {
            var slug = card.Name.ToUrlSafeString();
            var product = card.Product.Name.ToUrlSafeString();
            var level = (card.Level != Level.NA && card.Level != Level.Zero) ? ((sbyte)card.Level).ToString() : string.Empty;

            return string.Format("{0}/{1}/{2}{3}", arkhamCardImages, product, slug, level);
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
                    case ArkhamCardType.Investigator:
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
                    case ArkhamCardType.Investigator:
                        return string.Format("{0}-Back.jpg", getBaseImagePath());
                    default:
                        return string.Empty;
                }
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
            get { return card.Class != ArkhamClass.None ? card.Class.ToString() : string.Empty; }
        }

        public string ClassIcon
        {
            get { return card.Class != ArkhamClass.None ? string.Format("/Images/Arkham/{0}.png", ClassName) : string.Empty; }
        }

        public string Cost
        {
            get
            {
                if (card.Cost == ArkhamCardCost.NA)
                    return string.Empty;

                switch (card.Cost)
                {
                    case ArkhamCardCost.X:
                        return "X";
                    default:
                        return ((int)card.Cost).ToString();
                }
            }
        }
    }
}
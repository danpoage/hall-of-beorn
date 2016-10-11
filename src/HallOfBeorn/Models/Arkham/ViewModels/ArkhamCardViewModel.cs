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
        public string Name { get { return card.Name; } }

        private string getBaseImagePath()
        {
            var slug = Name.ToUrlSafeString();
            var product = card.Product.Name.ToUrlSafeString();
            var level = card.Level != ArkhamCardLevel.NA ? string.Format("-{0}", (sbyte)card.Level) : string.Empty;

            return string.Format("{0}/{1}/{2}{3}", arkhamCardImages, product, slug, level);
        }

        public string SearchUrl
        {
            get
            {
                var slug = Name.ToUrlSafeString();
                var level = card.Level != ArkhamCardLevel.NA ? string.Format("-{0}", (sbyte)card.Level) : string.Empty;
                var product = card.Product.Abbreviation;
                return string.Format("/Arkham/Details/{0}{1}-{2}", slug, level, product);
            }
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
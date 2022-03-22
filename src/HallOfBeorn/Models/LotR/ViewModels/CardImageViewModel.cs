using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardImageViewModel
    {
        public CardImageViewModel(LotRCard card, Language lang)
        {
            this.card = card;
            this.lang = lang;

            if (isLandscapeImage)
            {
                DetailPixelHeight = 280;
                DetailPixelWidth = 400;
                ThumbnailPixelHeight = 128;
                ThumbnailPixelWidth = 180;
            }
            else
            {
                DetailPixelHeight = 400;
                DetailPixelWidth = 280;
                ThumbnailPixelHeight = 180;
                ThumbnailPixelWidth = 128;
            }
        }

        private readonly LotRCard card;
        private readonly Language lang;

        private readonly HashSet<CardType> canBeDoubleSided = new HashSet<CardType> { CardType.Location, CardType.Encounter_Side_Quest };
        private readonly HashSet<CardType> landscapeCardTypes = new HashSet<CardType> { CardType.Quest, CardType.Encounter_Side_Quest, CardType.Player_Side_Quest, CardType.Cave };

        private string secondImagePath
        {
            get
            {
                if (!string.IsNullOrEmpty(card.OppositeTitle) && canBeDoubleSided.Contains(card.CardType))
                {
                    return card.OppositeTitle.ToUrlSafeString();
                }

                return string.Empty;
            }
        }

        public bool HasSecondImage
        {
            get
            {
                if (!string.IsNullOrEmpty(card.OppositeTitle) && canBeDoubleSided.Contains(card.CardType)) {
                    return true;
                }

                switch (card.CardType)
                {
                    case LotR.CardType.GenCon_Setup:
                        return !string.IsNullOrEmpty(card.OppositeText);
                    case LotR.CardType.Quest:
                    case LotR.CardType.Scenario:
                    case LotR.CardType.Campaign:
                    case LotR.CardType.Nightmare_Setup:
                        return true;
                    case LotR.CardType.Contract:
                        return !string.IsNullOrWhiteSpace(card.OppositeText);
                    default:
                        return false;
                }
            }
        }

        private bool isLandscapeImage
        {
            get { return landscapeCardTypes.Contains(card.CardType); }
        }

        private static string getImagePath(LotRCard card, string directory, Language lang)
        {
            if (card.CardType == CardType.Quest)
            {
                return getQuestCardImagePath(card, true, lang);
            }

            if (card.CardType == CardType.Contract)
            {
                return getContractCardImagePath(card, true, lang);
            }

            if (card.CardType == CardType.Nightmare_Setup || card.CardType == CardType.GenCon_Setup)
            {
                return getSetupCardImagePath(card, true, lang);
            }

            var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
            var title = card.GetTitle(lang).ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;

            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                directory += "/" + Enum.GetName(typeof(Language), lang);
                extension = getTranslatedImageExtension(card, lang);
            }

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}{3}.{4}", directory, set, title, suffix, extension);
        }

        private static string getImagePathForLanguage(LotRCard card, Language? lang = null, bool isFirst = true)
        {
            var useLang = lang.HasValue ? lang.Value : card.DefaultLang;

            if (card.CardType == CardType.Quest)
            {
                return getQuestCardImagePath(card, isFirst, lang.GetValueOrDefault(Language.EN));
            }

            if (card.CardType == CardType.Contract)
            {
                return getContractCardImagePath(card, isFirst, useLang);
            }

            var setupCardTypes = new HashSet<CardType> { CardType.GenCon_Setup, CardType.Nightmare_Setup, CardType.Campaign, CardType.Scenario };

            if (setupCardTypes.Contains(card.CardType))
            {
                return getSetupCardImagePath(card, isFirst, useLang);
            }

            if (useLang == Language.EN)
            {
                var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
                var title = card.Title.ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;
                var extension = getEnglishImageExtension(card);

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}{2}.{3}", set, title, suffix, extension);
            } 
            else
            {
                var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
                var title = card.GetTitle(useLang).ToUrlSafeString();
                var suffix = !string.IsNullOrEmpty(card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;

                var langDirectory = Enum.GetName(typeof(Language), useLang);

                var extension = getTranslatedImageExtension(card, useLang);

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Cards/{0}/{1}/{2}{3}.{4}", langDirectory, set, title, suffix, extension);
            }
        }

        private readonly static Dictionary<SetType, HashSet<Language>> translatedSetTypes = new Dictionary<SetType, HashSet<Language>>
        {
            { SetType.A_Long_extended_Party, new HashSet<Language> { Language.DE, Language.ES, Language.FR, Language.IT, Language.PL } },
            { SetType.Core, new HashSet<Language> { Language.ES, Language.FR } },
        };

        private readonly static HashSet<string> englishSetsPng = new HashSet<string>
        {
            "Children of Eorl", "The Scouring of the Shire", "Fire on the Eastemnet", "The Gap of Rohan", "The Glittering Caves"
        };

        private static string getEnglishImageExtension(LotRCard card)
        {
            return englishSetsPng.Contains(card.CardSet.Name)
                ? "png"
                : "jpg";
        }

        private static string getTranslatedImageExtension(LotRCard card, Language lang)
        {
            return card.CardSet != null && translatedSetTypes.ContainsKey(card.CardSet.SetType) && translatedSetTypes[card.CardSet.SetType].Contains(lang)
                ? "png"
                : "jpg";
        }

        private string detailImagePath
        {
            get
            {
                return lang == Language.EN
                    ? getImagePath(card, "Cards", lang)
                    : getImagePath(card, "LotR/Cards", lang);
            }
        }

        private string thumbImagePath
        {
            get
            {
                return lang == Language.EN
                    ? getImagePath(card, "LotR/Thumbnails", lang)
                    : getImagePath(card, "LotR/Cards", lang);
            }
        }

        private static char getSecondStageLetter(LotRCard card)
        {
            return card.BackStageLetter.HasValue ? card.BackStageLetter.Value : (Char)(Convert.ToUInt16(card.StageLetter) + 1);
        }

        private static string getQuestCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

            var path = "Cards";
            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                set = lang.ToString() + "/" + set;
                path = "LotR/Cards";
                extension = getTranslatedImageExtension(card, lang);
            }

            var title = card.GetTitle(lang).ToUrlSafeString();
            var suffix = !string.IsNullOrEmpty( card.SlugSuffix) ? string.Format("-{0}", card.SlugSuffix.ToUrlSafeString()) : string.Empty;
            var number = card.StageNumber.ToString();

            var letter = isFirst ? "A" : "B";
            if (card.StageLetter != 'A')
            {
                letter = isFirst ? card.StageLetter.ToString() : getSecondStageLetter(card).ToString();
            }

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}{3}-{4}{5}.{6}", path, set, title, suffix, number, letter, extension);
        }

        private static string getSetupCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

            var path = "Cards";
            var extension = getEnglishImageExtension(card);

            if (lang != Language.EN)
            {
                set = lang.ToString() + "/" + set;
                path = "LotR/Cards";
                extension = getTranslatedImageExtension(card, lang);
            }

            var title = card.GetTitle(lang).ToUrlSafeString();

            var suffix = card.CardType == LotR.CardType.Scenario
                ? "Scenario"
                : "Setup";
            
            var letter = isFirst ? "A" : "B";

            return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}-{3}{4}.{5}", path, set, title, suffix, letter, extension);
        }

        private static string getContractCardImagePath(LotRCard card, bool isFirst, Language lang)
        {
            if (!string.IsNullOrEmpty(card.OppositeText))
            {
                var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

                var path = "Cards";
                var extension = getEnglishImageExtension(card);

                if (lang != Language.EN)
                {
                    set = lang.ToString() + "/" + set;
                    path = "LotR/Cards";
                    extension = getTranslatedImageExtension(card, lang);
                }

                var title = card.GetTitle(lang).ToUrlSafeString();
                var letter = isFirst ? "A" : "B";

                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}-Side{3}.{4}", path, set, title, letter, extension);
            }
            else 
            {
                var set = (card.CardSet != null && !string.IsNullOrEmpty(card.CardSet.NormalizedName)) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();

                var path = "Cards";
                var extension = getEnglishImageExtension(card);

                if (lang != Language.EN)
                {
                    set = lang.ToString() + "/" + set;
                    path = "LotR/Cards";
                    extension = getTranslatedImageExtension(card, lang);
                }

                var title = card.GetTitle(lang).ToUrlSafeString();
                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/{0}/{1}/{2}.{3}", path, set, title, extension);
            }
        }

        public string DetailFrontPath
        {
             get {

                if (HasSecondImage && !string.IsNullOrEmpty(secondImagePath))
                {
                    return getImagePathForLanguage(card, lang, true);
                }

                switch (card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardImagePath(card, true, lang); 
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(card, true, lang);
                    case Models.LotR.CardType.Contract:
                        return getContractCardImagePath(card, true, lang);
                    default:
                        return detailImagePath;
                }
            }
        }

        public string DetailBackPath
        {
            get
            {
                if (HasSecondImage && !string.IsNullOrEmpty(secondImagePath))
                {
                    var set = !string.IsNullOrEmpty(card.CardSet.NormalizedName) ? card.CardSet.NormalizedName.ToUrlSafeString() : card.CardSet.Name.ToUrlSafeString();
                    return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/{0}/{1}.jpg", set, secondImagePath);
                }

                switch (card.CardType)
                {
                    case Models.LotR.CardType.Quest:
                        return getQuestCardImagePath(card, false, lang);
                    case Models.LotR.CardType.Campaign:
                    case Models.LotR.CardType.Nightmare_Setup:
                    case Models.LotR.CardType.GenCon_Setup:
                    case Models.LotR.CardType.Scenario:
                        return getSetupCardImagePath(card, false, lang);
                    case Models.LotR.CardType.Contract:
                        return getContractCardImagePath(card, false, lang);
                    default:
                        return detailImagePath;
                }
            }
        }

        public string ThumbnailFrontPath
        {
            get { return thumbImagePath; }
        }

        public string ThumbnailBackPath { get; private set; }

        public int DetailPixelHeight { get; private set; }
        public int DetailPixelWidth { get; private set; }
        public int ThumbnailPixelHeight { get; private set; }
        public int ThumbnailPixelWidth { get; private set; }

        public string BackgroundImage()
        {
            switch (card.Sphere) 
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return string.Format("/Images/{0}.png", card.Sphere.ToString());
                default:
                    if (card.IsEncounterCard())
                    {
                        return "/Images/encounter-card-back.jpg";
                    }
                    return null;
            }
        }

        public string BackgroundImageTop()
        {
            switch (card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "-5px";
                default:
                    if (card.IsEncounterCard())
                    {
                        return "0px";
                    }
                    return "-5px";
            }
        }

        public string BackgroundImageLeft()
        {
            //48px
            switch (card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "48px";
                default:
                    if (card.IsEncounterCard())
                    {
                        return "0px";
                    }
                    return "48px;";
            }
        }

        public string BackgroundImageHeight()
        {
            switch (card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "200px";
                default:
                    if (card.IsEncounterCard())
                    {
                        return "100%";
                    }
                    return "200px";
            }
        }

        public string BackgroundImageWidth()
        {
            switch (card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                case Models.LotR.Sphere.Tactics:
                case Models.LotR.Sphere.Spirit:
                case Models.LotR.Sphere.Lore:
                case Models.LotR.Sphere.Baggins:
                case Models.LotR.Sphere.Fellowship:
                    return "200";
                default:
                    if (card.IsEncounterCard())
                    {
                        return "100%";
                    }
                    return "200";
            }
        }

        public string BackgroundColor()
        {
            switch (card.Sphere)
            {
                case Models.LotR.Sphere.Leadership:
                    return "rgba(128, 0, 128, .1)";
                case Models.LotR.Sphere.Tactics:
                    return "rgba(255, 0, 0, .1)";
                case Models.LotR.Sphere.Spirit:
                    return "rgba(0, 0, 255, .05)";
                case Models.LotR.Sphere.Lore:
                    return "rgba(0, 128, 0, .1)";
                case Models.LotR.Sphere.Baggins:
                    return "rgba(255, 255, 0, .1)";
                case Models.LotR.Sphere.Fellowship:
                    return "rgba(255, 210, 0, .1)";
                case Models.LotR.Sphere.Neutral:
                    return "#e4e4e4";
                default:
                    if (card.IsEncounterCard())
                    {
                        return "rgba(0, 0, 0, .1)";
                    }
                    else if (card.IsQuestCard())
                    {
                        return "#d3d3d3";
                    }
                    return "White";
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public abstract class Card : ICard
    {
        protected Card()
        {
            AlternateSlug = string.Empty;

            Text = string.Empty;
            FlavorText = string.Empty;

            Artist = Artist.None;
        }

        public const byte VALUE_ASTERISK = 253;
        public const byte VALUE_X = 254;
        public const byte VALUE_NA = 255;
        public readonly Language DefaultLang = Language.EN;

        private readonly Dictionary<Language, List<string>> traits = new Dictionary<Language, List<string>>();
        private readonly Dictionary<Language, List<string>> normalizedTraits = new Dictionary<Language, List<string>>();
        private readonly Dictionary<Language, List<string>> keywords = new Dictionary<Language, List<string>>();
        private readonly Dictionary<Language, List<string>> normalizedKeywords = new Dictionary<Language, List<string>>();

        protected INamed NamedProduct { get; set; }

        protected virtual string getSlug()
        {
            var parts = new List<string>();

            parts.Add(GetTitle(DefaultLang).NormalizeCaseSensitiveString());

            if (!string.IsNullOrEmpty(SlugSubtitle)) {
                parts.Add(SlugSubtitle);
            }

            if (!string.IsNullOrEmpty(SlugSuffix)) {
                parts.Add(SlugSuffix);
            }

            parts.Add(NamedProduct.Abbreviation.ToUrlSafeString());

            return string.Join("-", parts);
        }

        protected void addTraits(IEnumerable<string> traits, Language lang = Language.EN)
        {
            foreach (var trait in traits) {
                var norm = trait.NormalizeCaseSensitiveString();
                if (norm != trait) {
                    normalizedTraits.SafeAddForKey(lang, norm);
                }
            }

            this.traits.SafeAddRangeForKey(lang, traits);
        }

        protected void addKeywords(IEnumerable<string> keywords, Language lang = Language.EN)
        {
            foreach (var keyword in keywords) {
                var norm = keyword.NormalizeCaseSensitiveString();
                if (norm != keyword) {
                    normalizedKeywords.SafeAddForKey(lang, norm);
                }
            }

            this.keywords.SafeAddRangeForKey(lang, keywords);
        }

        //TODO: Remove
        public string Id { get; set; }

        private readonly Dictionary<Language, string> titles = new Dictionary<Language,string>();
        
        public string Title { 
            get { return GetTitle(DefaultLang); }
            set { SetTitle(DefaultLang, value); }
        }

        public string GetTitle(Language lang)
        {
            if (titles.ContainsKey(lang))
                return titles[lang];

            return titles.ContainsKey(DefaultLang) ?
                titles[DefaultLang] :
                string.Empty;
        }

        public void SetTitle(Language lang, string title)
        {
            titles[lang] = title;
            if (title.NormalizeCaseSensitiveString() != title) {
                normalizedTitles[lang] = title.NormalizeCaseSensitiveString();
            }
        }

        private readonly Dictionary<Language, string> normalizedTitles = new Dictionary<Language, string>();
        public string NormalizedTitle
        {
            get
            {
                return normalizedTitles.ContainsKey(DefaultLang) ?
                    normalizedTitles[DefaultLang]
                    : Title;
            }
        }

        private readonly Dictionary<Language, string> oppositeTitles = new Dictionary<Language,string>();
        
        public string OppositeTitle { 
            get { return GetOppositeTitle(DefaultLang); }
            set { SetOppositeTitle(DefaultLang, value); }
        }

        public string GetOppositeTitle(Language lang)
        {
            if (oppositeTitles.ContainsKey(lang))
                return oppositeTitles[lang];

            return oppositeTitles.ContainsKey(DefaultLang) ?
                oppositeTitles[DefaultLang] :
                string.Empty;
        }

        public void SetOppositeTitle(Language lang, string title)
        {
            oppositeTitles[lang] = title;
            if (title.NormalizeCaseSensitiveString() != title) {
                normalizedOppositeTitles[lang] = title.NormalizeCaseSensitiveString();
            }
        }

        private readonly Dictionary<Language, string> normalizedOppositeTitles = new Dictionary<Language, string>();
        public string NormalizedOppositeTitle
        {
            get
            {
                return normalizedOppositeTitles.ContainsKey(DefaultLang) ?
                    normalizedOppositeTitles[DefaultLang]
                    : OppositeTitle;
            }
        }

        /*
        private string oppositeTitle;
        public string OppositeTitle
        {
            get { return oppositeTitle; }
            set { 
                oppositeTitle = value;

                if (value.NormalizeString() != value) {
                    NormalizedOppositeTitle = value.NormalizeCaseSensitiveString();
                }
            }
        }

        private string normalizedOppositeTitle;
        public string NormalizedOppositeTitle {
            get { return normalizedOppositeTitle; }
            private set { normalizedOppositeTitle = value; }
        }*/

        public string Slug { get { return getSlug(); } }
        
        //TODO: Change SlugIncludes... properties from LotRCard to this
        public string SlugSubtitle { get; protected set; }
        public string SlugSuffix { get; protected set; }

        public string AlternateSlug { get; set; }

        private readonly Dictionary<Language, string> texts = new Dictionary<Language, string>();
        public string Text
        {
            get { return GetText(DefaultLang); }
            set { SetText(DefaultLang, value); }
        }

        public void SetText(Language lang, string text)
        {
            texts[lang] = text;
        }

        public string GetText(Language lang)
        {
            if (texts.ContainsKey(lang))
                return texts[lang];

            return texts.ContainsKey(DefaultLang) ?
                texts[DefaultLang]
                : string.Empty;
        }

        public string FlavorText { get; set; }
        
        private readonly Dictionary<Language, string> oppositeTexts = new Dictionary<Language, string>();
        public string OppositeText
        { 
            get { return GetOppositeText(DefaultLang); }
            set { SetOppositeText(DefaultLang, value); }
        }

        public void SetOppositeText(Language lang, string text)
        {
            oppositeTexts[lang] = text;
        }

        public string GetOppositeText(Language lang)
        {
            if (oppositeTexts.ContainsKey(lang))
                return oppositeTexts[lang];

            return oppositeTexts.ContainsKey(DefaultLang) ?
                oppositeTexts[DefaultLang]
                : string.Empty;
        }

        public string OppositeFlavorText { get; set; }

        public bool IsUnique { get; set; }
        public byte VictoryPoints { get; set; }

        public ushort CardNumber { get; set; }
        public byte Quantity { get; set; }
        public Artist Artist { get; set; }
        public Artist SecondArtist { get; set; }
        public Artist BackArtist { get; set; }
        
        public ushort Year { get; set; }
        public CardStatus Status { get; set; }

        public IEnumerable<string> Traits
        {
            get { return TraitsByLang(DefaultLang); }

            //TODO: Remove this
            set {
                traits.Clear();
                addTraits(value);
            }
        }

        public IEnumerable<string> TraitsByLang(Language lang)
        {
            return traits.ContainsKey(lang) ?
                traits[lang]
                : Enumerable.Empty<string>();
        }

        public IEnumerable<string> NormalizedTraits
        {
            get { return NormalizedTraitsByLang(DefaultLang); }
        }

        public IEnumerable<string> NormalizedTraitsByLang(Language lang)
        {
            return traits.ContainsKey(lang) ?
                traits[lang]
                : Enumerable.Empty<string>();
        }

        public IEnumerable<string> Keywords
        {
            get { return KeywordsByLang(DefaultLang); }
            
            //TODO: Remove this
            set {
                keywords.Clear();
                addKeywords(value);
            }
        }

        public IEnumerable<string> KeywordsByLang(Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLang;

            return keywords.ContainsKey(useLang) ?
                keywords[useLang]
                : Enumerable.Empty<string>();
        }

        public IEnumerable<string> NormalizedKeywords
        {
            get { return NormalizedKeywordsByLang(DefaultLang); }
        }

        public IEnumerable<string> NormalizedKeywordsByLang(Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLang;

            return normalizedKeywords.ContainsKey(useLang) ?
                normalizedKeywords[useLang]
                : Enumerable.Empty<string>();
        }

        public virtual string CardSetName { get { return string.Empty; } }
        public virtual bool IsCampaign { get { return false; } }
        public virtual bool IsQuest { get { return false; } }
        public virtual bool IsSetup { get { return false; } }
        public virtual uint StageNumber { get { return 0; } set {} }
        public virtual char StageLetter { get { return '\0'; } protected set {} }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public abstract class Card
    {
        protected Card()
        {
            AlternateSlug = string.Empty;

            Text = string.Empty;
            FlavorText = string.Empty;

            Artist = Artist.None;
        }

        public const byte VALUE_X = 254;
        public const byte VALUE_NA = 255;

        private readonly List<string> traits = new List<string>();
        private readonly List<string> normalizedTraits = new List<string>();
        private readonly List<string> keywords = new List<string>();
        private readonly List<string> normalizedKeywords = new List<string>();

        protected INamed NamedProduct { get; set; }

        protected virtual string getSlug()
        {
            var parts = new List<string>();

            parts.Add(Title.NormalizeCaseSensitiveString());

            if (!string.IsNullOrEmpty(SlugSubtitle)) {
                parts.Add(SlugSubtitle);
            }

            if (!string.IsNullOrEmpty(SlugSuffix)) {
                parts.Add(SlugSuffix);
            }

            parts.Add(NamedProduct.Abbreviation.ToUrlSafeString());

            return string.Join("-", parts);
        }

        protected void addTraits(IEnumerable<string> traits)
        {
            foreach (var trait in traits) {
                var norm = trait.NormalizeCaseSensitiveString();
                if (norm != trait) {
                    normalizedTraits.Add(norm);
                }
            }

            this.traits.AddRange(traits);
        }

        protected void addKeywords(IEnumerable<string> keywords)
        {
            foreach (var keyword in keywords) {
                var norm = keyword.NormalizeCaseSensitiveString();
                if (norm != keyword) {
                    normalizedKeywords.Add(norm);
                }
            }

            this.keywords.AddRange(keywords);
        }

        //TODO: Remove
        public string Id { get; set; }

        private string title;
        public string Title { 
            get { return title; }
            set {
                title = value;
                if (value.NormalizeCaseSensitiveString() != value) {
                    NormalizedTitle = value.NormalizeCaseSensitiveString();
                }
            }
        }
        public string NormalizedTitle { get; private set; }

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
        }

        public string Slug { get { return getSlug(); } }
        
        //TODO: Change SlugIncludes... properties from LotRCard to this
        public string SlugSubtitle { get; protected set; }
        public string SlugSuffix { get; protected set; }

        public string AlternateSlug { get; set; }

        public string Text { get; set; }
        public string FlavorText { get; set; }
        
        public string OppositeText { get; set; }
        public string OppositeFlavorText { get; set; }

        public bool IsUnique { get; set; }
        public byte VictoryPoints { get; set; }

        public byte CardNumber { get; set; }
        public byte Quantity { get; set; }
        public Artist Artist { get; set; }
        public Artist SecondArtist { get; set; }
        public Artist BackArtist { get; set; }
        
        public ushort Year { get; set; }

        public IEnumerable<string> Traits
        {
            get { return traits; }

            //TODO: Remove this
            set {
                traits.Clear();
                addTraits(value);
            }
        }

        public IEnumerable<string> NormalizedTraits
        {
            get { return normalizedTraits; }
        }

        public IEnumerable<string> Keywords
        {
            get { return keywords; }
            
            //TODO: Remove this
            set {
                keywords.Clear();
                addKeywords(value);
            }
        }

        public IEnumerable<string> NormalizedKeywords
        {
            get { return normalizedKeywords; }
        }
    }
}
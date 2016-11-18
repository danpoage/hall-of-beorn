using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Card
    {
        private readonly List<string> traits = new List<string>();
        private readonly List<string> keywords = new List<string>();

        protected void addTraits(IEnumerable<string> traits)
        {
            this.traits.AddRange(traits);
        }

        protected void addKeywords(IEnumerable<string> keywords)
        {
            this.keywords.AddRange(keywords);
        }

        public string Text { get; set; }
        public bool IsUnique { get; set; }
        public byte VictoryPoints { get; set; }
        public Artist Artist { get; set; }
        public Artist BackArtist { get; set; }

        public IEnumerable<string> Traits
        {
            get { return traits; }

            //TODO: Remove this
            set {
                traits.Clear();
                addTraits(value);
            }
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
    }
}
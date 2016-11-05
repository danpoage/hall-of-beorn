using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Deck
    {
        protected Deck(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public Deck()
        {
        }

        private readonly List<string> cards = new List<string>();
        private readonly List<string> octgnCards = new List<string>();

        public List<string> Cards
        {
            get { return cards; }
        }

        public List<string> OctgnCards
        {
            get { return octgnCards; }
        }

        public string DeckList { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
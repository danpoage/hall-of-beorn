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

        public string DeckList { get; protected set; }
        public string Name { get; protected set; }
        public string Url { get; protected set; }
    }
}
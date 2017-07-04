using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class Character
    {
        private const string BOOK_HOBBIT = "The Hobbit";
        private const string BOOK_FELLOWSHIP = "The Fellowship of the Ring";
        private const string BOOK_TOWERS = "The Two Towers";
        private const string BOOK_RETURN = "The Return of the King";
        private const string BOOK_SILMARILLION = "The Silmarillion";

        protected Character(string name, string fullName, string race)
        {
            this.Name = name;
            this.NormalizedName = name.NormalizeCaseSensitiveString();
            this.FullName = fullName;
            this.Race = race;
        }

        private readonly List<CardTag> family = new List<CardTag>();
        private readonly List<string> aliases = new List<string>();
        private readonly List<string> books = new List<string>();
        private readonly List<string> cards = new List<string>();

        protected void Alias(string alias)
        {
            this.aliases.Add(alias);
        }

        protected void addFamily(string name, string slug)
        {
            var url = !string.IsNullOrEmpty(slug) ? string.Format("/LotR/Details/{0}", slug) : string.Empty;

            this.family.Add(new CardTag { Text = name, Url = url });
        }

        protected void TheHobbit()
        {
            this.books.Add(BOOK_HOBBIT);
        }

        protected void TheFellowshipOfTheRing()
        {
            this.books.Add(BOOK_FELLOWSHIP);
        }

        protected void TheTwoTowers()
        {
            this.books.Add(BOOK_TOWERS);
        }

        protected void TheReturnOfTheKing()
        {
            this.books.Add(BOOK_RETURN);
        }

        protected void Card(string card)
        {
            this.cards.Add(card);
        }

        public string Name { get; private set; }
        public string NormalizedName { get; private set; }

        public string FullName { get; private set; }

        public string Race { get; protected set; }
        
        public IEnumerable<CardTag> Family { get { return family; } }

        public string Bio { get; protected set; }

        public IEnumerable<string> Aliases()
        {
            return aliases;
        }

        public IEnumerable<string> Books()
        {
            return books;
        }

        public IEnumerable<string> Cards()
        {
            return cards;
        }
    }
}
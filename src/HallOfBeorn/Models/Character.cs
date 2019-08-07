using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn;

namespace HallOfBeorn.Models
{
    public enum CharacterType: byte
    {
        Individual,
        Thing,
        Group,
        Place
    }

    public class Character
    {
        private const string BOOK_HOBBIT = "The Hobbit";
        private const string BOOK_FELLOWSHIP = "The Fellowship of the Ring";
        private const string BOOK_TOWERS = "The Two Towers";
        private const string BOOK_RETURN = "The Return of the King";
        private const string BOOK_SILMARILLION = "The Silmarillion";
        private const string BOOK_UNFINISHED = "Unfinished Tales";
        private const string BOOK_HURIN = "Children of Húrin";

        protected Character(string name, string fullName, string race)
        {
            this.Type = CharacterType.Individual;
            this.Name = name;
            this.Slug = name.Slugify();
            this.FullName = fullName;
            this.Race = race;
        }

        public CharacterType Type { get; protected set; }

        protected readonly List<ILink> leaders = new List<ILink>();
        protected readonly List<ILink> members = new List<ILink>();

        private readonly List<ILink> family = new List<ILink>();
        private readonly List<ILink> friends = new List<ILink>();
        private readonly List<ILink> items = new List<ILink>();
        private readonly List<ILink> aliases = new List<ILink>();
        private readonly List<ILink> places = new List<ILink>();
        private readonly List<ILink> groups = new List<ILink>();
        private readonly List<ILink> articles = new List<ILink>();
        private readonly List<string> books = new List<string>();

        private readonly List<string> lotrCards = new List<string>();
        private readonly List<string> digitalCards = new List<string>();
        
        protected void Alias(string alias)
        {
            this.Alias(alias, string.Empty);
        }

        protected void Alias(string alias, string slug)
        {
            var type = LinkType.None;
            var url = string.Empty;

            if (!string.IsNullOrEmpty(slug)) {
                type = LinkType.Hall_of_Beorn_LotR_Detail;
                url = string.Format("/LotR/Details/{0}", slug);
            }

            aliases.Add(new Link(type, url, alias));
        }

        protected void AliasLink(string alias, string url)
        {
            aliases.Add(new Link(LinkType.None, url, alias));
        }

        protected void addFamily(string name)
        {
            addCharacterLink(this.family, name, string.Empty);
        }

        protected void addFamily(string name, string slug)
        {
            addCharacterLink(this.family, name, slug);
        }

        protected void addFriend(string name)
        {
            addCharacterLink(this.friends, name, string.Empty);
        }

        protected void addFriend(string name, string slug)
        {
            addCharacterLink(this.friends, name, slug);
        }

        protected void addFriendCard(string name, string slug)
        {
            addDetailLink(this.friends, name, slug);
        }

        protected void addPlace(string name)
        {
            addCharacterLink(this.places, name, string.Empty);
        }

        protected void addPlace(string name, string slug)
        {
            addCharacterLink(this.places, name, slug);
        }

        protected void addItem(string name)
        {
            addDetailLink(this.items, name, string.Empty);
        }

        protected void addItem(string name, string slug)
        {
            addDetailLink(this.items, name, slug);
        }

        protected void addItemThing(string name)
        {
            addCharacterLink(this.items, name, name.Slugify());
        }

        protected void addGroup(string name)
        {
            addCharacterLink(this.groups, name, string.Empty);
        }

        protected void addGroup(string name, string slug)
        {
            addCharacterLink(this.groups, name, slug);
        }

        protected void addArticle(string url, string title)
        {
            articles.Add(new Link(LinkType.None, url, title));
        }

        protected void addCharacterLink(List<ILink> links, string title, string slug)
        {
            var type = LinkType.None;
            var url = string.Empty;

            if (!string.IsNullOrEmpty(slug)) {
                type = LinkType.Hall_of_Beorn_Character;
                url = getCharacterUrl(slug);
            }

            links.Add(new Link(type, url, title));
        }

        protected void addDetailLink(List<ILink> links, string title, string slug)
        {
            var type = LinkType.None;
            var url = string.Empty;

            if (!string.IsNullOrEmpty(slug)) {
                type = LinkType.Hall_of_Beorn_LotR_Detail;
                url = getDetailUrl(slug);
            }

            links.Add(new Link(type, url, title));
        }

        protected string getCharacterUrl(string slug)
        {
            return string.Format("/LotR/Characters/{0}", slug);
        }

        protected string getDetailUrl(string slug)
        {
            return string.Format("/LotR/Details/{0}", slug);
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

        protected void TheSilmarillion()
        {
            this.books.Add(BOOK_SILMARILLION);
        }

        protected void UnfinishedTales()
        {
            this.books.Add(BOOK_UNFINISHED);
        }

        protected void ChildrenOfHurin()
        {
            this.books.Add(BOOK_HURIN);
        }

        protected void LotRCard(string card)
        {
            lotrCards.Add(card);
        }

        protected void DigitalCard(string card)
        {
            digitalCards.Add(card);
        }

        public string Name { get; private set; }
        public string Slug { get; private set; }

        public string FullName { get; private set; }

        public string Race { get; protected set; }
        
        public IEnumerable<ILink> Places { get { return places; } }

        public IEnumerable<ILink> Leaders { get { return leaders; } }
        public IEnumerable<ILink> Members { get { return members; } }

        public IEnumerable<ILink> Family { get { return family; } }
        public IEnumerable<ILink> Friends { get { return friends; } }
        
        public IEnumerable<ILink> RelatedCharacters()
        {
            foreach (var leader in Leaders)
                yield return leader;

            foreach (var member in Members)
                yield return member;

            foreach (var familyMember in Family)
                yield return familyMember;

            foreach (var friend in Friends)
                yield return friend;
        }
        
        public IEnumerable<ILink> Groups { get { return groups; } }
        public IEnumerable<ILink> Items { get { return items; } }

        public IEnumerable<ILink> Articles { get { return articles; } }

        public string Bio { get; protected set; }
        public string BioSourceUrl { get; protected set; }
        public Artist ImageArtist { get; protected set; }

        public IEnumerable<ILink> Aliases { get { return aliases; } }
        public IEnumerable<string> Books { get { return books; } }

        public IEnumerable<string> LotRCards { get { return lotrCards; } }
        public IEnumerable<string> DigitalCards { get { return digitalCards; } }

        public static Character Empty()
        {
            var empty = new Character("Characters", "Characters", string.Empty)
            {
                ImageArtist = Artist.None
            };

            return empty;
        }

        public string Url
        {
            get { return string.Format("/LotR/Characters/{0}", Slug); }
        }
    }
}
using System;
using System.Collections.Generic;

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
        public bool DisableAutoLinks { get; protected set; }

        protected readonly Dictionary<string, List<ILink>> leaders = new Dictionary<string, List<ILink>>();
        protected readonly Dictionary<string, List<ILink>> members = new Dictionary<string, List<ILink>>();

        private readonly Dictionary<string, List<ILink>> family = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> friends = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> items = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> aliases = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> places = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> groups = new Dictionary<string, List<ILink>>();
        private readonly Dictionary<string, List<ILink>> articles = new Dictionary<string, List<ILink>>();
        private readonly List<string> books = new List<string>();

        private static IEnumerable<ILink> UnrollMap(Dictionary<string, List<ILink>> map)
        {
            foreach (var key in map.Keys)
            {
                foreach (var item in map[key])
                    yield return item;
            }
        }

        private static void AddToMap(Dictionary<string, List<ILink>> map, string key, ILink link)
        {
            var suffixes = new List<string> { "(Father)", "(Mother)", "(Son)", "(Daughter)", "(Spouse)" };

            var norm = key;
            foreach (var suffix in suffixes)
            {
                norm = norm.Replace(suffix, string.Empty);
            }
            norm = norm.Trim();

            if (!map.ContainsKey(norm))
            {
                map.Add(norm, new List<ILink>());
            }

            map[norm].Add(link);
        }

        private readonly HashSet<string> lotrCards = new HashSet<string>();

        private readonly HashSet<string> traits = new HashSet<string>();

        protected void Trait(string trait)
        {
            traits.Add(trait);
        }

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

            AddToMap(aliases, alias, new Link(type, url, alias));
        }

        protected void AliasLink(string alias, string url)
        {
            AddToMap(aliases, alias, new Link(LinkType.None, url, alias));
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
            AddToMap(articles, title, new Link(LinkType.None, url, title));
        }

        protected void addCharacterLink(Dictionary<string, List<ILink>> links, string title, string slug)
        {
            var type = LinkType.None;
            var url = string.Empty;

            if (!string.IsNullOrEmpty(slug)) {
                type = LinkType.Hall_of_Beorn_Character;
                url = getCharacterUrl(slug);
            }

            AddToMap(links, title, new Link(type, url, title));
        }

        protected void addDetailLink(Dictionary<string, List<ILink>> links, string title, string slug)
        {
            var type = LinkType.None;
            var url = string.Empty;

            if (!string.IsNullOrEmpty(slug)) {
                type = LinkType.Hall_of_Beorn_LotR_Detail;
                url = getDetailUrl(slug);
            }

            AddToMap(links, title, new Link(type, url, title));
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

        public string Name { get; private set; }
        public string Slug { get; private set; }

        public string FullName { get; private set; }

        public string Race { get; protected set; }
        
        public IEnumerable<ILink> Places { get { return UnrollMap(places); } }

        public IEnumerable<ILink> Leaders { get { return UnrollMap(leaders); } }
        public IEnumerable<ILink> Members { get { return UnrollMap(members); } }

        public IEnumerable<ILink> Family { get { return UnrollMap(family); } }
        public IEnumerable<ILink> Friends { get { return UnrollMap(friends); } }
        
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
        
        public bool IsRelatedTo(string name)
        {
            return leaders.ContainsKey(name) ||
                members.ContainsKey(name) ||
                family.ContainsKey(name) ||
                friends.ContainsKey(name);
        }

        public IEnumerable<ILink> Groups { get { return UnrollMap(groups); } }
        public IEnumerable<ILink> Items { get { return UnrollMap(items); } }

        public IEnumerable<ILink> Articles { get { return UnrollMap(articles); } }

        public string Bio { get; protected set; }
        public string BioSourceUrl { get; protected set; }
        public Artist ImageArtist { get; protected set; }

        public IEnumerable<ILink> Aliases { get { return UnrollMap(aliases); } }
        public IEnumerable<string> Books { get { return books; } }

        public IEnumerable<string> LotRCards { get { return lotrCards; } }
        public bool IncludesCard(string slug)
        {
            return lotrCards.Contains(slug);
        }

        public IEnumerable<string> Traits()
        {
            return traits;
        }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Creator
        : ICreator
    {
        protected Creator(string name, string siteUrl, string feedUrl, LinkType defaultLinkType)
        {
            Name = name;
            SiteUrl = siteUrl;
            FeedUrl = feedUrl;
            DefaultLinkType = defaultLinkType;
        }

        private readonly List<ILink> allLinks = new List<ILink>();
        private readonly Dictionary<string, ILink> linksByUrl = new Dictionary<string, ILink>();

        private readonly Dictionary<string, List<string>> urlsByCardSlug 
            = new Dictionary<string, List<string>>();

        protected void AddLink(ILink link)
        {
            allLinks.Add(link);

            if (!string.IsNullOrWhiteSpace(link.Url))
            {
                linksByUrl[link.Url] = link;
            }
        }

        private const string simpleTitleFormat = "{0} [{1}]";

        protected void AddLink(string title, string url, string releaseDate)
        {
            var date = DateTime.Parse(releaseDate);
            var fullTitle = string.Format(simpleTitleFormat, title, date.ToString("MMM dd, yyyy"));
            AddLink(new Link(DefaultLinkType, url, fullTitle));
        }

        protected void AddYear(int year)
        {
            AddLink(new Link(LinkType.None, string.Empty, year.ToString()));
        }

        protected void AssociateCardToUrl(string cardSlug, string url)
        {
            if (!urlsByCardSlug.ContainsKey(cardSlug))
            {
                urlsByCardSlug[cardSlug] = new List<string>();
            }

            urlsByCardSlug[cardSlug].Add(url);
        }

        public string Name
        {
            get;
            private set;
        }

        public string SiteUrl
        {
            get;
            private set;
        }

        public string FeedUrl
        {
            get;
            private set;
        }

        public LinkType DefaultLinkType
        {
            get; private set;
        }

        public IEnumerable<ILink> Links()
        {
            return allLinks;
        }

        public IEnumerable<ILink> GetLinks(string cardSlug)
        {
            return urlsByCardSlug.ContainsKey(cardSlug)
                ? urlsByCardSlug[cardSlug]
                    .Where(url => linksByUrl.ContainsKey(url))
                    .Select(url => linksByUrl[url])
                    .Distinct()
                : new List<ILink>();
        }
    }
}

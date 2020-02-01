using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Creator
        : ICreator
    {
        protected Creator(string name, string siteUrl, string feedUrl)
        {
            Name = name;
            SiteUrl = siteUrl;
            FeedUrl = feedUrl;
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

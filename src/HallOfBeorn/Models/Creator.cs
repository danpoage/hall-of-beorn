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

        private readonly Dictionary<string, ILink> linksByUrl = new Dictionary<string, ILink>();

        private readonly Dictionary<string, List<string>> urlsByCardSlug 
            = new Dictionary<string, List<string>>();

        protected void AddLink(ILink link)
        {
            linksByUrl[link.Url] = link;
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
            return linksByUrl.Values;
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

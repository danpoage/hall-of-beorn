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

        private readonly List<ILink> links = new List<ILink>();

        protected void AddLink(ILink link)
        {
            links.Add(link);
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
            return links;
        }
    }
}
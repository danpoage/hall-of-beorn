using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ContentSource
        : IContentSource
    {
        protected ContentSource(string name, string url)
        {
            Name = name;
            Url = url;
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

        public string Url
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
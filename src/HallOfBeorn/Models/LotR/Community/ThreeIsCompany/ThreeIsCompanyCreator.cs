using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.ThreeIsCompany
{
    public class ThreeIsCompanyCreator
        : Creator
    {
        public ThreeIsCompanyCreator()
            : base("Three is Company",
            "https://www.podbean.com/podcast-detail/wzaap-85063/Three-is-Company-Podcast",
            "https://feeds.buzzsprout.com/232796.rss")
        {
            AddYear(2020);
        }

        private void AddLink(string title, string url, string pubDate)
        {
        }
    }
}
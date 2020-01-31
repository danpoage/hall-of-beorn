using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.HallOfBeorn
{
    public class HallOfBeornCreator
        :Creator
    {
        public HallOfBeornCreator()
            : base("Hall of Beorn Blog",
            "https://hallofbeorn.wordpress.com",
            "https://hallofbeorn.wordpress.com/feed")
        {
            AddLink("Long are the Waves on the Last Shore", "https://hallofbeorn.wordpress.com/2020/01/19/long-are-the-waves-on-the-last-shore", "20 Jan 2020");
        }

        private const string titleFormat = "{0} [{1}]";

        private void AddLink(string title, string url, string releaseDate)
        {
            var fullTitle = string.Format(titleFormat, title, releaseDate); //.ToString("MMM dd, yyyy"));
            AddLink(new Link(LinkType.The_Grey_Company, url, fullTitle));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.CardboardOfTheRings
{
    public class CardboardOfTheRingsCreator
        : Creator
    {
        public CardboardOfTheRingsCreator()
            : base("Cardboard of the Rings",
            "https://cardboardoftherings.com",
            "http://cotr.libsyn.com/rss")
        {
            AddLink("0", "Show Me Your Best Pitch Bobby!", "Show me your best pitch Bobby", new DateTime(2011, 4, 28));
            AddLink("0b", "Know Your Cards", "KnowYour Cards", new DateTime(2011, 4, 28));
            AddLink("1", "Don't Ignore Eleanor", "Dont Ignore Elanor", new DateTime(2011, 4, 28));

            AddLink("158", "Ugly Shaggy Hair", new DateTime(2020, 1, 25));
        }

        private const string urlFormat = "http://traffic.libsyn.com/cotr/Episode_{0}_-_{1}.mp3";
        private const string titleFormat = "Episode {0} - {1} [{2}]";
        private const string dateFormat = "MMM dd, yyyy";

        private string GetUrl(string episodeNumber, string title)
        {
            return string.Format(urlFormat, episodeNumber, title.Replace(" ", "_"));
        }

        private void AddLink(string episodeNumber, string title, DateTime releaseDate)
        {
            var url = GetUrl(episodeNumber, title);
            var fullTitle = string.Format(titleFormat, episodeNumber, title, releaseDate.ToString(dateFormat));
            AddLink(new Link(LinkType.Cardboard_of_Rings, url, fullTitle));
        }

        private void AddLink(string episodeNumber, string title, string normalizedTitle, DateTime releaseDate)
        {
            var url = GetUrl(episodeNumber, normalizedTitle);
            var fullTitle = string.Format(titleFormat, episodeNumber, title, releaseDate.ToString(dateFormat));
            AddLink(new Link(LinkType.Cardboard_of_Rings, url, fullTitle));
        }
    }
}
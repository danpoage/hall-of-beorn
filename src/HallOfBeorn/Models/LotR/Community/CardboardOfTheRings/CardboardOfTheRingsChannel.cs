using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.CardboardOfTheRings
{
    public class CardboardOfTheRingsChannel
        : Creator
    {
        public CardboardOfTheRingsChannel()
            : base("Cardboard of the Rings Channel",
            "https://www.youtube.com/channel/UCVKwveV9va6wBu1AkRIHB9w",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCVKwveV9va6wBu1AkRIHB9w")
        {
            AddYear(2020);
            AddLink("The REAL Road to Nightmare", "https://www.youtube.com/watch?v=5SdmbtfT2C4", "2020-01-30T23:56:50+00:00");
            AddLink("Road to regular ol' Isengard. Oops", "https://www.youtube.com/watch?v=ITutiEa2uRU", "2020-01-27T12:45:58+00:00");
            AddLink("OCTGN 2-Handed and Tips & Tricks", "https://www.youtube.com/watch?v=kpLg2PMs-MY", "2020-01-09T18:12:58+00:00");
            AddLink("Balrog vs. Apples", "https://www.youtube.com/watch?v=2FADGeKaz0s", "2020-01-08T21:54:59+00:00");
            AddLink("Helm's Nightmare", "https://www.youtube.com/watch?v=Ni-82ogn8zM", "2020-01-06T19:09:43+00:00");

            AddYear(2019);
            AddLink("Quest if you Dare", "https://www.youtube.com/watch?v=x-Rvs5rOZJw", "2019-12-21T20:13:24+00:00");
            AddLink("Taking a Burglar's Turn", "https://www.youtube.com/watch?v=GklQ3uQ9sTk", "2019-12-14T13:40:53+00:00");
            AddLink("Hans Frolo: Showcasing the Grey Wanderer contract", "https://www.youtube.com/watch?v=rXkUluHcEg0", "2019-12-08T19:03:45+00:00");
            AddLink("Taking the Nightmare to Isengard", "https://www.youtube.com/watch?v=eHGE59FeoIQ", "2019-11-19T15:38:39+00:00");
            AddLink("Chad and Joe's Nasty Encounter Deck", "https://www.youtube.com/watch?v=Nx5prUfQe6o", "2019-11-05T01:34:58+00:00");
            AddLink("Breaking Nightmares", "https://www.youtube.com/watch?v=w9aPyZR90FU", "2019-09-29T13:14:19+00:00");
            AddLink("Nightmarish Journey in the Dark", "https://www.youtube.com/watch?v=y3twVfiYmWo", "2019-09-13T13:35:10+00:00");
            AddLink("Ring goes South Nightmare mode", "https://www.youtube.com/watch?v=Qr8QQ70y7Zs", "2019-09-03T14:07:08+00:00");
            AddLink("Flightmare to the Ford", "https://www.youtube.com/watch?v=gnBst84pN84", "2019-08-27T12:29:11+00:00");
            AddLink("Epic 2019 Swag reveal", "https://www.youtube.com/watch?v=WHLSQn9fNm8", "2019-08-07T12:33:35+00:00");
        }

        private const string titleFormat = "{0} [{1}]";

        private void AddLink(string title, string url, string releaseDate)
        {
            var date = DateTime.Parse(releaseDate);
            var fullTitle = string.Format(titleFormat, title, date.ToString("MMM dd, yyyy"));
            AddLink(new Link(LinkType.Cardboard_of_the_Rings, url, fullTitle));
        }
    }
}
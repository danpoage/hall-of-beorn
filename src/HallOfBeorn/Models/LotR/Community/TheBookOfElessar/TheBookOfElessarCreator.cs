using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheBookOfElessar
{
    public class TheBookOfElessarCreator
        : Creator
    {
        public TheBookOfElessarCreator()
            : base("The Book of Elessar",
            "https://www.youtube.com/channel/UCUgU6nIpwNlADThJKEDV3Pg",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCUgU6nIpwNlADThJKEDV3Pg")
        {
            AddYear(2020);
            AddLink("Book of Elessar, Ep. 15: Shadow and Flame", "https://www.youtube.com/watch?v=H_GKqfPV3Uo", "2020-01-28T01:31:59+00:00");
            AddLink("Book of Elessar, Ep. 14 - Foundations of Stone", "https://www.youtube.com/watch?v=EGergQj7FUM", "2020-01-14T21:19:05+00:00");
            AddLink("Book of Elessar, Ep. 13 - The Long Dark", "https://www.youtube.com/watch?v=fnSPLHYm67A", "2020-01-01T15:01:50+00:00");

            AddYear(2019);
            AddLink("Book of Elessar, Ep. 12: The Watcher in the Water", "https://www.youtube.com/watch?v=4y1vHnvrug8", "2019-12-09T17:40:00+00:00");
            AddLink("Book of Elessar, Ep. 11 - The Road to Rivendell", "https://www.youtube.com/watch?v=Z892GSMaxI4", "2019-12-02T17:30:02+00:00");
            AddLink("Book of Elessar, Ep. 10 - The Redhorn Gate", "https://www.youtube.com/watch?v=4BqnqN1bnio", "2019-11-25T17:01:13+00:00");
            AddLink("Book of Elessar, Ep. 9: Flight from Moria", "https://www.youtube.com/watch?v=ix1BjJlca4I", "2019-11-19T02:00:45+00:00");
            AddLink("Book of Elessar, Ep. 8: The Seventh Level", "https://www.youtube.com/watch?v=YTJJwKTeJt0", "2019-11-11T18:18:36+00:00");
            AddLink("Book of Elessar, Ep. 7 - Into the Pit", "https://www.youtube.com/watch?v=bslrBrSKzHg", "2019-11-04T18:00:02+00:00");
            AddLink("Book of Elessar, Ep. 6: Return to Mirkwood", "https://www.youtube.com/watch?v=NCCL9OrUJ3c", "2019-10-18T17:00:06+00:00");
            AddLink("Book of Elessar, Ep. 5: The Dead Marshes", "https://www.youtube.com/watch?v=MY6OT6OfSzU", "2019-10-11T23:39:21+00:00");
            AddLink("Book of Elessar, Ep. 4: The Hills of Emyn Muil", "https://www.youtube.com/watch?v=QBOG-2GnJNw", "2019-10-04T22:00:34+00:00");
            AddLink("Book of Elessar, Ep. 3: A Journey to Rhosgobel", "https://www.youtube.com/watch?v=YOab58znthI", "2019-09-27T23:08:20+00:00");
            AddLink("Book of Elessar, Ep 2: Conflict at the Carrock", "https://www.youtube.com/watch?v=GDlieGGihL8", "2019-09-21T00:01:53+00:00");
            AddLink("Book of Elessar, Ep.1: The Hunt for Gollum", "https://www.youtube.com/watch?v=mfjEwukJzAk", "2019-09-09T17:19:02+00:00");
        }

        private const string titleFormat = "{0} [{1}]";
        
        private void AddLink(string title, string url, string pubDate)
        {
            var releaseDate = DateTime.Parse(pubDate);
            var fullTitle = string.Format(titleFormat, title, releaseDate.ToString("MMM dd, yyyy"));
            AddLink(new Link(LinkType.The_Book_of_Elessar, url, fullTitle));
        }
    }
}
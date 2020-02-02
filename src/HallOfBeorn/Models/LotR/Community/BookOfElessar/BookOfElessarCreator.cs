using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.BookOfElessar
{
    public class BookOfElessarCreator
        : Creator
    {
        public BookOfElessarCreator()
            : base("Book of Elessar",
            "https://www.youtube.com/channel/UCUgU6nIpwNlADThJKEDV3Pg",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCUgU6nIpwNlADThJKEDV3Pg")
        {
            AddYear(2019);
        }
    }
}
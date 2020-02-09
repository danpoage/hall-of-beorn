using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheGreyCompany
{
    public class TheGreyCompanyChannel
        : Creator
    {
        public TheGreyCompanyChannel()
            : base("The Grey Company Channel",
            "https://www.youtube.com/channel/UCM8hzRbiHw4e2JJsTQPzLYw",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCM8hzRbiHw4e2JJsTQPzLYw",
            LinkType.The_Grey_Company)
        {
            AddYear(2018);
            AddLink("\"First Look\" at The Lord of the Rings Living Card Game!", "https://www.youtube.com/watch?v=Olt5OqQUPoI", "2018-08-29T01:26:56+00:00");

            AddYear(2016);
            AddLink("Treachery of Rhudaur", "https://www.youtube.com/watch?v=OyuHE-Jvn38", "2016-01-18T17:27:12+00:00");

            AddYear(2015);
            AddLink("Intruders in Chetwood", "https://www.youtube.com/watch?v=oy1NR59jF9g", "2015-09-17T03:27:20+00:00");
            AddLink("Beorn's Path 16 - Flight from Moria", "https://www.youtube.com/watch?v=kG4CjacD1XE", "2015-09-12T23:28:01+00:00");
            AddLink("Beorn's Path 15 - The Seventh Level", "https://www.youtube.com/watch?v=oDfVi8SfOOY", "2015-09-07T22:48:56+00:00");
            AddLink("Fog on the Barrow-downs [Campaign Mode]", "https://www.youtube.com/watch?v=GmK8gixJLGE", "2015-07-27T01:26:04+00:00");
            AddLink("The Weather Hils", "https://www.youtube.com/watch?v=b-cCXvTTtcU", "2015-04-29T03:10:31+00:00");
            AddLink("Intruders in Chetwood", "https://www.youtube.com/watch?v=zWUH7-lySIY", "2015-04-29T01:56:24+00:00");
            AddLink("Deadmen's Dike", "https://www.youtube.com/watch?v=Dhr_KfxWrQk", "2015-04-29T01:12:44+00:00");
            AddLink("The Old Forest", "https://www.youtube.com/watch?v=_uUyMjiLA4U", "2015-01-24T00:30:36+00:00");

            AddYear(2014);
            AddLink("The Woodland Realms Unite Again!", "https://www.youtube.com/watch?v=Wx14NHkrHVo", "2014-12-22T13:55:29+00:00");
            AddLink("The Woodland Realms Unite!", "https://www.youtube.com/watch?v=SEIDD7nAl1s", "2014-12-20T14:56:10+00:00");
            AddLink("The Battle of Five Armies (Part 1)", "https://www.youtube.com/watch?v=IrevoZyubRE", "2014-12-18T02:18:07+00:00");
            AddLink("The Battle of Five Armies (Part 3)", "https://www.youtube.com/watch?v=p0F7gtyVnmQ", "2014-12-17T12:08:41+00:00");
            AddLink("The Battle of Five Armies (Part 2)", "https://www.youtube.com/watch?v=NpNiCWxf_Uo", "2014-12-17T11:41:23+00:00");
        }
    }
}
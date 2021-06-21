using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.WanderingTook
{
    public class WanderingTookChannel
        : Creator
    {
        public WanderingTookChannel()
            : base("Wandering Took Channel",
            "https://www.twitch.tv/wanderingtook",
            "https://twitchrss.appspot.com/vod/wanderingtook",
            LinkType.Wandering_Took)
        {
            AddYear(2021);
            AddLink("Epic Helm's Deep", "https://www.twitch.tv/videos/1061389426", "2021-06-19");
            AddLink("The Horse Lord's Ire", "https://www.twitch.tv/videos/1056501640", "2021-06-14");
        }
    }
}
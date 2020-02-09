using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheCardGameCooperative
{
    public class TheCardGameCooperativePodcast
        : Creator
    {
        public TheCardGameCooperativePodcast()
            : base("The Card Game Cooperative Podcast",
            "https://tcgcoop.design.blog/",
            "https://tcgcoop.design.blog/feed",
            LinkType.The_Card_Game_Cooperative)
        {
            AddYear(2020);
            AddLink("Episode 0",
                "https://ia801506.us.archive.org/29/items/cardcooperativepodcast0mixdown/Card%20Cooperative%20Podcast%20%230%20mixdown.mp3",
                "2020-02-06");
        }
    }
}
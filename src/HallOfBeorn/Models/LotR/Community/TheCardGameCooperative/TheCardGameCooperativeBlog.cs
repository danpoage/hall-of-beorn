using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheCardGameCooperative
{
    public class TheCardGameCooperativeBlog
        : Creator
    {
        public TheCardGameCooperativeBlog()
            : base("The Card Game Cooperative",
            "https://tcgcoop.design.blog/",
            "https://tcgcoop.design.blog/feed",
            LinkType.The_Card_Game_Cooperative)
        {
            AddYear(2020);
            AddLink("Episode 0: The Gathering", "https://tcgcoop.design.blog/2020/02/06/episode-0-the-gathering/", "Thu, 06 Feb 2020 19:23:05 +0000");
            AddLink("The Card Game Cooperative", "https://tcgcoop.design.blog/2020/02/05/welcome-to-my-blog/", "Wed, 05 Feb 2020 10:10:40 +0000");
        }
    }
}
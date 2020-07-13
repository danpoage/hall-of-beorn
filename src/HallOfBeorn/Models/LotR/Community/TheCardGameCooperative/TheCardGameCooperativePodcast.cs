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
            AddLink("Episode 6: Fireside Song", "http://ia801505.us.archive.org/21/items/card-coop-6-v-1/Card%20Coop%20%236V1.mp3", "2020-07-06");

            AddLink("Episode 5: Klaws Vengeance", "https://ia801504.us.archive.org/1/items/card-coop-ep-5-v-1/CardCoopEP%235V1.mp3", "2020-05-26");

            AddLink("Surveillance Team Episode 1 - Hulk Hero Pack", "http://ia801507.us.archive.org/9/items/special-1-v-1/Special%231V1.mp3", "2020-05-19");

            AddLink("Episode 4: Abandoned & Alone", "http://ia801407.us.archive.org/26/items/card-coop-4-v-1/Card%20Coop%20%234%20V1.mp3", "2020-05-04");

            AddLink("Episode 3: It likes riddles", "http://ia801504.us.archive.org/31/items/cardcoopep3v1/CardCoop%20Ep3%20V1.mp3", "2020-04-10");

            AddLink("Episode 2: Hard knocks and easy marks", "http://ia801506.us.archive.org/27/items/cardcooperative2v1/Card%20Cooperative%20%232%20-%20V1.mp3", "2020-03-12");

            AddLink("Episode 1: Relic of ages", "http://ia801404.us.archive.org/12/items/cardcooperativeep1version1/Card%20Cooperative%20Ep%231%20%5BVersion%201%5D.mp3", "2020-02-14");

            AddLink("Episode 0",
                "https://ia801506.us.archive.org/29/items/cardcooperativepodcast0mixdown/Card%20Cooperative%20Podcast%20%230%20mixdown.mp3",
                "2020-02-06");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkChannel
        : Creator
    {
        public CardTalkChannel()
            : base("Card Talk Channel",
            "https://www.youtube.com/channel/UCj-QcL_YcA_DQKe7bSe9byA",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCj-QcL_YcA_DQKe7bSe9byA",
            LinkType.Card_Talk)
        {
            AddYear(2020);
            AddLink("Guest Host Chloe Walsh", "https://www.youtube.com/watch?v=SAmEgdIw-0U", "2020-02-07T17:00:08+00:00");
            AddLink("Guest Host Tolkien Road", "https://www.youtube.com/watch?v=-kSqKjSxQmc", "2020-02-05T17:00:00+00:00");
            AddLink("Hero Arwen Umdomiel and any Hero Aragorn", "https://www.youtube.com/watch?v=MuyWpuMII-Q", "2020-02-03T17:00:11+00:00");
            AddLink("Feint", "https://www.youtube.com/watch?v=XTGRkSOQSog", "2020-01-27T17:00:07+00:00");
            AddLink("Theodred", "https://www.youtube.com/watch?v=JfpIBmJ3BHU", "2020-01-20T17:00:04+00:00");
            AddLink("Couples February!", "https://www.youtube.com/watch?v=wZWjLRBBZIs", "2020-01-16T17:00:14+00:00");
            AddLink("SPOILER! Odo Proudfoot", "https://www.youtube.com/watch?v=hDImxEfbaDg", "2020-01-13T17:00:13+00:00");
            AddLink("Minimum Purchase Dunland Trap", "https://www.youtube.com/watch?v=XYH-Pee18vs", "2020-01-09T19:58:35+00:00");
            AddLink("Eleanor", "https://www.youtube.com/watch?v=uvJzEqG253Q", "2020-01-06T17:00:11+00:00");

            AddYear(2019);
            AddLink("Hero Treebeard", "https://www.youtube.com/watch?v=D7dBd3ZIJEY", "2019-12-23T17:00:04+00:00");
            AddLink("Behind Strong Walls", "https://www.youtube.com/watch?v=KGu6ZoQBSqE", "2019-12-16T17:29:14+00:00");
            AddLink("Gildor's Counsel", "https://www.youtube.com/watch?v=wbS7foeQuu4", "2019-12-09T17:57:33+00:00");
            AddLink("Strider's Path", "https://www.youtube.com/watch?v=R3SC_k3At64", "2019-12-02T19:37:59+00:00");
            AddLink("Guest Host Caleb Grace 2", "https://www.youtube.com/watch?v=ri5AtxinPq4", "2019-11-25T17:00:13+00:00");
            AddLink("Explore Secret Ways", "https://www.youtube.com/watch?v=-tuqkZ_ztrQ", "2019-11-18T14:24:46+00:00");
        }
    }
}
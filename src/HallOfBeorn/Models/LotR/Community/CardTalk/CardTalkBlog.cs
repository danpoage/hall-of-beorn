using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkBlog 
        : Creator
    {
        public CardTalkBlog()
            : base("CardTalk Blog", "https://cardtalk2018.com/", "https://cardtalk2018.com/feed/", LinkType.Card_Talk)
        {
            AddYear(2021);
            AddLink("Blade of Gondolin", "https://cardtalk2018.com/2021/09/21/blade-of-gondolin/", "Sep 21 2021")
                .WithLabels("Blade of Gondolin");
            AddLink("Guided by Fate", "https://cardtalk2018.com/2021/09/14/guided-by-fate/", "Sep 14 2021")
                .WithLabels("Guided by Fate");
            AddLink("Spirit Théoden", "https://cardtalk2018.com/2021/09/07/spirit-theoden/", "Sep 7 2021")
                .WithLabels("Théoden", "Theoden");
            AddLink("Fast Hitch", "https://cardtalk2018.com/2021/08/31/fast-hitch/", "Aug 31 2021")
                .WithLabels("Fast Hitch");
            AddLink("Meneldor", "https://cardtalk2018.com/2021/08/24/meneldor/", "Aug 24 2021")
                .WithLabels("Meneldor");
            AddLink("Envoy of Pelargir", "https://cardtalk2018.com/2021/08/17/envoy-of-pelagrir/", "Aug 17 2021")
                .WithLabels("Envoy of Pelargir");
            AddLink("Leadership Éomer", "https://cardtalk2018.com/2021/08/10/leadership-eomer/", "Aug 10 2021")
                .WithLabels("Éomer", "Eomer");
            AddLink("Eagles of the  Misty Mountains", "https://cardtalk2018.com/2021/07/29/eagles-of-the-misty-mountains/", "July 29 2021")
                .WithLabels("Eagles of the Misty Mountains");
            AddLink("Radagast and Radagast's Staff", "https://cardtalk2018.com/2021/07/27/radagast-and-radaghasts-staff/", "July 27 2021")
                .WithLabels("Radagast", "Radagast's Staff");
            AddLink("Stone of Elostirion", "https://cardtalk2018.com/2021/07/20/stone-of-elostirion/", "July 20 2021")
                .WithLabels("Stone of Elostirion");
            AddLink("Followed", "https://cardtalk2018.com/2021/07/13/followed/", "July 13 2021")
                .WithLabels("Followed");
        }
    }
}
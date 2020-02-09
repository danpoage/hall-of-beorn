using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheRoad
{
    public class TheRoadBlog
        : Creator
    {
        public TheRoadBlog()
            : base("The Road", 
            "https://theroadlotr.wordpress.com/",
            "https://theroadlotr.wordpress.com/feed",
            LinkType.The_Road)
        {
            AddYear(2019);
            AddLink("The Battle of the Pelennor Fields: Playthrough", "https://theroadlotr.wordpress.com/2019/11/14/the-battle-of-the-pelennor-fields-playthrough/", "Thu, 14 Nov 2019 16:42:06 +0000");
            AddLink("The Return of the King", "https://theroadlotr.wordpress.com/2019/08/27/the-return-of-the-king/", "Tue, 27 Aug 2019 17:30:36 +0000");
            AddLink("The Siege of Gondor: Playthrough", "https://theroadlotr.wordpress.com/2019/04/23/the-siege-of-gondor-playthrough/", "Tue, 23 Apr 2019 11:58:41 +0000");
            AddLink("The Passing of the Grey Company: Playthrough", "https://theroadlotr.wordpress.com/2019/03/22/the-passing-of-the-grey-company-playthrough/", "Fri, 22 Mar 2019 18:10:49 +0000");
            AddLink("Shelob's Lair: Playthrough", "https://theroadlotr.wordpress.com/2019/01/16/shelobs-lair-playthrough/", "Wed, 16 Jan 2019 17:06:43 +0000");

            AddYear(2018);
            AddLink("The Steward's Counsel (Bonus)", "https://theroadlotr.wordpress.com/2018/12/21/bonus-the-stewards-council/", "Fri, 21 Dec 2018 16:46:44 +0000");
            AddLink("Journey To The Crossroads: Playthrough", "https://theroadlotr.wordpress.com/2018/12/07/journey-to-the-crossroads-playthrough/", "Fri, 07 Dec 2018 16:23:22 +0000");
            AddLink("The Passage Of The Marshes: Playthrough", "https://theroadlotr.wordpress.com/2018/10/12/the-passage-of-the-marshes-playthrough/", "Fri, 12 Oct 2018 10:42:45 +0000");
            AddLink("Peril in Pelargir: Playthrough", "https://theroadlotr.wordpress.com/2018/08/29/peril-in-pelargir-playthrough/", "Wed, 29 Aug 2018 14:00:46 +0000");
            AddLink("The Road To Isengard: Playthrough", "https://theroadlotr.wordpress.com/2018/08/22/the-road-to-isengard-playthrough/", "Wed, 22 Aug 2018 09:32:16 +0000");
            AddLink("Helm's Deep: Playthrough", "https://theroadlotr.wordpress.com/2018/07/25/helms-deep-playthrough/", "Wed, 25 Jul 2018 11:34:59 +0000");
            AddLink("The Uruk-hai: Playthrough", "https://theroadlotr.wordpress.com/2018/07/19/the-uruk-hai-playthrough/", "Thu, 19 Jul 2018 12:48:37 +0000");
            AddLink("The Counsel of Wormtongue (Bonus)", "https://theroadlotr.wordpress.com/2018/07/04/the-counsel-of-wormtongue-bonus/", "Wed, 04 Jul 2018 16:03:30 +0000");
            AddLink("Breaking Of The Fellowship: Playthrough", "https://theroadlotr.wordpress.com/2018/06/25/breaking-of-the-fellowship-playthrough/", "Mon, 25 Jun 2018 16:13:33 +0000");
            AddLink("Journey In The Dark: Playthrough", "https://theroadlotr.wordpress.com/2018/06/15/journey-in-the-dark-playthrough/", "Fri, 15 Jun 2018 13:47:55 +0000");
            AddLink("The Ring Goes South: Playthrough", "https://theroadlotr.wordpress.com/2018/06/11/the-ring-goes-south-playthrough/", "Mon, 11 Jun 2018 12:37:18 +0000");
            AddLink("The Council of Elrond (Bonus)", "https://theroadlotr.wordpress.com/2018/06/08/the-council-of-elrond-bonus/", "Fri, 08 Jun 2018 11:55:18 +0000");
            AddLink("Flight To The Ford: Playthrough", "https://theroadlotr.wordpress.com/2018/05/24/flight-to-the-ford-playthrough/", "Thu, 24 May 2018 15:51:29 +0000");
            AddLink("A Knife In The Dark: Playthrough", "https://theroadlotr.wordpress.com/2018/05/15/a-knife-in-the-dark-playthrough/", "Tue, 15 May 2018 15:34:47 +0000");
            AddLink("Fog On The Barrow Downs: Playthrough", "https://theroadlotr.wordpress.com/2018/05/01/fog-on-the-barrow-downs-playthrough/", "Tue, 01 May 2018 21:17:59 +0000");
            AddLink("The Old Forest: Playthrough", "https://theroadlotr.wordpress.com/2018/04/24/the-old-forest-playthrough/", "Tue, 24 Apr 2018 11:20:54 +0000");
            AddLink("A Shadow Of The Past: Playthrough", "https://theroadlotr.wordpress.com/2018/04/04/a-shadow-of-the-past-playthrough/", "Wed, 04 Apr 2018 12:19:00 +0000");
            AddLink("\"It's a dangerous business, Frodo, going out your door.\"", "https://theroadlotr.wordpress.com/2018/02/28/the-journey-begins/", "Wed, 28 Feb 2018 15:19:32 +0000");
        }
    }
}
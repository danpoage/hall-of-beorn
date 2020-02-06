using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.ThreeIsCompany
{
    public class ThreeIsCompanyPodcast
        : Creator
    {
        public ThreeIsCompanyPodcast()
            : base("Three is Company",
            "https://www.podbean.com/podcast-detail/wzaap-85063/Three-is-Company-Podcast",
            "https://feeds.buzzsprout.com/232796.rss")
        {
            AddYear(2020);
            AddLink("Episode 11 - The City of Ulfast & Multi Faction Decks", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066", 
                "Tue, 21 Jan 2020 22:00:00 -0800");
            AssociateCardToUrl("Lothiriel-TCoU", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066");
            AssociateCardToUrl("Damrod-HoN", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066");
            AssociateCardToUrl("Pelargir-Shipwright-AoO", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066");
            AssociateCardToUrl("Denethor-FotS", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066");
            AssociateCardToUrl("Prince-Imrahil-AJtR", "https://www.buzzsprout.com/232796/2550712-episode-11-the-city-of-ulfast-multi-faction-decks.mp3?blob_id=8443066");

            AddYear(2019);
            AddLink("Episode 10 - Wrath and Ruin & Snogfest 2019", "https://www.buzzsprout.com/232796/2321081-episode-10-wrath-and-ruin-snogfest-2019.mp3?blob_id=7471010", 
                "Fri, 20 Dec 2019 03:00:00 -0800");
            AddLink("Episode 9 - Con of the Rings Extravaganza", "https://www.buzzsprout.com/232796/2107209-episode-9-con-of-the-rings-extravaganza.mp3?blob_id=6552780", 
                "Mon, 18 Nov 2019");
            AddLink("Episode 8 - Shadow in the East & Gondor Archetype", "https://www.buzzsprout.com/232796/1972945-episode-8-shadow-in-the-east-gondor-archetype.mp3?blob_id=6027103", 
                "Fri, 1 Nov 2019");
            AddLink("Episode 7 - Scaling the Game from Solo to 3-4 Player", "https://www.buzzsprout.com/232796/1714819-episode-7-scaling-the-game-from-solo-to-3-4-player.mp3?blob_id=4963648", 
                "Mon, 16 Sep 2019");
            AddLink("Episode 6 - Fate of Wilderland", "https://www.buzzsprout.com/232796/1598014-episode-6-fate-of-wilderland.mp3?blob_id=4493839", 
                "Sun, 25 Aug 2019");
            AddLink("Episode 5 - Mount Gundabad & Undervalued Cards", "https://www.buzzsprout.com/232796/1436110-episode-5-mount-gundabad-undervalued-cards.mp3?blob_id=4493845", 
                "Sat, 20 Jul 2019");
            AddLink("Episode 4 - Ghost of Framsburg & Monosphere Decks", "https://www.buzzsprout.com/232796/1301563-episode-4-ghost-of-framsburg-monosphere-decks.mp3?blob_id=4493851", 
                "Wed, 19 Jun 2019");
            AddLink("Episode 3 - Fire in the Night & The Power of Dale", "https://www.buzzsprout.com/232796/1186418-episode-3-fire-in-the-night-the-power-of-dale.mp3?blob_id=4493854", 
                "Thu, 23 May 2019 18:00:00 -0700");
            AddLink("Episode 2 - Haradrim Cycle Retrospective", "https://www.buzzsprout.com/232796/1035264-episode-2-haradrim-cycle-retrospective.mp3?blob_id=4493857", 
                "Thu, 11 Apr 2019 00:00:00 -0700");
            AddLink("Episode 1 - Roam Across Rhovanion & Trample All Over Rohan", "https://www.buzzsprout.com/232796/948596-episode-1-roam-across-rhovanion-trample-all-over-rohan.mp3?blob_id=4493860", 
                "Thu, 07 Feb 2019 01:00:00 -0800");
        }

        private const string titleFormat = "{0} [{1}]";

        private void AddLink(string title, string url, string releaseDate)
        {
            var date = DateTime.Parse(releaseDate);
            var fullTitle = string.Format(titleFormat, title, date.ToString("MMM dd, yyyy"));
            AddLink(new Link(LinkType.Three_is_Company, url, fullTitle));
        }
    }
}
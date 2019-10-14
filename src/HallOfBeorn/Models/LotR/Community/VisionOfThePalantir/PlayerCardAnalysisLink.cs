using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.VisionOfThePalantir
{
    public class PlayerCardAnalysisLink : Link
    {
        public PlayerCardAnalysisLink(string productPath, string cardLink)
            : base(
                LinkType.Vision_of_the_Palantir, 
                GetUrl(productPath, cardLink), 
                "Player Card Analysis")
        {
        }

        private static string GetUrl(string productPath, string cardLink)
        {
            return string.Format("https://visionofthepalantir.com/{0}/#{1}", productPath, cardLink);
        }

        public static Link TheHuntForGollum(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/03/26/hunt-for-gollum", cardLink);
        }

        public static Link ConflictAtTheCarrock(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/04/24/player-card-review-conflict-at-the-carrock", cardLink);
        }

        public static Link AJourneyToRhosgobel(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/05/27/player-card-review-a-journey-to-rhosgobel", cardLink);
        }

        public static Link TheHillsOfEmynMuil(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/06/28/player-card-review-the-hills-of-emyn-muil", cardLink);
        }

        public static Link TheDeadMarshes(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/07/29/player-card-review-the-dead-marshes", cardLink);
        }

        public static Link ReturnToMirkwood(string cardLink)
        {
            return new PlayerCardAnalysisLink("2019/08/27/player-card-review-return-to-mirkwood", cardLink);
        }
    }
}

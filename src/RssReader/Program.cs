using System;
using System.IO;

namespace RssReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var downloader = new FileDownloader();
            var podcastReader = new PodcastRssReader();
            var ytReader = new YouTubeRssReader();

            var url = string.Empty;
            var path = string.Empty;

            var isSingleFeed = true;
            if (isSingleFeed)
            {
                url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCj-QcL_YcA_DQKe7bSe9byA";
                    //"https://www.youtube.com/feeds/videos.xml?channel_id=UCM8hzRbiHw4e2JJsTQPzLYw";
                    //"https://www.youtube.com/feeds/videos.xml?channel_id=UCVKwveV9va6wBu1AkRIHB9w";
                    //"https://www.youtube.com/feeds/videos.xml?channel_id=UCAF06gMU013g3R2QIH5DaQQ";
                    //"https://hallofbeorn-resources.s3.amazonaws.com/Audio/LotR/The-Grey-Company/The-Grey-Company.rss";
                    //"https://www.youtube.com/feeds/videos.xml?channel_id=UCUgU6nIpwNlADThJKEDV3Pg";
                path = ".\\Card-Talk-Channel.rss";
                    //".\\The-Grey-Company-Channel.rss";
                    //".\\Cardboard-of-the-Rings-Channel.rss";
                    //".\\The-Progression-Series.rss";
                    //".\\The-Grey-Company.rss";
                    //".\\Book-of-Elessar.rss";

                if (!downloader.FileExists(path))
                {
                    if (!downloader.DownloadFile(url, path))
                    {
                        return;
                    }
                }

                if (!ytReader.ProcessRss(path))
                {
                    return;
                }

                return;
            }


            var urlFormat = args.Length > 0
                ? args[0]
                : "https://tcgcoop.design.blog/feed?paged={0}";
                //"https://dorcuarthol.wordpress.com/feed?paged={0}";
                //"https://thewhitetower.wordpress.com/feed?paged={0}";
                //"https://darklingdoor.wordpress.com/feed?paged={0}";
                //"https://warriorsofthewestblog.wordpress.com/feed?paged={0}";
                //"https://theroadlotr.wordpress.com/feed?paged={0}";
                //"https://masteroflore.wordpress.com/feed?paged={0}";
                //"https://visionofthepalantir.com/feed/?paged={0}";
                //"https://talesfromthecards.wordpress.com/feed?paged={0}";
                //"https://hallofbeorn.wordpress.com/feed?paged={0}";

            var pathFormat = args.Length > 1
                ? args[1]
                : "TCGCoop{0}.rss";
                //"Dor-Cuarthol{0}.rss";
                //"The-White-Tower{0}.rss";
                //"Darkling-Door{0}.rss";
                //"Warriors-of-the-West{0}.rss";
                //".\\The-Road{0}.rss";
                //".\\Master-of-Lore{0}.rss";
                //"Vision-of-the-Palantir{0}.rss";
                //".\\Tales-from-the-Cards{0}.rss";
                //".\\Hall-of-Beorn{0}.rss";

            var page = 1;

            while (true)
            {
                url = string.Format(urlFormat, page);
                path = string.Format(pathFormat, page);

                if (!downloader.FileExists(path))
                {
                    if (!downloader.DownloadFile(url, path))
                    {
                        return;
                    }
                }

                if (!podcastReader.ProcessRss(path))
                {
                    return;
                }

                page++;
            }
        }
    }
}

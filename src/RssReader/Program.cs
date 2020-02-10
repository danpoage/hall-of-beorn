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
            var bsReader = new BlogspotRssReader();

            var url = string.Empty;
            var path = string.Empty;

            var isSingleFeed = false;
            if (isSingleFeed)
            {
                url = "http://susurrosdelbosqueviejo.blogspot.com/feeds/posts/default?alt=rss";
                    //"https://www.youtube.com/feeds/videos.xml?channel_id=UCj-QcL_YcA_DQKe7bSe9byA";
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

                if (!podcastReader.ProcessRss(path))
                {
                    return;
                }

                return;
            }


            var urlFormat = args.Length > 0
                ? args[0]
                : "https://www.blogger.com/feeds/7317893245431780918/posts/default?start-index={0}&max-results=25";
                //"https://menofgondor.wordpress.com/feed?paged={0}";
                //"https://unfinishedtrailsblog.wordpress.com/feed?paged={0}";
                //"https://reflectioninhennethannun.wordpress.com/feed?paged={0}";
                //"https://lotrdecktest.com/feed?paged={0}";
                //"https://wardenofarnor.wordpress.com/feed?paged={0}";
                //"https://secondhandtook.wordpress.com/feed?paged={0}";
                //"https://tcgcoop.design.blog/feed?paged={0}";
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
                : "Susurros{0}.rss";
                //"Die-Manner-von-Gondor{0}.rss";
                //"Unfinished-Trails{0}.rss";
                //"Reflection-in-HennethAnnun{0}.rss";
                //"LOTR-Deck-Test{0}.rss";
                //"Warden-of-Arnor{0}.rss";
                //"The-Secondhand-Took{0}.rss";
                //"TCGCoop{0}.rss";
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
            const int pageSize = 25;
            var index = 1;
            var useIndex = true;
            var maxPages = 7;

            while (true)
            {
                var urlIndex = useIndex ? index : page;
                url = string.Format(urlFormat, urlIndex);
                path = string.Format(pathFormat, page);

                if (!downloader.FileExists(path))
                {
                    if (!downloader.DownloadFile(url, path))
                    {
                        return;
                    }
                }

                if (!bsReader.ProcessRss(path))
                {
                    return;
                }

                page++;
                index = ((page - 1) * pageSize) + 1;

                if (page > maxPages)
                {
                    break;
                }
            }
        }
    }
}

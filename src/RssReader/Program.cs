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
                url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCUgU6nIpwNlADThJKEDV3Pg";
                path = ".\\Book-of-Elessar.rss";

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
                : "https://masteroflore.wordpress.com/feed?paged={0}";
                //"https://visionofthepalantir.com/feed/?paged={0}";
                //"https://talesfromthecards.wordpress.com/feed?paged={0}";
                //"https://hallofbeorn.wordpress.com/feed?paged={0}";

            var pathFormat = args.Length > 1
                ? args[1]
                : ".\\Master-of-Lore{0}.rss";
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

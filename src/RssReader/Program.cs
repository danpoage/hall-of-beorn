using System;
using System.IO;

namespace RssReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            var downloader = new FileDownloader();
            var reader = new XmlReader();

            var page = 1;
            var url = string.Empty;
            var path = string.Empty;

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

                if (!reader.ProcessRss(path))
                {
                    return;
                }

                page++;
            }
        }
    }
}

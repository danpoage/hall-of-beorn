using System;
using System.Xml;

namespace RssReader
{
    public class PodcastRssReader
    {
        private const string lineFormat = "            AddLink(\"{0}\", \"{1}\", \"{2}\");";
            //"            AddLink(\"{0}\", \"{1}\", \"{2}\", \"{3}\");";

        public bool ProcessRss(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                //var nsmgr = new XmlNamespaceManager(doc.NameTable);
                //nsmgr.AddNamespace("atom", "http://www.w3.org/2005/Atom");

                var items = doc.SelectNodes("/rss/channel/item");
                foreach (XmlNode itemNode in items)
                {
                    var title = itemNode.SelectSingleNode("title").InnerText;

                    var url = itemNode.SelectSingleNode("link").InnerText;

                    var pubDate = itemNode.SelectSingleNode("pubDate").InnerText;

                    Console.WriteLine(string.Format(lineFormat, title, url, pubDate));

                    /*
                    if (downloader != null)
                    {
                        var itemPath =  ".\\" + prefix + title
                            .Replace('"', ' ')
                            .Replace("!", "")
                            .Replace(".", "")
                            .Replace(" ", "-")
                            .Replace("---", "-")
                            + ".mp3";

                        if (!downloader.FileExists(itemPath) 
                            && !downloader.DownloadFile(url, itemPath))
                        {
                            Console.WriteLine(string.Format("Error downloading item {0}", itemPath));
                            break;
                        }
                    }
                    */
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error reading RSS {0}: {1}", path, ex.Message));
                return false;
            }
        }
    }
}

using System;
using System.Xml;

namespace RssReader
{
    public class XmlReader
    {
        private const string lineFormat = "            AddLink(\"{0}\", \"{1}\", \"{2}\");";
            //"            AddLink(\"{0}\", \"{1}\", \"{2}\", \"{3}\");";

        public bool ProcessRss(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                var items = doc.SelectNodes("/rss/channel/item");
                foreach (XmlNode itemNode in items)
                {
                    var title = itemNode.SelectSingleNode("title").InnerText;
                    //var titleParts = title.Split(':');
                    //if (titleParts.Length < 2)
                    //{
                    //    continue;
                    //}

                    //var number = titleParts[0].Replace("Episode ", string.Empty).Trim();
                    //var name = titleParts[1].Trim();

                    //var url = itemNode.SelectSingleNode("enclosure").Attributes["url"].Value;
                    var url = itemNode.SelectSingleNode("link").InnerText;

                    var pubDate = itemNode.SelectSingleNode("pubDate").InnerText;

                    Console.WriteLine(string.Format(lineFormat, title, url, pubDate));
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

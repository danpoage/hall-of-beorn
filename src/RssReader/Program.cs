using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssReader
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var path = args.Length > 0
                ? args[0]
                : "C:\\Users\\Dan\\My Documents\\Cardboard-of-the-Rings.rss";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            const string lineFormat = "            AddLink(\"{0}\", \"{1}\", \"{2}\", \"{3}\");";

            var items = doc.SelectNodes("/rss/channel/item");
            foreach (XmlNode itemNode in items)
            {
                var title = itemNode.SelectSingleNode("title").InnerText;
                var titleParts = title.Split(':');
                if (titleParts.Length < 2)
                {
                    continue;
                }

                var number = titleParts[0].Replace("Episode ", string.Empty).Trim();
                var name = titleParts[1].Trim();

                var url = itemNode.SelectSingleNode("enclosure").Attributes["url"].Value;

                var pubDate = itemNode.SelectSingleNode("pubDate").InnerText;

                Console.WriteLine(
                    string.Format(lineFormat, number, name, url, pubDate)
                    );
            }

            return 0;
        }
    }
}

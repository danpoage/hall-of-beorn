using System;
using System.Xml;

namespace RssReader
{
    public class YouTubeRssReader
    {
        private const string lineFormat = "            AddLink(\"{0}\", \"{1}\", \"{2}\");";

        public bool ProcessRss(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                var nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("atom", "http://www.w3.org/2005/Atom");

                var entries = doc.SelectNodes("/atom:feed/atom:entry", nsmgr);
                foreach (XmlNode entryNode in entries)
                {
                    var title = entryNode.SelectSingleNode("atom:title", nsmgr).InnerText;
                    var url = entryNode.SelectSingleNode("atom:link", nsmgr).Attributes["href"].Value;
                    var pubDate = entryNode.SelectSingleNode("atom:published", nsmgr).InnerText;

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

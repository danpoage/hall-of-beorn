using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CardGameDbBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CardGameDB Reader 1.0.0 (2020-12-23)");
            var offset = 0;
            const int pageSize = 25;
            const string urlFormat = "http://www.cardgamedb.com/index.php/thelordoftherings/the-lord-of-the-rings-decks/_/lord-of-the-rings-submitted-decks/?sort_col=record_updated&sort_order=desc&per_page=25&st={0}";

            try
            {
                for (var index = 0; index < 28; index++)
                {
                    offset = index * pageSize;
                    var pageFileName = string.Format(".\\html\\page{0}.html", index + 1);
                    var pageUrl = string.Format(urlFormat, offset);
                    DownloadFile(pageUrl, pageFileName);
                    
                    var content = ParseFile(pageFileName);

                    var regex = new Regex(pageRegex);
                    foreach (Match match in regex.Matches(content))
                    {
                        var deckUrl = match.Value;
                        var lastSlash = deckUrl.LastIndexOf('/') + 1;
                        if (lastSlash > 1)
                        {
                            var slug = deckUrl.Substring(lastSlash, deckUrl.Length - lastSlash);
                            Console.WriteLine("Deck {0} for URL: {1}", slug, deckUrl);
                            var deckFileName = string.Format(".\\html\\decks\\{0}.html", slug);
                            DownloadFile(deckUrl, deckFileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        private static void DownloadFile(string url, string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Downloading {0} to {1}", url, fileName);
                    client.DownloadFile(url, fileName);
                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not download {0} to {1}: {2}", url, fileName, ex.Message);
            }
        }

        private static string ParseFile(string fileName)
        {
            return File.ReadAllText(fileName, encoding);
        }

        private const string pageRegex = "http://www.cardgamedb.com/index.php/thelordoftherings/the-lord-of-the-rings-decks/_/lord-of-the-rings-submitted-decks/[a-z0-9-]+";
        private const string deckRegex = "";

        private static readonly WebClient client = new WebClient();
        private static readonly Encoding encoding = Encoding.UTF8;
    }
}

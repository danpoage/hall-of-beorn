using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CardGameDbBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CardGameDB Reader 1.0.0 (2020-12-22)");
            var offset = 0;
            const int pageSize = 25;
            const string urlFormat = "http://www.cardgamedb.com/index.php/thelordoftherings/the-lord-of-the-rings-decks/_/lord-of-the-rings-submitted-decks/?sort_col=record_updated&sort_order=desc&per_page=25&st={0}";

            var client = new WebClient();

            try
            {
                for (var index = 0; index < 28; index++)
                {
                    offset = index * pageSize;
                    var fileName = string.Format(".\\html\\page{0}.html", index + 1);
                    if (!File.Exists(fileName))
                    {
                        var url = string.Format(urlFormat, offset);
                        Console.WriteLine("Downloading {0} to {1} ...", url, fileName);
                        client.DownloadFile(url, fileName);
                        Console.WriteLine("... downloaded");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else 
                    {
                        Console.WriteLine("{0} already downloaded", fileName);
                    }

                    var content = File.ReadAllText(fileName, Encoding.UTF8);

                    var regex = new Regex("http://www.cardgamedb.com/index.php/thelordoftherings/the-lord-of-the-rings-decks/_/lord-of-the-rings-submitted-decks/[a-z0-9-]+");
                    foreach (Match match in regex.Matches(content))
                    {
                        Console.WriteLine("Deck URL: {0}", match.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

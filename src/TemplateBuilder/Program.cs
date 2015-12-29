using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn;
using HallOfBeorn.Models;
using HallOfBeorn.Services;

namespace TemplateBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hall of Beorn Card Search\r\nHTML TemplateBuilder 0.0.1");

            var productRepo = new ProductRepository();
            var cardRepo = new CardRepository(productRepo);

            const string file = "templates1.txt";
            foreach (var c in cardRepo.Cards())
            {
                if (string.IsNullOrEmpty(c.HtmlTemplate))
                {
                    Console.WriteLine("  Writing template for : " + c.Slug);
                    var text = string.Format("AddHtml(\"{0}\", \"{1}\");\r\n", c.Slug, GetTemplate(c));
                    File.AppendAllText(file, text);
                }
            }

            Console.WriteLine("DONE");
            Console.ReadLine();
        }

        private static string GetTemplate(Card card)
        {
            var html = new StringBuilder();

            html.Replace("\r\n", "<br>");
            html.Replace("\"", "&quot;");

            return html.ToString();
        }
    }
}

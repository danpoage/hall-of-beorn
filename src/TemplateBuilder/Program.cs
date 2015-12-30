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
        private static StatService statService;

        static void Main(string[] args)
        {
            Console.WriteLine("Hall of Beorn Card Search\r\nHTML TemplateBuilder 0.0.1");

            var productRepo = new ProductRepository();
            var cardRepo = new CardRepository(productRepo);

            statService = new StatService(cardRepo);

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

        private static void AddEffect(StringBuilder html, Card card, string text, bool isFirst, bool isParagraph)
        {
            if (isParagraph)
            {
                html.Append("<p>");
            }

            var effect = CardEffect.Parse(statService, card, text, isFirst);

            if (isParagraph)
            {
                html.Append("</p>");
            }
        }

        private static string GetTemplate(Card card)
        {
            var html = new StringBuilder();

            if (card.Keywords.Count > 0)
            {
                html.Append("<p>");
                foreach (var keyword in card.Keywords)
                {
                    AddEffect(html, card, keyword, false, false);
                }
                html.Append("</p>");
            }

            var isFirst = true;
            foreach (var text in card.Text.SplitLines())
            {
                AddEffect(html, card, text, isFirst, true);
            }

            html.Replace("\"", "&quot;");

            return html.ToString();
        }
    }
}

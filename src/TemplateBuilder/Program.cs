﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Stats;
using HallOfBeorn.Services.LotR.Templates;
using HallOfBeorn.Services.LotR.Translation;

namespace TemplateBuilder
{
    class Program
    {
        private static IStatService statService;

        static int Main(string[] args)
        {
            Language lang = Language.EN;
            Console.OutputEncoding = Encoding.UTF8;

            var productRepo = new ProductRepository();
            var translationService = new TranslationService();
            var cardRepo = new LotRCardRepository(productRepo);
            var templateService = new TemplateService();

            statService = new StatService(cardRepo, translationService);

            var abbreviation = (args != null && args.Length > 0) ? args[0] : string.Empty;

            Func<LotRCard, bool> filter = (c) => true;
            if (!string.IsNullOrEmpty(abbreviation))
            {
                filter = (c) => c.CardSet.Abbreviation == abbreviation;
            }

            foreach (var card in cardRepo.Cards().Where(filter))
            {
                if (string.IsNullOrEmpty(card.HtmlTemplate))
                {
                    var front = templateService.GetFrontHtml(card.Slug, lang);
                    if (string.IsNullOrEmpty(front))
                    {
                        Console.WriteLine("AddHtml(\"{0}\", \"{1}\");", 
                            card.Slug, GetTemplate(card, card.Text, card.Shadow, card.FlavorText, lang, true));

                        if (!string.IsNullOrEmpty(card.OppositeText) || !string.IsNullOrEmpty(card.OppositeFlavorText))
                        {
                            Console.WriteLine("AddHtml2(\"{0}\", \"{1}\");", 
                                card.Slug, GetTemplate(card, card.OppositeText, string.Empty, card.OppositeFlavorText, lang, false));
                        }
                    }
                }
            }

            return 0;
        }

        static void Main2(string[] args)
        {
            Console.WriteLine("Hall of Beorn Card Search: Template Builder 0.0.1");

            var productRepo = new ProductRepository();
            var translationService = new TranslationService();
            var cardRepo = new LotRCardRepository(productRepo);

            statService = new StatService(cardRepo, translationService);

            Language lang = Language.EN;

            const string file1 = "templates1.txt";
            const string file2 = "templates2.txt";
            foreach (var c in cardRepo.Cards())
            {
                if (string.IsNullOrEmpty(c.HtmlTemplate))
                {
                    Console.WriteLine("  Writing template1 for : " + c.Slug);
                    var text = string.Format("AddHtml(\"{0}\", \"{1}\");\r\n", c.Slug, GetTemplate(c, c.Text, c.Shadow, c.FlavorText, lang, true));
                    File.AppendAllText(file1, text);
                }

                if (string.IsNullOrEmpty(c.HtmlTemplate2) && !string.IsNullOrEmpty(c.OppositeText))
                {
                    Console.WriteLine("  Writing template2 for : " + c.Slug);
                    var text = string.Format("AddHtml2(\"{0}\", \"{1}\");\r\n", c.Slug, GetTemplate(c, c.OppositeText, string.Empty, c.OppositeFlavorText, lang, false));
                    File.AppendAllText(file2, text);
                }
            }

            Console.WriteLine("DONE");
            Console.ReadLine();
        }

        private static void AddEffect(StringBuilder html, LotRCard card, string text, bool isParagraph, Language? lang)
        {
            if (isParagraph)
            {
                html.Append("<p class='main-text'>");
            }

            var effect = CardEffect.Parse(statService, card, text, lang);

            foreach (var token in effect.Tokens)
            {
                if (token.IsTrigger || token.IsStrong)
                {
                    html.Append("<b>");
                }

                if (token.IsEmphasized)
                {
                    html.Append("<i>");
                }

                if (token.IsIcon)
                {
                    html.Append("{" + token.Text + "}");
                }
                else if (token.IsTitleReference)
                {
                    html.Append("{title:" + token.Text + "}");
                }
                else
                {
                    html.Append(token.Text);
                }

                if (token.IsEmphasized)
                {
                    html.Append("</i>");
                }

                if (token.IsTrigger || token.IsStrong)
                {
                    html.Append("</b>");
                }
            }

            if (isParagraph)
            {
                html.Append("</p>");
            }
        }

        private static string GetTemplate(LotRCard card, string text, string shadowText, string flavorText, Language? lang, bool isFront)
        {
            var html = new StringBuilder();

            var isQuest = card.CardType == CardType.Quest || card.CardType == CardType.Player_Side_Quest || card.CardType == CardType.Encounter_Side_Quest;

            if (isQuest)
            {
                if (!string.IsNullOrEmpty(flavorText))
                {
                    html.Append("<p class='flavor-text'>");
                    html.Append(flavorText.Replace("\r\n", "<br>").Replace("-", "&ndash;"));
                    html.Append("</p>");
                }
            }

            /*
            if (card.Keywords.Count() > 0)
            {
                html.Append("<p>");
                foreach (var keyword in card.Keywords)
                {
                    AddEffect(html, card, keyword, false, lang);
                }
                html.Append("</p>");
            }*/

            foreach (var line in text.SplitLines())
            {
                AddEffect(html, card, line, true, lang);
            }

            if (!string.IsNullOrEmpty(shadowText))
            {
                html.Append("{shadow}<p class='shadow-text'>");

                AddEffect(html, card, shadowText, false, lang);

                html.Append("</p>");
            }

            if (!isQuest && !string.IsNullOrEmpty(flavorText))
            {
                html.Append("<p class='flavor-text'>");
                html.Append(flavorText.Replace("\r\n", "<br>").Replace("-", "&ndash;"));
                html.Append("</p>");
            }

            if (isFront && card.VictoryPoints > 0) {
                html.Append("{victory:" + card.VictoryPoints.ToString() + "}");
            }

            html.Replace("\"", "&quot;");

            return html.ToString();
        }
    }
}

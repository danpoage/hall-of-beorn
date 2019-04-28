﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace SetBuilder
{
    class Program
    {
        private const string namespaceFormat     = "namespace HallOfBeorn.Models.LotR.Sets.{0}";
        private const string classFormat         = "    public class {0}Set : CardSet";
        private const string addHeroFormat       = "        addHero(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6})";
        private const string addAllyFormat       = "        addAlly(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6}, {7})";
        private const string addAttachmentFormat = "        addAttachment(\"{0}\", {1}, {2}, {3})";
        private const string addEventFormat      = "        addEvent(\"{0}\", {1}, {2})";
        private const string withTraitsFormat    = "            .WithTraits({0})";
        private const string withKeywordsFormat  = "            .WithKeywords({0})";
        private const string withTextFormat      = "            .WithText(\"{0}\")";
        private const string withFlavorFormat    = "            .WithFlavor(\"{0}\")";
        private const string withInfoFormat      = "            .WithInfo({0}, {1}, Artist.{2});";

        private static string title(string token)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(token);
        }

        private static string init(CardSet cardSet)
        {
            var s = new StringBuilder();

            s.AppendFormat("            Name = \"{0}\";", cardSet.Name);
            s.AppendLine();

            s.AppendFormat("            Abbreviation = \"{0}\";", cardSet.Abbreviation);
            s.AppendLine();

            s.AppendFormat("            Number = {0};", cardSet.Number);
            s.AppendLine();

            s.AppendFormat("            SetType = SetType.{0};", Enum.GetName(typeof(SetType), cardSet.SetType));
            s.AppendLine();

            if (string.IsNullOrWhiteSpace(cardSet.Cycle))
            {
                s.AppendFormat("            Cycle = \"{0}\";", cardSet.Cycle);
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string normalizedSetName(CardSet cardSet)
        {
            return string.Join(string.Empty, cardSet.Name.Split(' ')
                .Select(token => title(token))
            );
        }

        private static string header(CardSet cardSet)
        {
            var setName = normalizedSetName(cardSet);

            var cycleName = !string.IsNullOrWhiteSpace(cardSet.Cycle) ? title(cardSet.Cycle) : setName;

            var s = new StringBuilder();
            s.AppendLine("/* Generated CardSet class */");
            s.AppendLine();

            s.AppendLine("using System;");
            s.AppendLine();

            s.AppendFormat(namespaceFormat, cycleName);
            s.AppendLine();
            s.AppendLine("{");

            s.AppendFormat(classFormat, setName);
            s.AppendLine();
            s.AppendLine("    {");

            s.AppendLine("        protected override void Initialize()");
            s.AppendLine("        {");

            s.AppendLine(init(cardSet));

            return s.ToString();
        }

        private static string footer()
        {
            var s = new StringBuilder();
            
            s.AppendLine("        }");
            s.AppendLine("    }");
            s.AppendLine("}");

            return s.ToString();
        }

        private static string sphere(LotRCard card)
        {
            return "Sphere." + Enum.GetName(typeof(Sphere), card.Sphere);
        }

        private static string withTraits(LotRCard card)
        {
            if (card.Traits == null || card.Traits.Count() == 0)
                return string.Empty;

            return string.Format(withTraitsFormat,
                string.Join(",",
                    card.Traits.Select(t => "\"" + t + "\"")
                )
            ) + Environment.NewLine;
        }

        private static string withKeywords(LotRCard card)
        {
            if (card.Keywords == null || card.Keywords.Count() == 0)
                return string.Empty;

            return string.Format(withKeywordsFormat,
                string.Join(",",
                    card.Keywords.Select(k => "\"" + k + "\"")
                )
            ) + Environment.NewLine;
        }

        private static string withText(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.Text))
                return string.Empty;

            return string.Format(withTextFormat,
                card.Text) + Environment.NewLine;
        }

        private static string withFlavor(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.FlavorText))
                return string.Empty;

            return string.Format(withFlavorFormat,
                card.FlavorText) + Environment.NewLine;
        }

        private static string withInfo(LotRCard card)
        {
            return string.Format(withInfoFormat,
                card.CardNumber,
                card.Quantity,
                Enum.GetName(typeof(Artist), card.Artist)
                );
        }

        private static string cardTextBox(LotRCard card)
        {
            var s = new StringBuilder();

            s.Append(withTraits(card));
            s.Append(withKeywords(card));
            s.Append(withText(card));
            s.Append(withFlavor(card));

            s.AppendLine(withInfo(card));

            return s.ToString();
        }

        private static string addHero(LotRCard hero)
        {
            var s = new StringBuilder();

            s.AppendFormat(addHeroFormat, 
                hero.Title, 
                hero.ThreatCost.GetValueOrDefault(), 
                sphere(hero),
                hero.Willpower.GetValueOrDefault(),
                hero.Attack.GetValueOrDefault(),
                hero.Defense.GetValueOrDefault(),
                hero.HitPoints.GetValueOrDefault()
                );
            s.AppendLine();

            s.Append(cardTextBox(hero));

            return s.ToString();
        }

        private static string addAlly(LotRCard ally)
        {
            var s = new StringBuilder();
            
            s.AppendFormat(addAllyFormat, 
                ally.Title,
                ally.ResourceCost.GetValueOrDefault(),
                sphere(ally),
                ally.IsUnique,
                ally.Willpower,
                ally.Attack,
                ally.Defense,
                ally.HitPoints
                );
            s.AppendLine();

            s.Append(cardTextBox(ally));

            return s.ToString();
        }

        private static string addAttachment(LotRCard attachment)
        {
            var s = new StringBuilder();

            s.AppendFormat(addAttachmentFormat, 
                attachment.Title,
                attachment.ResourceCost.GetValueOrDefault(),
                sphere(attachment),
                attachment.IsUnique
                );
            s.AppendLine();

            s.Append(cardTextBox(attachment));

            return s.ToString();
        }

        private static string addEvent(LotRCard ev)
        {
            var s = new StringBuilder();

            s.AppendFormat(addEventFormat,
                ev.Title,
                ev.ResourceCost.GetValueOrDefault(),
                sphere(ev)
                );
            s.AppendLine();

            s.Append(cardTextBox(ev));

            return s.ToString();
        }

        private static Dictionary<CardType, Func<LotRCard, string>> map = new Dictionary<CardType, Func<LotRCard, string>>
        {
            { CardType.Hero, hero => addHero(hero) },
            { CardType.Ally, ally => addAlly(ally) },
            { CardType.Attachment, attachment => addAttachment(attachment) },
            { CardType.Event, ev => addEvent(ev) },
        };

        static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("usage: sb [set-abbreviation]");
                return 1;
            }

            var abbreviation = args[0] ?? string.Empty;

            var productRepository = new HallOfBeorn.Services.LotR.ProductRepository();

            var product = productRepository.Products()
                .Where(prod => prod.CardSets != null 
                    && prod.CardSets.Where(cs => cs.Abbreviation == abbreviation).FirstOrDefault() != null)
                .FirstOrDefault();

            if (product == null)
            {
                Console.WriteLine("card set not found: " + abbreviation);
                return 1;
            }

            var cardSet = product.CardSets.Where(cs => cs.Abbreviation == abbreviation).FirstOrDefault();

            writeCardSet(cardSet);
            
            return 0;
        }

        private static void writeCardSet(CardSet cardSet)
        {
            Console.WriteLine(header(cardSet));

            if (cardSet.Cards != null)
            {
                foreach (var card in cardSet.Cards.OrderBy(c => c.CardNumber))
                {
                    if (!map.ContainsKey(card.CardType))
                        continue;

                    Console.WriteLine(map[card.CardType](card));
                }
            }

            Console.WriteLine(footer());
        }
    }
}

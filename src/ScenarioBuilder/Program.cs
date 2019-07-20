using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;

namespace ScenarioBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepo = new ProductRepository();
            var cardRepo = new LotRCardRepository(productRepo);
            var playerCategoryService = new PlayerCategoryService(cardRepo);
            var encounterCategoryService = new EncounterCategoryService(cardRepo);
            var questCategoryService = new QuestCategoryService(cardRepo);
            var ringsDbService = new RingsDbService(cardRepo);
            var scenarioService = new ScenarioService(playerCategoryService, encounterCategoryService, questCategoryService,
                ringsDbService, productRepo, cardRepo);

            Console.WriteLine("Scenario Builder");

            foreach (var g in scenarioService.ScenarioGroups())
            {
                Console.WriteLine("Scenario Group: " + g.Name);
                foreach (var s in g.Scenarios)
                {
                    var slug = getScenarioSlug(s);
                    var fileName = slug + ".cs";
                    Console.WriteLine(string.Format("  {0} ({1})", s.Title, fileName));
                    var text = getScenarioText(s, slug);
                    System.IO.File.WriteAllText(fileName, text);
                }
            }

            Console.WriteLine("DONE");
            Console.ReadLine();
        }

        private static string normalizeString(string str)
        {
            var result = new StringBuilder();
            var norm1 = str.NormalizeCaseSensitiveString().Replace("'", string.Empty);

            char prev = '0';
            foreach (var c in norm1)
            {
                if (prev == ' ' || prev == '-')
                {
                    result.Append(c.ToString().ToUpper());
                } else {
                    if (c != ' ' && c != '-' && c != '\'' && c != ',')
                    {
                        result.Append(c.ToString());
                    }
                }

                prev = c;
            }

            return result.ToString();
        }

        private static string getScenarioSlug(Scenario s)
        {
            return normalizeString(s.Title);
        }

        private static IEnumerable<string> getEncounterSets(Scenario s)
        {
            var sets = new Dictionary<string, bool>();

            foreach (var sc in s.ScenarioCards)
            {
                var norm = normalizeString(sc.EncounterSet);
                if (!sets.ContainsKey(norm))
                {
                    sets.Add(norm, true);
                }
            }

            return sets.Keys.ToList();
        }

        private static void excludeEasyModeCards(Scenario s, StringBuilder text)
        {
            foreach (var sc in s.ScenarioCards)
            {
                if (sc.Card.EasyModeQuantity.HasValue && sc.Card.EasyModeQuantity.Value != sc.Card.Quantity)
                {
                    var exclude = sc.Card.Quantity - sc.Card.EasyModeQuantity.Value;
                    text.AppendFormat("            ExcludeFromEasyMode(\"{0}\", {1});\r\n", sc.Card.Slug, exclude);
                }
            }
        }

        private static void excludeNightmareModeCards(Scenario s, StringBuilder text)
        {
            foreach (var sc in s.ScenarioCards)
            {
                if (sc.NightmareQuantity < sc.NormalQuantity)
                {
                    var exclude = sc.NormalQuantity - sc.NightmareQuantity;
                    text.AppendFormat("            ExcludeFromNightmareMode(\"{0}\", {1});\r\n", sc.Card.Slug, exclude);
                }
            }
        }

        private static string getScenarioText(Scenario s, string slug)
        {
            var text = new StringBuilder();

            text.AppendLine("namespace HallOfBeorn.Models.Scenarios");
            text.AppendLine("{");
            text.AppendFormat("    public class {0} : Scenario\r\n", slug);
            text.AppendLine("    {");
            text.AppendFormat("        public {0}()\r\n", slug);
            text.AppendLine("        {");


            text.AppendFormat("            Title = \"{0}\";\r\n", s.Title);
            text.AppendFormat("            ProductName = \"{0}\";\r\n", s.ProductName);
            text.AppendFormat("            GroupName = \"{0}\";\r\n", s.GroupName);
            text.AppendFormat("            Number = {0};\r\n", s.Number);
            text.AppendLine();

            foreach (var es in getEncounterSets(s))
            {
                text.AppendFormat("            AddEncounterSet(EncounterSet.{0});\r\n", es);
            }

            text.AppendLine();

            foreach (var qc in s.QuestCards)
            {
                text.AppendFormat("            AddQuestCardId(\"{0}\");\r\n", qc.Quest.Slug);
            }

            text.AppendLine();

            excludeEasyModeCards(s, text);

            text.AppendLine();

            excludeNightmareModeCards(s, text);

            text.AppendLine("        }");
            text.AppendLine("    }");
            text.AppendLine("}");

            return text.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HallOfBeorn;

namespace HallOfBeorn.Models.Digital
{
    public class DigitalCard : ICard
    {
        public string Slug { get; set; }
        public string SlugSuffix { get; set; }

        public string AlternateSlug { get; set; }
        public string Title { get; set; }
        public string NormalizedTitle { get { return Title.NormalizeCaseSensitiveString(); } }
        public DigitalCardType CardType { get; set; }
        public DigitalSphere Sphere { get; set; }
        public AttachmentSlot? Slot { get; set; }
        public bool IsUnique { get; set; }

        public byte? Level { get; set; }
        public DigitalRarity? Rarity { get; set; }

        //Stats
        public byte? ThreatCost { get; set; }
        public byte? ResourceCost { get; set; }
        public byte? Attack { get; set; }
        public byte? Willpower { get; set; }
        public byte? HitPoints { get; set; }

        public DigitalTrait? Trait { get; set; }

        public string Text { get; set; }
        public string OppositeText { get { return null; } }

        private string _html;
        public string Html
        {
            get
            {
                return !string.IsNullOrEmpty(_html) ?
                    _html :
                    RenderHtml();
            }
            set { _html =  value; }
        }

        public Artist Artist { get; set; }

        public DigitalCardSet CardSet { get; set; }
        public uint Number { get; set; }

        public string CardSetName
        { 
            get { return CardSet != null ? CardSet.Name.NormalizeCaseSensitiveString()  : string.Empty; }
        }

        public bool IsCampaign { get { return false; } }
        public bool IsQuest { get { return false; } }
        public bool IsSetup { get { return false; } }
        public uint StageNumber { get { return 0; } }
        public char StageLetter { get { return '\0'; } }

        private string RenderHtml()
        {
            const string searchUrl = "/Digital/Search?";
            const string defaultValue = "None";

            var map = new Dictionary<string, string>()
            {
                { "Attack", "⚔️" },
                { "Willpower", "♢" },
                { "Health", "❤" },
                { "Resource", "◯" }
            };
            
            foreach (var keyword in Enum.GetNames(typeof(DigitalKeyword)))
            {
                if (keyword == defaultValue)
                    continue;

                map.Add(keyword, string.Format("<a href='{0}Keyword={1}' target='_blank' title='Keyword Search'><b>{1}</b></a>", searchUrl, keyword));
            }

            foreach (var trait in Enum.GetNames(typeof(DigitalTrait)))
            {
                if (trait == defaultValue)
                    continue;

                map.Add(trait, string.Format("<a href='{0}Trait={1}' target='_blank' title='Trait Search'><b><i>{1}</i></b></a>", searchUrl, trait));
            }

            var html = new StringBuilder();
            var lines = Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                html.Append(RenderLine(map, line));
            }
            return html.ToString();
        }

        private string RenderLine(Dictionary<string, string> map, string line)
        {
            var textTokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var htmlTokens = new List<string>();

            var hasColon = false;
            var hasPeriod = false;
            var hasComma = false;
            foreach (var token in textTokens)
            {
                hasColon = token.EndsWith(":");
                hasPeriod = token.EndsWith(".");
                hasComma = token.EndsWith(",");

                var value = token.TrimEnd(new char[] { ':', '.', ',' });

                if (map.ContainsKey(value))
                {
                    value = map[value];

                    if (hasColon)
                        value = value + ":";
                    if (hasPeriod)
                        value = value + ".";
                    if (hasComma)
                        value = value + ",";
                    
                    htmlTokens.Add(value);
                }
                else
                {
                    htmlTokens.Add(token);
                }
            }

            return string.Format("<p style='text-align:center'>{0}</p>", string.Join(" ", htmlTokens));
        }
    }
}
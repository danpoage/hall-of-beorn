using System;
using System.Collections.Generic;

using HallOfBeorn.Models.LotR;

namespace SetBuilder
{
    public class ALePCard
    {
        public string code { get; set; }
        public int deck_limit { get; set; }
        public string flavor { get; set; }
        public string illustrator { get; set; }
        public bool is_unique { get; set; }
        public List<string> keywords { get; set; }
        public string name { get; set; }
        public string octgnid { get; set; }
        public int position { get; set; }
        public byte quantity { get; set ; }
        public string sphere_name { get; set; }
        public string text { get; set; } //Side A, Side B
        public List<string> traits { get; set; }
        public List<string> additional_encounter_sets { get; set; }
        public string type_name { get; set; }
        public string attack { get; set; }
        public string cost { get; set; }
        public string defense { get; set; }
        public string health { get; set; }
        public string threat { get; set; }
        public string willpower { get; set; }
        public string encounter_set { get; set; }
        public string opposite_stage_letter { get; set; }
        public string stage_letter { get; set; }
        public string quest_points { get; set; }
        public int? quest_stage { get; set; }
        public string shadow_text { get; set; }
        public string threat_strength { get; set; }
        public string subtitle { get; set; }

        private Tuple<string, string> ParseText()
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Tuple<string, string>(null, null);
            }

            var lines = text.Split(new string[] { "Side B" }, StringSplitOptions.RemoveEmptyEntries);

            return (lines.Length > 1)
               ? new Tuple<string, string>(lines[0].Remove(0, 6), lines[1])
               : new Tuple<string, string>(lines[0], null);
        }

        private string NormalizeTemplate(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
            {
                return html;
            }

            return html;
        }

        public LotRCard ToCard()
        {
            var card = new LotRCard();

            switch (type_name)
            {
                case "Hero":
                    card.CardType = CardType.Hero;
                    break;
                case "Ally":
                    card.CardType = CardType.Ally;
                    break;
                case "Attachment":
                    card.CardType = CardType.Attachment;
                    break;
                case "Event":
                    card.CardType = CardType.Event;
                    break;
                case "Player Side Quest":
                    card.CardType = CardType.Player_Side_Quest;
                    break;
                case "Contract":
                    card.CardType = CardType.Contract;
                    break;
                default:
                    card.CardType = CardType.None;
                    break;
            }

            var parsed = ParseText();
            card.HtmlTemplate = parsed.Item1;
            card.HtmlTemplate2 = parsed.Item2;
            card.Text = NormalizeTemplate(parsed.Item1);
            card.OppositeText = NormalizeTemplate(parsed.Item2);
            card.FlavorText = flavor;

            card.Quantity = quantity;
            card.CardNumber = (ushort)position;
            card.Title = name;

            return card;
        }
    }
}

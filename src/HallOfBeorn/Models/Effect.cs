using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public class Effect
    {
        public Effect(CardEffectType effectType, LayoutType layoutType)
        {
            this.EffectType = effectType;
            this.LayoutType = layoutType;
            this.Tokens = new List<EffectToken>();
        }

        public CardEffectType EffectType { get; private set; }
        public LayoutType LayoutType { get; private set; }
        public List<EffectToken> Tokens { get; private set; }

        public static Effect New(CardEffectType effectType, LayoutType layoutType)
        {
            return new Effect(effectType, layoutType);
        }

        public Effect Text(string text)
        {
            Tokens.Add(new EffectToken(EffectTokenType.Text, string.Empty, text, string.Empty));
            return this;
        }

        public Effect Flavor(string text)
        {
            Tokens.Add(new EffectToken(EffectTokenType.Flavor_Text, string.Empty, text, string.Empty));
            return this;
        }

        public Effect InlineText(string text)
        {
            Tokens.Add(new EffectToken(EffectTokenType.Inline_Text, string.Empty, text, string.Empty));
            return this;
        }

        public Effect Quote(Effect effect)
        {
            Tokens.Add(new EffectToken(EffectTokenType.Inline_Prefix, string.Empty, "&ldquo;", string.Empty));
            foreach (var token in effect.Tokens)
            {
                Tokens.Add(token);
            }
            Tokens.Add(new EffectToken(EffectTokenType.Inline_Text, string.Empty, "&rdquo;", string.Empty));
            return this;
        }

        public Effect Trigger(CardEffectType trigger)
        {
            Tokens.Add(new EffectToken(EffectTokenType.Trigger, string.Empty, string.Format("{0}:", trigger.ToString().Replace('_', ' ')), string.Empty));
            return this;
        }

        public string ToHtml(Card card)
        {
            var html = new StringBuilder();

            switch (LayoutType)
            {
                case Models.LayoutType.Important:
                    html.Append("<p><strong>");
                    break;
                case Models.LayoutType.Block:
                    html.Append("<p>");
                    break;
                case Models.LayoutType.Inline:
                default:
                    break;
            }

            html.Append(EffectType.Html());

            var prefix = string.Empty;
            foreach (var token in Tokens)
            {
                if (token.TokenType != EffectTokenType.Inline_Text)
                {
                    html.Append(prefix);
                }
                html.Append(token.ToHtml(card));

                if (token.TokenType == EffectTokenType.Inline_Prefix)
                {
                    prefix = string.Empty;
                } else {
                    prefix = " ";
                }
            }

            switch (LayoutType)
            {
                case Models.LayoutType.Important:
                    html.Append("</strong></p>");
                    break;
                case Models.LayoutType.Block:
                    html.Append("</p>");
                    break;
                case Models.LayoutType.Inline:
                default:
                    break;
            }

            return html.ToString();
        }

        public string ToText(Card card)
        {
            var text = new StringBuilder();

            text.Append(EffectType.Text());

            if (LayoutType == Models.LayoutType.Block || LayoutType == Models.LayoutType.Important)
            {
                text.Append("\r\n");
            }

            var prefix = string.Empty;
            foreach (var token in Tokens)
            {
                if (token.TokenType != EffectTokenType.Inline_Text)
                {
                    text.Append(prefix);
                }
                text.Append(token.ToText(card));
                prefix = " ";
            }

            return text.ToString();
        }
    }
}

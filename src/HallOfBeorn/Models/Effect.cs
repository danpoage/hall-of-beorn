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

        public string ToHtml()
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

            foreach (var token in Tokens)
            {
                html.Append(token.Html());
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

        public string ToText()
        {
            var text = new StringBuilder();

            text.Append(EffectType.Text());

            if (LayoutType == Models.LayoutType.Block || LayoutType == Models.LayoutType.Important)
            {
                text.Append("\r\n");
            }

            return text.ToString();
        }
    }
}

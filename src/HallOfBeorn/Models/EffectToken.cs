using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models
{
    public class EffectToken
    {
        public EffectToken(EffectTokenType tokenType, string prefix, object textBody, object htmlBody, string suffix)
        {
            this.TokenType = tokenType;
            this.Prefix = prefix;
            this.TextBody = textBody;
            this.HtmlBody = htmlBody != null ? htmlBody : textBody;
            this.Suffix = suffix;
        }

        public EffectTokenType TokenType { get; private set; }
        public string Prefix { get; private set; }
        public object TextBody { get; private set; }
        public object HtmlBody { get; private set; }
        public string Suffix { get; private set; }

        public string ToText(Card card)
        {
            var text = new StringBuilder();

            if (!string.IsNullOrEmpty(Prefix))
            {
                text.Append(Prefix);
            }

            switch (TokenType)
            {
                case EffectTokenType.Attack_Icon:
                    text.Append("Attack");
                    break;
                case EffectTokenType.Defense_Icon:
                    text.Append("Defense");
                    break;
                case EffectTokenType.Self:
                    text.Append(card.Title);
                    break;
                case EffectTokenType.Card_Title:
                    //text.Append(Body.ToString());
                    break;
                case EffectTokenType.Specific_Card:
                    //text.Append(card.Title);
                    break;
                case EffectTokenType.Text:
                case EffectTokenType.Inline_Text:
                    text.Append(TextBody.ToString());
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(Suffix))
            {
                text.Append(Suffix);
            }

            return text.ToString();
        }

        public string ToHtml(Card card)
        {
            var html = new StringBuilder();

            if (!string.IsNullOrEmpty(Prefix))
            {
                html.Append(Prefix);
            }

            switch (TokenType)
            {
                case EffectTokenType.Attack_Icon:
                    html.Append("<img src='/Images/attack.gif'>");
                    break;
                case EffectTokenType.Defense_Icon:
                    html.Append("<img src='/Images/defense.gif'>");
                    break;
                case EffectTokenType.Self:
                    html.Append(card.Title);
                    break;
                case EffectTokenType.Card_Title:
                    //html.AppendFormat("<a href='/Cards/Search?Query=%2Btitle%3A{0}' target='_blank' title='{1}'>{1}</a>", card.Title.UrlEncode(), card.Title);
                    break;
                case EffectTokenType.Specific_Card:
                    //var specific = (Card)Body;
                    //html.AppendFormat("<a href='/Cards/Details/{0} target='_blank' title={1}'>{1}</a>", specific.Slug, specific.Title);
                    break;
                case EffectTokenType.Text:
                case EffectTokenType.Inline_Text:
                case EffectTokenType.Inline_Prefix:
                    html.Append(HtmlBody.ToString());
                    break;
                case EffectTokenType.Flavor_Text:
                    html.AppendFormat("<i>{0}</i>", HtmlBody.ToString());
                    break;
                case EffectTokenType.Trigger:
                    {
                        if (TextBody.ToString() == "Shadow:")
                        {
                            html.Append("<br/><img src='/Images/ShadowDivider.png' style='display:block;margin-left:auto;margin-right:auto;width:285px;'/><br/>");
                        }

                        html.AppendFormat("<strong>{0}</strong>", HtmlBody.ToString());
                    }
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(Suffix))
            {
                html.Append(Suffix);
            }

            return html.ToString();
        }
    }
}
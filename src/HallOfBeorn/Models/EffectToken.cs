using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models
{
    public class EffectToken
    {
        public EffectToken(EffectTokenType tokenType, string prefix, object body, string suffix)
        {
            this.TokenType = tokenType;
            this.Prefix = prefix;
            this.Body = body;
            this.Suffix = suffix;
        }

        public EffectTokenType TokenType { get; private set; }
        public string Prefix { get; private set; }
        public object Body { get; private set; }
        public string Suffix { get; private set; }

        public string Html()
        {
            var html = new StringBuilder();

            if (!string.IsNullOrEmpty(Prefix))
            {
                html.Append(Prefix);
            }

            switch (TokenType)
            {
                case EffectTokenType.Attack_Icon:
                    html.Append("<img src='/Images.attack.gif'>");
                    break;
                case EffectTokenType.Card_Title:
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
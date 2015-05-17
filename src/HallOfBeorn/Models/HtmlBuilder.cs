using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum Trigger : byte
    {
        Action,
        Resource_Action,
        Planning_Action,
        Quest_Action,
        Travel_Action,
        Encounter_Action,
        Combat_Action,
        Refresh_Action,
        Response,
        Setup,
        Forced,
        Travel,
        Shadow
    }

    public enum AttachmentTarget: byte
    {
        Title,
        Card,
        Hero,
        Hero_or_Title,
        Character,
        Ally,
        SpheresHero,
        SpheresCharacter,
        SpheresAlly,
        TraitsHero,
        TraitsCharacter,
        TraitsAlly
    }

    public class HtmlBuilder
    {
        public HtmlBuilder(Card card)
        {
            this.card = card;
        }

        private readonly Card card;
        private readonly StringBuilder html = new StringBuilder();

        private HtmlBuilder Trigger(Trigger trigger, string text)
        {
            html.AppendFormat("<b>{0}:</b>&nbsp;{1}", trigger.ToString().Replace('_', ' '), text);
            return this;
        }

        public HtmlBuilder AttachTo(AttachmentTarget target, params string[] values)
        {
            if (values == null || values.Length == 0)
                return this;

            var url = string.Format("/Cards/Search/{0}", values[0]);
            var label = values[0];
            switch (target)
            {
                case AttachmentTarget.Card:
                    url = string.Format("/Cards/Details/{0}", values[0].ToUrlSafeString());
                    break;
                case AttachmentTarget.Title:
                    url = string.Format("/Cards/Search?Query=%2Btitle%3D{0}", values[0].UrlEncode());
                    break;
                case AttachmentTarget.Hero:
                    url = "/Cards/Search?CardType=Hero";
                    break;
                //TODO: Add support for OR in query filters
                //case AttachmentTarget.Hero_or_Title:
                //    url = string.Format("/Cards/Search?Query=%2Btitle%3D{0}%20%2Bhero", values[0]);
                //    break;
                case AttachmentTarget.Ally:
                    url = "/Cards/Search?CardType=Ally";
                    break;
                case AttachmentTarget.Character:
                    url = "/Cards/Search?CardType=Character";
                    break;
                case AttachmentTarget.SpheresHero:
                    url = string.Format("/Cards/Search?CardType=Hero&Query=%2Bsphere%3D{0}", string.Join(",", values));
                    break;
                case AttachmentTarget.SpheresAlly:
                    url = string.Format("/Cards/Search?CardType=Ally&Query=%2Bsphere%3D{0}", string.Join(",", values));
                    break;
                case AttachmentTarget.SpheresCharacter:
                    url = string.Format("/Cards/Search?CardType=Character&Query=%2Bsphere%3D{0}", string.Join(",", values));
                    break;
                default:
                    break;
            }
            html.AppendFormat("Attach to <a href='{0}' target='_blank'>{1}</a>", url, label);
            return this;
        }

        public override string ToString()
        {
            return html.ToString();
        }
    }
}
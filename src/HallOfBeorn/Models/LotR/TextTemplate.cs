using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HallOfBeorn.Models.LotR
{
    public class TextTemplate
    {
        public TextTemplate(LotRCard card)
        {
            this.card = card;
        }

        private readonly LotRCard card;

        private static string GetDiscordTemplate(string template)
        {
            var map = new Dictionary<string, string>
            {
                { "{Willpower}", "[willpower]" },
                { "{Attack}", "[attack]" },
                { "{Defense}", "[defense]" },
                { "{Threat}", "[threat]" },
                { "{sphere:Leadership}", "[leadership]" },
                { "{sphere:Tactics}", "[tactics]" },
                { "{sphere:Spirit}", "[spirit]" },
                { "{sphere:Lore}", "[lore]" },
                { "{sphere:Baggins}", "[baggins]" },
                { "{sphere:Fellowship}", "[fellowship]" },
                { "{sphere:Mastery}", "Mastery" },
                { "<p class='main-text'>", string.Empty },
                { "<p class='shadow-text'>", string.Empty },
                { "<p class='flavor-text'>", "{stop}" },
                { "</p>", "\n" },
                { "<p>", "\n" },
                { "&quot;", "\"" },
                { "<blockquote>", " “" },
                { "</blockquote>", "”" },
                { "{shadow}", ">>===≈💀≈===<<\n" }
            };

            foreach (var pair in map)
            {
                template = template.Replace(pair.Key, pair.Value);
            }

            return template;
        }

        public string RenderHtml(string template, Language lang, bool forDiscord)
        {
            if (string.IsNullOrEmpty(template))
            {
                return string.Empty;
            }

            if (forDiscord)
            {
                template = GetDiscordTemplate(template);
            }

            var s = new StringBuilder();
            var t = template;

            var isToken = false;
            var isType = false;
            var type = string.Empty;
            var isKey = false;
            var key = string.Empty;
            var isLabel = false;
            var label = string.Empty;

            for (var i = 0; i < t.Length; i++)
            {
                if (t[i] == '{') {
                    isToken = true;
                    isType = true;
                } else {
                    if (isToken) {
                        switch (t[i]) {
                            case '}':
                                isToken = false;
                                isType = false;
                                isKey = false;
                                isLabel = false;
                                if (type == "self")
                                {
                                    if (string.IsNullOrEmpty(key))
                                    {
                                        key = card.Slug;
                                    }
                                    if (string.IsNullOrEmpty(label))
                                    {
                                        label = card.Title;
                                    }
                                }

                                if (forDiscord)
                                {
                                    if (!insertDiscordToken(s, type, key, label, lang))
                                    {
                                        return s.ToString();
                                    }
                                }
                                else
                                {
                                    insertHtmlToken(s, type, key, label, lang);
                                }
                                type = string.Empty;
                                key = string.Empty;
                                label = string.Empty;
                                break;
                            case ':':
                                isType = false;
                                isKey = true;
                                isLabel = false;
                                break;
                            case '@':
                                isType = false;
                                isKey = false;
                                isLabel = true;
                                break;
                            default:
                                {
                                    if (isType)
                                    {
                                        type += t[i];
                                    }
                                    else if (isKey)
                                    {
                                        key += t[i];
                                    }
                                    else if (isLabel)
                                    {
                                        label += t[i];
                                    }
                                }
                                break;
                        }
                    } else {
                        s.Append(t[i]);
                    }
                }
            }

            return s.ToString().TrimEnd();
        }

        private bool insertDiscordToken(StringBuilder sb, string type, string key, string label, Language lang)
        {
            if (string.IsNullOrEmpty(type))
            {
                return true;
            }

            if (string.IsNullOrEmpty(key))
            {
                key = type;
            }

            if (string.IsNullOrEmpty(label))
            {
                label = key;
            }

            key = key.Replace("'", "’"); //"%27");
            label = label.Replace("'", "’");

            switch (type.ToLowerSafe())
            {
                case "stop":
                    return false;
                case "trait":
                    sb.AppendFormat("<b><i>{0}</i></b>", label);
                    break;
                case "victory":
                    sb.AppendFormat("\n<b>Victory {0}</b>", key);
                    break;
                default:
                    sb.Append(label);
                    break;
            }

            return true;
        }

        private void insertHtmlToken(StringBuilder sb, string type, string key, string label, Language lang)
        {
            if (string.IsNullOrEmpty(type))
            {
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                key = type;
            }

            if (string.IsNullOrEmpty(label))
            {
                label = key;
            }

            key = key.Replace("'", "’"); //"%27");
            label = label.Replace("'", "’"); //"%27");

            var innerText = string.Empty;
            switch (type.ToLowerSafe())
            {
                case "query":
                    sb.AppendFormat("<a title='Search: {0}' href='/LotR/Search?Query={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "search":
                    sb.AppendFormat("<a title='Search: {0}' href='/LotR/Search?{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "card":
                    sb.AppendFormat("<a title='Card: {0}' href='/LotR/Details/{1}' target='_blank'>{0}</a>", label, key.Replace("%27", "&#39;"));
                    break;
                case "title":
                    sb.AppendFormat("<a title='Search: {0} Title' href='/LotR/Search?Query=%2Btitle%3A{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "title-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/LotR/Search?Query=%2Btitle%3A{1}&CardType=Hero' target='_blank'>{0}</a>", label, key);
                    break;
                case "self":
                    //sb.AppendFormat("<a title='Card: {0}' href='/LotR/Details/{1}' target='_blank'>{0}</a>", label, key);
                    sb.Append(label);
                    break;
                case "trait":
                    sb.AppendFormat("<a title='Search: {0} Trait' href='/LotR/Search?Trait={1}&Lang={2}' target='_blank'><b><i>{0}</i></b></a>", label, key, lang);
                    break;
                case "trait-search":
                    sb.AppendFormat("<a title='Search: {0}' href='/LotR/Search?{1}' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/LotR/Search?Trait={1}&CardType=Character' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-attachment":
                    sb.AppendFormat("<a title='Search: {0} Attachment' href='/LotR/Search?Trait={1}&CardType=Attachment' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "unique-trait-character":
                    sb.AppendFormat("<a title='Search: Unique {0} Character' href='/LotR/Search?Trait={1}&CardType=Character&IsUnique=Yes' target='_blank'>unique <b><i>{0}</i></b> character</a>", label, key);
                    break;
                case "trait-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/LotR/Search?Trait={1}&CardType=Hero' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "traits-character":
                    {
                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Character' href='/LotR/Search?Query=%2Btrait%3A{2}&CardType=Character' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> character</a>", trait1, trait2, key);
                    }
                    break;
                case "traits-hero":
                    {
                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Hero' href='/LotR/Search?Query=%2Btrait%3A{2}&CardType=Hero' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> hero</a>", trait1, trait2, key);
                    }
                    break;
                case "traits-attachment":
                    {
                        if (string.IsNullOrEmpty(label))
                        {
                            label = "attachment";
                        }
                        var join = "or";
                        if (label == "attachments")
                        {
                            join = "and";
                        }

                        var traits = key.SplitOn(',');
                        var trait1 = string.Empty;
                        var trait2 = string.Empty;
                        if (traits.Count == 2)
                        {
                            trait1 = traits[0];
                            trait2 = traits[1];
                        }
                        sb.AppendFormat("<a title='Search: {0} or {1} Attachment' href='/LotR/Search?Query=%2Btrait%3A{2}&CardType=Attachment' target='_blank'><b><i>{0}</i></b> {4} <b><i>{1}</i></b> {3}</a>", trait1, trait2, key, label, join);
                    }
                    break;
                case "trait-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/LotR/Search?Trait={1}&CardType=Ally' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-location":
                    sb.AppendFormat("<a title='Search: {0} Location' href='/LotR/Search?Trait={1}&CardType=Location' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "keyword":
                    sb.AppendFormat("<a title='Search: {0} Keyword' href='/LotR/Search?Keyword={1}&Lang={2}' target='_blank'>{0}</a>", label, key, lang);
                    break;
                case "keyword-hero":
                    sb.AppendFormat("<a title='Search: Hero with {0} Keyword' href='/LotR/Search?Keyword={1}&CardType=Hero&Lang={2}' target='_blank'>hero with {0}</a>", label, key, lang);
                    break;
                case "type":
                    sb.AppendFormat("<a title='Search: {0} Type' href='/LotR/Search?CardType={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "sphere":
                    sb.AppendFormat("<a title='Search: {0} Sphere' href='/LotR/Search?Sphere={0}' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /></a>", key);
                    break;
                case "sphere-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/LotR/Search?Sphere={0}&CardType=Character' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> character</a>", key);
                    break;
                case "sphere-hero":
                    innerText = (!string.IsNullOrEmpty(label) && label == "!") ? string.Empty : " hero";
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/LotR/Search?Sphere={0}&CardType=Hero' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' />{1}</a>", key, innerText);
                    break;
                case "sphere-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/LotR/Search?Sphere={0}&CardType=Ally' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> ally</a>", key);
                    break;
                case "sphere-event":
                    sb.AppendFormat("<a title='Search: {0} Event' href='/LotR/Search?Sphere={0}&CardType=Event' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> event</a>", key);
                    break;
                case "willpower":
                    sb.Append("<img src='/Images/willpower-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "threat":
                    sb.Append("<img src='/Images/threat-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "attack":
                    sb.Append("<img src='/Images/attack-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "defense":
                    sb.Append("<img src='/Images/defense-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "perplayer":
                    sb.Append("<img src='/Images/PerPlayer.png' style='height:16px;margin-left:0px;margin-right:2px;margin-bottom:-1px;' />");
                    break;
                case "victory":
                    sb.AppendFormat("<div class='victory-text'><a style='text-decoration:none;' href='/LotR/Search?VictoryPoints=Victory+{0}.' target='_blank' title='Victory: {0}'><span style='padding-left:4px;padding-right:4px;border-style:solid;border-width:1px;border-color:black;'>Victory {0}</span></a></div>", key);
                    break;
                case "cave":
                    sb.AppendFormat("<div class='victory-text'><a style='text-decoration:none;' href='/LotR/Details/{0}-TGC' target='_blank' title='{1} Cave'><span style='padding-left:4px;padding-right:4px;border-style:solid;border-width:1px;border-color:black;'>{1}</span></a></div>", key.Replace(" ", "-"), key);
                    break;
                case "pass":
                    sb.Append("<div class='pass-text'><b>PASS</b></div>");
                    break;
                case "shadow":
                    sb.Append("<img src='/Images/ShadowDivider.png' title='Shadow Effect' style='display:block;margin-left:auto;margin-right:auto;width:285px;'/>");
                    break;
                case "sailing-success":
                    sb.Append("<div class='sailing-success'><img src='/Images/sailing-success.png' title='Sailing Test Success'/></div>");
                    break;
                case "sailing-success2":
                    sb.Append("<div class='sailing-success'><img src='/Images/sailing-success.png' title='Sailing Test Success'/><img src='/Images/sailing-success.png' title='Sailing Test Success'/></div>");
                    break;
                case "sailing-success-small":
                    sb.Append("<img style='height:15px; width:15px; margin-bottom:-2px;' src='/Images/sailing-success.png' title='Sailing Test Success'/>");
                    break;
                case "heading-sunny":
                    sb.Append("<img class='heading-icon heading-sunny-icon' src='/Images/heading-sunny.png' title='Sunny Heading' />");
                    break;
                case "heading-cloudy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-cloudy.png' title='Cloudy Heading' />");
                    break;
                case "heading-rainy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-rainy.png' title='Rainy Heading' />");
                    break;
                case "heading-stormy":
                    sb.Append("<img class='heading-icon' src='/Images/heading-stormy.png' title='Stormy Heading' />");
                    break;
                case "heading-sunny2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-sunny2.png' title='Sunny Heading' />");
                    break;
                case "heading-cloudy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-cloudy2.png' title='Cloudy Heading' />");
                    break;
                case "heading-rainy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-rainy2.png' title='Rainy Heading' />");
                    break;
                case "heading-stormy2":
                    sb.Append("<img class='heading-icon' src='/Images/heading-stormy2.png' title='Stormy Heading' />");
                    break;
                case "compass-rose":
                    sb.Append("<img src='/Images/compass-rose.png'/>");
                    break;
                default:
                    sb.Append("<p>UNRECOGNIZED TYPE: " + type.ToLowerSafe() + "</p>");
                    break;
            }
        }

        public string RenderFrontHtml(Language lang)
        {
            return RenderHtml(card.HtmlTemplate, lang, false);
        }

        public string RenderBackHtml(Language lang)
        {
            return RenderHtml(card.HtmlTemplate2, lang, false);
        }

        public string RenderFrontDiscordMarkup(Language lang)
        {
            return RenderHtml(card.HtmlTemplate, lang, true);
        }

        public string RenderBackDiscordMarkup(Language lang)
        {
            return RenderHtml(card.HtmlTemplate2, lang, true);
        }
    }
}
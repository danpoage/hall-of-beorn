using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Services.LotR.Stats;

namespace HallOfBeorn.Models.LotR
{
    public class CardEffect
    {
        private readonly List<Token> tokens = new List<Token>();

        public bool IsCritical { get; set; }
        
        public List<Token> Tokens
        {
            get { return tokens; }
        }

        public string GetText(string title)
        {
            if (tokens.Count == 0)
                return string.Empty;

            var text = new System.Text.StringBuilder();

            foreach (var token in tokens)
            {
                if (token.IsTitleReference)
                    text.AppendFormat(" {0}", title);
                else if (token.IsIcon)
                    text.AppendFormat(" {0}", token.Text);
                    //"<img src='{0}' style='height:16px;margin-left:2px;margin-right:-4px;margin-bottom:-2px;' />", token.ImagePath);
                else
                    text.Append(token.Text);
            }

            return text.ToString();
        }

        public string GetIconPath()
        {
            var icon = tokens.Where(t => t.IsIcon).FirstOrDefault();

            return icon != null ? icon.ImagePath : string.Empty;
        }

        public string GetIconPrefix(string title)
        {
            if (!tokens.Any(t => t.IsIcon))
                return GetText(title);

            var text = new System.Text.StringBuilder();

            foreach (var token in tokens)
            {
                if (token.IsIcon)
                    break;
                else
                    text.Append(token.Text);
            }

            return text.ToString();
        }

        public string GetIconSuffix(string title)
        {
            if (!tokens.Any(t => t.IsIcon))
                return GetText(title);

            var text = new System.Text.StringBuilder();

            var afterIcon = false;

            foreach (var token in tokens)
            {
                if (token.IsIcon)
                    afterIcon = true;
                else if (afterIcon)
                    text.Append(token.Text);
            }

            return text.ToString();
        }

        private static void checkForSuffix(Token token, string part, string normalized)
        {
            if (part.Length > normalized.Length)
            {
                var prefixLength = part.StartsWith("(") ? 1 : 0;
                var suffixLength = part.Length - normalized.Length - prefixLength;
                token.Suffix = part.Substring(part.Length - suffixLength, suffixLength);
            }
        }

        private static void checkForTitleReference(Token token, string part)
        {
            const string titleTag = "[Card]";

            if (part.Contains(titleTag))
            {
                token.IsTitleReference = true;

                if (part.Length > titleTag.Length && !part.EndsWith("]"))
                {
                    token.Text = part.Substring(0, titleTag.Length);
                    token.Suffix = part.Substring(titleTag.Length, part.Length - titleTag.Length);
                }
                else
                {
                    token.Text = part;
                }
            }
        }

        private static string getImagePath(string normalized)
        {
            if (normalized == null)
                return null;

            switch (normalized)
            {
                case "Willpower":
                    return "/Images/willpower-small.png";
                case "Attack":
                    return "/Images/attack-small.png";
                case "Defense":
                    return "/Images/defense-small.png";
                case "Threat":
                    return "/Images/threat-small.png";
                case "Leadership":
                    return "/Images/Leadership.png";
                case "Tactics":
                    return "/Images/Tactics.png";
                case "Spirit":
                    return "/Images/Spirit.png";
                case "Lore":
                    return "/Images/Lore.png";
                case "Baggins":
                    return "/Images/Baggins.png";
                case "Fellowship":
                    return "/Images/Fellowship.png";
                case "PerPlayer":
                    return "/Images/PerPlayer.png";
                default:
                    return null;
            }
        }

        private static List<string> strongPhrases = new List<string> {
            "lost the game",
            "lose the game",
            "win the game",
            "won the game",
            "end the game",
            "win this game",
            "the players cannot"
        };

        public static CardEffect Parse(IStatService statService, LotRCard card, string text, Language? lang)
        {
            if (text == null)
                return null;

            var effect = new CardEffect();

            var count = 0;
            foreach (var part in text.Split(' '))
            {
                if (string.IsNullOrEmpty(part))
                    continue;

                count++;

                var token = new Token();
                var partText = part;

                var normalized = part.TrimStart('(').TrimEnd('.', ',', ':', '"', '\'', ')');
                var escaped = part.StartsWith("~");

                if (part.Length > 0 && part.EndsWith(":") && char.IsUpper(part.GetFirstLetter()))
                {
                    token.IsTrigger = true;
                    token.Text = part;

                    if (count == 2)
                    {
                        effect.Tokens.First().IsTrigger = true;
                    }

                    checkForTitleReference(token, part);
                }
                else
                {
                    token.Prefix = count > 1 ? " " : string.Empty;

                    var statNames = new List<string> { "Attack", "Defense" };

                    if (!escaped && !statNames.Contains(normalized))
                    {
                        //NOTE: A Sphere token has priority over a Trait token
                        if (statService.Traits(lang).Any(x => string.Equals(x, normalized + ".")) && !statService.Spheres().Any(x => string.Equals(x, normalized)))
                        {
                            token.IsTrait = true;
                            token.Text = token.Prefix + part.Trim(',');
                            checkForSuffix(token, part, normalized);
                            effect.Tokens.Add(token);
                            continue;
                        }
                    }

                    token.ImagePath = getImagePath(normalized);
                    if (token.IsIcon)
                    {
                        if (part.StartsWith("("))
                            token.Prefix = token.Prefix + "(";

                        token.Text = normalized;
                        checkForSuffix(token, part, normalized);
                        effect.Tokens.Add(token);
                        continue;
                    }
                    else if (part.StartsWith("**") && part.EndsWith("**"))
                    {
                        token.IsStrong = true;
                        partText = part.Replace("**", string.Empty);
                    }
                    else if (part.StartsWith("*") && part.EndsWith("*"))
                    {
                        token.IsEmphasized = true;
                        partText = part.Trim('*');
                    }

                    token.Text = token.Prefix + partText.TrimStart('~');
                }

                checkForTitleReference(token, partText);

                effect.Tokens.Add(token);
            }

            foreach (var phrase in strongPhrases)
            {
                if (text.ToLower().Contains(phrase))
                {
                    if (!effect.Tokens[0].IsTrigger)
                    {
                        effect.IsCritical = true;
                    }
                }
            }

            return effect;
        }
    }
}
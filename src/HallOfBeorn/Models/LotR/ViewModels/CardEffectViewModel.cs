using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    /*
    public class CardEffectViewModel
    {
        public string Prefix { get; set; }
        public bool IsCritical { get; set; }
        public bool HasPrefix { get { return !string.IsNullOrEmpty(Prefix); } }
        public bool IsShadow { get { return Prefix == "Shadow"; } }
        public string Text { get; set; }

        private static readonly string[] IconWords = new string[] { " Threat", " Willpower", " Attack", " Defense", " Leadership", " Tactics", " Spirit", " Lore" };

        public bool HasIcon()
        {
            if (string.IsNullOrEmpty(Text))
                return false;

            foreach (var word in IconWords)
                if (Text.Contains(word))
                    return true;

            return false;
        }

        public IEnumerable<string> GetTokens()
        {
            if (string.IsNullOrEmpty(Text))
                return Enumerable.Empty<string>();

            var tokens = new List<string>();

            foreach (var item in Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                tokens.Add(string.Format("{0} ", item));
            }

            return tokens;
        }
    }
     * */
}
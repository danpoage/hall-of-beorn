using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public enum Keyword
    {
        Doomed_1,
        Doomed_2,
        Ranged,
        Sentinel,
        Surge,
    }

    public static class KeywordExtensions
    {
        private static readonly Dictionary<string, Keyword?> enMap = new Dictionary<string, Keyword?>
        {
            { "Sentinel.", Keyword.Sentinel }
        };

        public static Keyword? ParseKeyword(this string self, Language lang)
        {
            var map = lang == Language.EN
                ? enMap
                : null;

            return map != null && map.ContainsKey(self)
                ? map[self]
                : null;
        }
    }
}

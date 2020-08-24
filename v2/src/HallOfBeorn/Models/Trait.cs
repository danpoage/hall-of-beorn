using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public enum Trait
    {
        None = 0,
        Dunedain,
        Noble,
        Ranger,
    }
    
    public static class TraitExtensions
    {
        private static readonly Dictionary<string, Trait?> enMap = new Dictionary<string, Trait?>
        {
            { "Noble.", Trait.Noble },
            { "Ranger.", Trait.Ranger  },
        };

        public static Trait? ParseTrait(this string self, Language lang)
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

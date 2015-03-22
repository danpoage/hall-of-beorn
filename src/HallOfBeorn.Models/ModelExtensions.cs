using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public static class ModelExtensions
    {
        public static string Normalize(this string self)
        {
            if (string.IsNullOrEmpty(self)) {
                return self;
            }

            var tokensToNormalize = new Dictionary<string, string> {
                {"À", "A"}, {"Â", "A"}, {"Á", "A"}, {"Æ", "AE"}, {"Ǣ", "AE"}, {"Å", "A"},
                {"à", "A"}, {"â", "A"}, {"á", "A"}, {"æ", "AE"}, {"ǣ", "AE"}, {"ā", "A"},

                {"Ç", "C"},
                {"č", "C"},

                {"Ð", "D"},
                {"ð", "D"}, 

                {"È", "E"}, {"Ê", "E"}, {"Ë", "E"}, {"É", "E"},
                {"è", "E"}, {"ê", "E"}, {"ë", "E"}, {"ē", "E"}, {"é", "E"},

                {"Ğ", "G"}, {"ѓ", "G"},
                {"ģ", "G"}, {"ǧ", "G"},

                {"ȟ", "H"},

                {"Ï", "I"}, {"Î", "I"}, {"Í", "I"}, {"İ", "I"}, {"й", "I"}, {"ѝ", "I"},
                {"ï", "I"}, {"î", "I"}, {"ī", "I"}, {"í", "I"},
                
                {"ќ", "K"},
                {"ķ", "K"},

                {"ļ", "L"},

                {"Ñ", "N"},
                {"ñ", "N"}, {"ņ", "N"}, {"ŋ", "N"},

                {"Ô", "O"}, {"Ö", "O"}, {"Ó", "O"},
                {"ô", "O"}, {"ö", "O"}, {"ø", "O"}, {"ó", "O"}, {"õ", "O"},
                
                {"ŗ", "R"},

                {"Ş", "S"},
                {"š", "S"},

                {"Û", "U"}, {"Ù", "U"}, {"Ú", "U"}, {"Ü", "U"},
                {"û", "U"}, {"ù", "U"}, {"ū", "U"}, {"ú", "U"},
                
                {"ў", "U"},
                {"ž", "Z"}
            };

            var normalized = self;
            foreach (var pair in tokensToNormalize)
            {
                normalized = normalized.Replace(pair.Key, pair.Value);
            }
            return normalized;
        }

        public static Name ToName(this Keyword self)
        {
            var value = self != Keyword.None ? self.ToString().Replace('_', ' ') : string.Empty;

            return new Name(value);
        }

        public static Name ToName(this Trait self)
        {
            var value = self != Trait.None ? self.ToString().Replace("__", "-").Replace('_', ' ') : string.Empty;

            return new Name(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn
{
    public static class Extensions
    {
        public static string ToUrlSafeString(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return string.Empty;

            return self.Replace(" - ", "-")
                .Replace(' ', '-')
                .Replace('_', '-')
                .Replace("&", "and")
                .Replace(".", string.Empty)
                .Replace(",", string.Empty)
                .Replace(":", string.Empty)
                .Replace("?", string.Empty)
                .Replace("!", string.Empty)
                .Replace("\"", string.Empty);
        }

        public static string UrlEncode(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return string.Empty;

            return HttpUtility.UrlEncode(self);
        }

        public static string ToDisplayString(this string self, string title)
        {
            if (string.IsNullOrEmpty(self))
                return string.Empty;

            return self
                .Replace("~", string.Empty)
                .Replace("[Card]", title);
        }

        public static string ToSearchString(this string value)
        {
            return value.Replace(' ', '+').Replace("!", string.Empty).Replace("?", string.Empty);
        }

        public static string ToSlug(this string value)
        {
            return (string.IsNullOrEmpty(value))
                ? string.Empty
                : value.Replace(" ", "-");
        }

        public static string ToEnumDisplayString<T>(this T self)
        {
            if (typeof(T) == typeof(Models.NumericOperator))
            {
                var op = (Models.NumericOperator)((object)self);
                switch (op)
                {
                    default:
                    case Models.NumericOperator.eq:
                        return " = ";
                    case Models.NumericOperator.gt:
                        return " > ";
                    case Models.NumericOperator.gteq:
                        return " >= ";
                    case Models.NumericOperator.lt:
                        return " < ";
                    case Models.NumericOperator.lteq:
                        return " <= ";
                }
            }
            else
            {
                return self.ToString().Replace('_', ' ');
            }
        }

        public static IEnumerable<SelectListItem> GetSelectListItems<T>(this Type enumType, Func<T, string> mapFunction)
            where T: struct
        {
            var listItems = new List<SelectListItem>();

            foreach (var item in System.Enum.GetValues(enumType))
            {
                var number = (int)item;
                var text = mapFunction((T)item);
                var value = item.ToString();

                listItems.Add(
                    new SelectListItem()
                    {
                        Text = text,
                        Value = value
                    }
                );
            }

            return listItems;
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType)
        {
            return enumType.GetSelectListItems(" ", false);
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, Tuple<string, string> topItem)
        {
            return enumType.GetSelectListItems(" ", false, topItem);
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, string separator)
        {
            return enumType.GetSelectListItems(separator, false);
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, string separator, bool keepZero)
        {
            return enumType.GetSelectListItems(separator, false, null);
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, string separator, bool keepZero, Tuple<string, string> topItem)
        {
            var listItems = new List<SelectListItem>();

            foreach (var item in System.Enum.GetValues(enumType))
            {
                var number = (int)item;
                var text = string.Empty;

                if (number == 0) {
                    text = keepZero ? item.ToString().Replace("_", separator) : "Any";
                }
                else {
                    text = item.ToString()
                        .Replace("1_", "1.")
                        .Replace("2_", "2.")
                        .Replace("_", separator);
                }

                var value = item.ToString();

                listItems.Add(
                    new SelectListItem()
                    {
                        Text = text,
                        Value = value
                    }
                );
            }

            if (topItem != null && listItems.Count > 1) {
                listItems.Insert(1, new SelectListItem { Selected = false, Text = topItem.Item1, Value = topItem.Item2 });
            }

            return listItems;
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this IEnumerable<string> list)
        {
            var listItems = new List<SelectListItem>() { new SelectListItem { Selected = true, Text = "Any", Value = "Any" } };

            foreach (var item in list)
            {
                listItems.Add(
                    new SelectListItem()
                    {
                        Text = item.Replace(".", string.Empty),
                        Value = item
                    }
                );
            }

            return listItems;
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this IEnumerable<string> list, Tuple<string,string> topItem)
        {
            var listItems = new List<SelectListItem>() { new SelectListItem { Selected = true, Text = "Any", Value = "Any" } };

            if (topItem != null)
            {
                listItems.Add(new SelectListItem { Selected = false, Text = topItem.Item1, Value = topItem.Item2 });
            }

            foreach (var item in list)
            {
                listItems.Add(
                    new SelectListItem()
                    {
                        Text = item.Replace(".", string.Empty),
                        Value = item
                    }
                );
            }

            return listItems;
        }

        public static IEnumerable<SelectListItemExtends> GetExtendedSelectListItems(this IEnumerable<string> list)
        {
            var listItems = new List<SelectListItemExtends>() { new SelectListItemExtends() { Selected = true, Text = "Any", Value = "Any", Enabled = true } };

            foreach (var item in list)
            {
                var selectItem = new SelectListItemExtends()
                    {
                        Text = item.Replace(".", string.Empty),
                        Value = item,
                        Enabled = true
                    };

                if (item.Contains("———"))
                {
                    selectItem.Enabled = false;
                }

                listItems.Add(selectItem);
            }

            return listItems;
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this IEnumerable<byte> list)
        {
            var listItems = new List<SelectListItem>() { new SelectListItem() { Selected = true, Text = "Any", Value = "-1" } };

            foreach (var item in list)
            {
                listItems.Add(
                    new SelectListItem()
                    {
                        Text = item.ToString(),
                        Value = item.ToString()
                    }
                );
            }

            return listItems;
        }

        // Returns the first letter in a string, or a space if there are no letters in the given string
        public static char GetFirstLetter(this string self)
        {
            if (!string.IsNullOrEmpty(self))
            {
                for (var i = 0; i < self.Length; i++)
                {
                    if (char.IsLetter(self[i]))
                        return self[i];
                }
            }

            return ' ';
        }

        public static bool MatchesPattern(this string self, string pattern)
        {
            if (string.IsNullOrEmpty(self))
                return false;

            return Regex.IsMatch(self, pattern, RegexOptions.IgnoreCase);
        }

        public static List<T> ToListSafe<T>(this IEnumerable<T> self)
        {
            if (self == null)
                return new List<T>();

            return self.ToList();
        }

        public static string ToListString<T>(this IEnumerable<T> self)
        {
            return self.ToListString(" ");
        }

        public static string ToListString<T>(this IEnumerable<T> self, string separator)
        {
            if (self == null || self.Count() == 0)
            {
                return string.Empty;
            }

            return string.Join(separator, self.Select(x => x.ToString()));
        }

        public static TEnum ToEnum<TEnum>(this object self) where TEnum: struct
        {
            if (self == null)
                return default(TEnum);

            return (TEnum)self;
        }

        public static List<string> SplitOn(this string self, char separator)
        {
            if (string.IsNullOrEmpty(self))
                return new List<string>();

            return self.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();
        }

        public static List<string> SplitLines(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return new List<string>();

            return self.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();
        }

        public static List<string> SplitOnSpace(this string self)
        {
            return self.SplitOn(' ');
        }

        public static List<string> SplitOnComma(this string self)
        {
            return self.SplitOn(',');
        }

        public static List<string> SplitOnCommaOrPipe(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return new List<string>();

            return self.Split(new char[] { ',', '|' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();
        }

        public static List<string> SplitOnEquals(this string self)
        {
            return self.SplitOn('=');
        }

        //public static bool IsDefined(this string self)
        //{
        //    return !string.IsNullOrEmpty(self);
        //}

        public static string ToLowerSafe(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return string.Empty;

            return self.ToLower();
        }

        public static bool IsEqualToLower(this string self, string other)
        {
            return self.ToLowerSafe() == other.ToLowerSafe();
        }

        public static bool StartsWithLower(this string self, string other)
        {
            return self.ToLowerSafe().StartsWith(other.ToLowerSafe());
        }

        public static bool ContainsLower(this string self, string other)
        {
            return self.ToLowerSafe().Contains(other.ToLowerSafe());
        }

        public static bool MatchesWildcard(this string self, string pattern)
        {
            if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(pattern))
                return false;

            var prefix = pattern.StartsWith("*");
            var suffix = pattern.EndsWith("*");

            pattern = pattern.Trim('*');

            if (prefix && suffix)
            {
                return self.ToLower().Contains(pattern.ToLower());
            }
            else if (prefix)
            {
                return self.ToLower().EndsWith(pattern.ToLower());
            }
            else if (suffix)
            {
                return self.ToLower().StartsWith(pattern.ToLower());
            }

            return self.ToLower() == pattern.ToLower();
        }

        public static Tuple<TEnum, bool> ParseEnum<TEnum>(this string self)
            where TEnum: struct
        {
            var item = default(TEnum);

            if (string.IsNullOrEmpty(self))
                return new Tuple<TEnum, bool>(item, false);

            var name = self.Replace('-', '_').Replace('+', '_');

            var valid = Enum.TryParse<TEnum>(name, true, out item);

            return new Tuple<TEnum, bool>(item, valid);
        }

        public static bool IsDefinedFilter(this string self)
        {
            return !(string.IsNullOrEmpty(self) || self == HallOfBeorn.Models.LotR.ViewModels.SearchViewModel.DEFAULT_FILTER_VALUE);
        }

        public static bool CompareTo(this byte? self, HallOfBeorn.Models.NumericOperator? op, string other)
        {
            if (!self.HasValue || !op.HasValue) {
                return false;
            }

            return self.Value.CompareTo(op.Value, other);
        }

        public static bool CompareTo(this byte self, HallOfBeorn.Models.NumericOperator op, string other)
        {
            byte result = 0;
            if (!byte.TryParse(other, out result)) {
                return false;
            }

            switch (op)
            {
                case Models.NumericOperator.eq:
                default:
                    return self == result;
                case Models.NumericOperator.gt:
                    return self > result;
                case Models.NumericOperator.gteq:
                    return self >= result;
                case Models.NumericOperator.lt:
                    return self < result;
                case Models.NumericOperator.lteq:
                    return self <= result;
            }
        }

        public static bool IsX(this byte? self)
        {
            return self.HasValue && self.Value == 254;
        }

        public static bool IsNA(this byte? self)
        {
            return self.HasValue && self.Value == 255;
        }

        public static bool IsDefined(this byte? self)
        {
            return self.HasValue && self.Value < 254;
        }

        public static string Description(this byte? self)
        {
            return self.Description(self != null && self == 254, "-");
        }

        public static string Description(this byte? self, bool isVariable)
        {
            return self.Description(isVariable, string.Empty);
        }

        public static string Description(this byte? self, bool isVariable, string defaultValue)
        {
            if (isVariable)
            {
                return "X";
            }

            if (!self.HasValue)
            {
                return defaultValue;
            }

            return self.Value == byte.MaxValue ? "-" : self.Value.ToString();
        }

        private static Dictionary<string, string> getNormalizeMap()
        {
            return new Dictionary<string, string> {
                {"À", "A"}, {"Â", "A"}, {"Á", "A"}, {"Æ", "AE"}, {"Ǣ", "AE"}, {"Å", "A"}, {"Ä", "A"},
                {"à", "A"}, {"â", "A"}, {"á", "A"}, {"æ", "AE"}, {"ǣ", "AE"}, {"ā", "A"}, {"ä", "A"},

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
                {"ž", "Z"},

                {",", string.Empty }
            };
        }

        private static Dictionary<string, string> getCaseSensitiveNormalizeMap()
        {
            return new Dictionary<string, string> {
                {"À", "A"}, {"Â", "A"}, {"Á", "A"}, {"Æ", "AE"}, {"Ǣ", "AE"}, {"Å", "A"}, {"Ä", "A"},
                {"à", "a"}, {"â", "a"}, {"á", "a"}, {"æ", "ae"}, {"ǣ", "ae"}, {"ā", "a"}, {"ä", "a"},

                {"Ç", "C"},
                {"č", "c"},

                {"Ð", "D"},
                {"ð", "d"}, 

                {"È", "E"}, {"Ê", "E"}, {"Ë", "E"}, {"É", "E"},
                {"è", "e"}, {"ê", "e"}, {"ë", "e"}, {"ē", "e"}, {"é", "e"},

                {"Ğ", "G"}, {"ѓ", "G"},
                {"ģ", "g"}, {"ǧ", "g"},

                {"ȟ", "h"},

                {"Ï", "I"}, {"Î", "I"}, {"Í", "I"}, {"İ", "I"}, {"й", "I"}, {"ѝ", "I"},
                {"ï", "i"}, {"î", "i"}, {"ī", "i"}, {"í", "i"},
                
                {"ќ", "K"},
                {"ķ", "k"},

                {"ļ", "l"},

                {"Ñ", "N"},
                {"ñ", "n"}, {"ņ", "n"}, {"ŋ", "n"},

                {"Ô", "O"}, {"Ö", "O"}, {"Ó", "O"},
                {"ô", "o"}, {"ö", "o"}, {"ø", "o"}, {"ó", "o"}, {"õ", "o"},
                
                {"ŗ", "r"},

                {"Ş", "S"},
                {"š", "s"},

                {"Û", "U"}, {"Ù", "U"}, {"Ú", "U"}, {"Ü", "U"},
                {"û", "u"}, {"ù", "u"}, {"ū", "u"}, {"ú", "u"},
                
                {"ў", "u"},
                {"ž", "z"},

                {",", string.Empty }
            };
        }

        public static string NormalizeString(this string self)
        {
            if (string.IsNullOrEmpty(self))
            {
                return self;
            }

            var tokensToNormalize = getNormalizeMap();

            var normalized = self;
            foreach (var pair in tokensToNormalize)
            {
                normalized = normalized.Replace(pair.Key, pair.Value);
            }
            return normalized;
        }

        public static string NormalizeCaseSensitiveString(this string self)
        {
            if (string.IsNullOrEmpty(self))
            {
                return self;
            }

            var tokensToNormalize = getCaseSensitiveNormalizeMap();

            var normalized = self;
            foreach (var pair in tokensToNormalize)
            {
                normalized = normalized.Replace(pair.Key, pair.Value);
            }
            return normalized;
        }

        public static string Name(this Models.Keyword self)
        {
            return self != Models.Keyword.None ? self.ToString().Replace('_', ' ') : string.Empty;
        }

        public static string Name(this Models.Trait self)
        {
            return self != Models.Trait.None ? self.ToString().Replace("__", "-").Replace('_', ' ') : string.Empty;
        }

        public static bool TextMatches(this Models.LotR.LotRCard self, string pattern)
        {
            return self.Text.ToLowerSafe().MatchesPattern(pattern) || self.OppositeText.ToLowerSafe().MatchesPattern(pattern);
        }

        public static byte[] ToByteArray(this string self)
        {
            if (string.IsNullOrEmpty(self))
            {
                return new byte[0];
            }

            return System.Text.Encoding.UTF8.GetBytes(self);
        }

        public static string[] SafeSplit(this string self, params char[] separator)
        {
            if (string.IsNullOrEmpty(self))
            {
                return new string[0];
            }

            return self.Split(separator);
        }

        public static string Slugify(this string self)
        {
            return string.IsNullOrEmpty(self) ? string.Empty : self.NormalizeCaseSensitiveString().ToUrlSafeString();
        }

        public static bool IsDefined(this string self)
        {
            return !string.IsNullOrWhiteSpace(self) && self != "Any";
        }

        public static void SafeAddForKey<K, V>(this Dictionary<K, List<V>> self, K key, V item)
        {
            if (!self.ContainsKey(key))
                self[key] = new List<V>();

            self[key].Add(item);
        }

        public static void SafeAddRangeForKey<K, V>(this Dictionary<K, List<V>> self, K key, IEnumerable<V> items)
        {
            if (!self.ContainsKey(key))
                self[key] = new List<V>();

            foreach (var item in items)
            {
                if (self[key].Contains(item))
                    continue;

                self[key].Add(item);
            }
        }
    }
}
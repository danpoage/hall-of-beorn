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
        public static string ProductRepositoryKey = "productRepository";
        public static string CardRepositoryKey = "cardRepository";

        public static string CategoryServiceKey = "categoryService";
        public static string NoteServiceKey = "noteService";
        public static string ScenarioServiceKey = "scenarioService";
        public static string SearchServiceKey = "searchService";
        public static string StatServiceKey = "statService";
        public static string OctgnServiceKey = "octgnService";
        public static string RingsDbKey = "ringsDBService";
        public static string TagServiceKey = "tagService";
        public static string TemplateServiceKey = "templateService";

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
                    text = item.ToString().Replace("1_", "1.").Replace("_", separator);
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

        public static bool IsDefined(this string self)
        {
            return !string.IsNullOrEmpty(self);
        }

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

            return self.Value == byte.MaxValue ? "–" : self.Value.ToString();
        }

        private static Dictionary<string, string> getNormalizeMap()
        {
            return new Dictionary<string, string> {
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
                {"ž", "Z"},

                {",", string.Empty }
            };
        }

        private static Dictionary<string, string> getCaseSensitiveNormalizeMap()
        {
            return new Dictionary<string, string> {
                {"À", "A"}, {"Â", "A"}, {"Á", "A"}, {"Æ", "AE"}, {"Ǣ", "AE"}, {"Å", "A"},
                {"à", "a"}, {"â", "a"}, {"á", "a"}, {"æ", "ae"}, {"ǣ", "ae"}, {"ā", "a"},

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

        public static string Render(this string template, string slug, string title)
        {
            if (string.IsNullOrEmpty(template))
            {
                return string.Empty;
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
                                        key = slug;
                                    }
                                    if (string.IsNullOrEmpty(label))
                                    {
                                        label = title;
                                    }
                                }

                                insertToken(s, type, key, label);
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

            return s.ToString();
        }

        private static void insertToken(StringBuilder sb, string type, string key, string label)
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

            key = key.Replace("'", "%27");
            label = label.Replace("'", "%27");

            var innerText = string.Empty;
            switch (type.ToLowerSafe())
            {
                case "query":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?Query={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "search":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "card":
                    sb.AppendFormat("<a title='Card: {0}' href='/Cards/Details/{1}' target='_blank'>{0}</a>", label, key.Replace("%27", "&#39;"));
                    break;
                case "title":
                    sb.AppendFormat("<a title='Search: {0} Title' href='/Cards/Search?Query=%2Btitle%3A{1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "title-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Query=%2Btitle%3A{1}&CardType=Hero' target='_blank'>{0}</a>", label, key);
                    break;
                case "self":
                    //sb.AppendFormat("<a title='Card: {0}' href='/Cards/Details/{1}' target='_blank'>{0}</a>", label, key);
                    sb.AppendFormat(label.Replace("%27", "'"));
                    break;
                case "trait":
                    sb.AppendFormat("<a title='Search: {0} Trait' href='/Cards/Search?Trait={1}' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-search":
                    sb.AppendFormat("<a title='Search: {0}' href='/Cards/Search?{1}' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/Cards/Search?Trait={1}&CardType=Character' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-attachment":
                    sb.AppendFormat("<a title='Search: {0} Attachment' href='/Cards/Search?Trait={1}&CardType=Attachment' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "unique-trait-character":
                    sb.AppendFormat("<a title='Search: Unique {0} Character' href='/Cards/Search?Trait={1}&CardType=Character&IsUnique=Yes' target='_blank'>unique <b><i>{0}</i></b> character</a>", label, key);
                    break;
                case "trait-hero":
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Trait={1}&CardType=Hero' target='_blank'><b><i>{0}</i></b></a>", label, key);
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
                        sb.AppendFormat("<a title='Search: {0} or {1} Character' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Character' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> character</a>", trait1, trait2, key);
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
                        sb.AppendFormat("<a title='Search: {0} or {1} Hero' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Hero' target='_blank'><b><i>{0}</i></b> or <b><i>{1}</i></b> hero</a>", trait1, trait2, key);
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
                        sb.AppendFormat("<a title='Search: {0} or {1} Attachment' href='/Cards/Search?Query=%2Btrait%3A{2}&CardType=Attachment' target='_blank'><b><i>{0}</i></b> {4} <b><i>{1}</i></b> {3}</a>", trait1, trait2, key, label, join);
                    }
                    break;
                case "trait-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/Cards/Search?Trait={1}&CardType=Ally' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "trait-location":
                    sb.AppendFormat("<a title='Search: {0} Location' href='/Cards/Search?Trait={1}&CardType=Location' target='_blank'><b><i>{0}</i></b></a>", label, key);
                    break;
                case "keyword":
                    sb.AppendFormat("<a title='Search: {0} Keyword' href='/Cards/Search?Keyword={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "keyword-hero":
                    sb.AppendFormat("<a title='Search: Hero with {0} Keyword' href='/Cards/Search?Keyword={1}&CardType=Hero' target='_blank'>hero with {0}</a>", label, key);
                    break;
                case "type":
                    sb.AppendFormat("<a title='Search: {0} Type' href='/Cards/Search?CardType={1}' target='_blank'>{0}</a>", label, key);
                    break;
                case "sphere":
                    sb.AppendFormat("<a title='Search: {0} Sphere' href='/Cards/Search?Sphere={0}' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /></a>", key);
                    break;
                case "sphere-character":
                    sb.AppendFormat("<a title='Search: {0} Character' href='/Cards/Search?Sphere={0}&CardType=Character' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> character</a>", key);
                    break;
                case "sphere-hero":
                    innerText = (!string.IsNullOrEmpty(label) && label == "!") ? string.Empty : " hero";
                    sb.AppendFormat("<a title='Search: {0} Hero' href='/Cards/Search?Sphere={0}&CardType=Hero' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' />{1}</a>", key, innerText);
                    break;
                case "sphere-ally":
                    sb.AppendFormat("<a title='Search: {0} Ally' href='/Cards/Search?Sphere={0}&CardType=Ally' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> ally</a>", key);
                    break;
                case "sphere-event":
                    sb.AppendFormat("<a title='Search: {0} Event' href='/Cards/Search?Sphere={0}&CardType=Event' target='_blank'><img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/{0}.png' /> event</a>", key);
                    break;
                case "willpower":
                    sb.Append("<img src='/Images/willpower.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "threat":
                    sb.Append("<img src='/Images/threat.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "attack":
                    sb.Append("<img src='/Images/attack.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "defense":
                    sb.Append("<img src='/Images/defense.gif' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />");
                    break;
                case "victory":
                    sb.AppendFormat("<div class='victory-text'><a style='text-decoration:none;' href='/Cards/Search?VictoryPoints=Victory+{0}.' target='_blank' title='Victory: {0}'><span style='padding-left:4px;padding-right:4px;border-style:solid;border-width:1px;border-color:black;'>Victory {0}</span></a></div>", key);
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

        public const string SelectListSeparator = "————————————————————";
    }
}
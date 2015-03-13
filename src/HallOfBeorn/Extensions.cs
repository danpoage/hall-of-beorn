using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn
{
    public static class Extensions
    {
        public static string CardServiceKey = "cardService";

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
                .Replace("!", string.Empty);
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

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType)
        {
            return enumType.GetSelectListItems(" ", false);
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

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, string separator)
        {
            return enumType.GetSelectListItems(separator, false);
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this Type enumType, string separator, bool keepZero)
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
                    text = item.ToString().Replace("_", separator);
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

            return listItems;
        }

        public static IEnumerable<SelectListItem> GetSelectListItems(this IEnumerable<string> list)
        {
            var listItems = new List<SelectListItem>() { new SelectListItem() { Selected = true, Text = "Any", Value = "Any" } };

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

        public static List<string> SplitOnSpace(this string self)
        {
            return self.SplitOn(' ');
        }

        public static List<string> SplitOnComma(this string self)
        {
            return self.SplitOn(',');
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
            return !(string.IsNullOrEmpty(self) || self == HallOfBeorn.Models.SearchViewModel.DEFAULT_FILTER_VALUE);
        }

        public static bool CompareTo(this byte? self, HallOfBeorn.Models.NumericOperator op, string other)
        {
            if (!self.HasValue) {
                return false;
            }

            return self.Value.CompareTo(op, other);
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
    }
}
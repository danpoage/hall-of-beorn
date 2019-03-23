using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class TranslationMap
    {
        public TranslationMap()
            : this(null)
        {
        }

        public TranslationMap(Func<string, string> format)
        {
            this.format = format;
            forwardRawMap[Language.DE] = new Dictionary<string, string>();
            forwardRawMap[Language.ES] = new Dictionary<string, string>();
            forwardRawMap[Language.FR] = new Dictionary<string, string>();
            forwardNormalMap[Language.DE] = new Dictionary<string, string>();
            forwardNormalMap[Language.ES] = new Dictionary<string, string>();
            forwardNormalMap[Language.FR] = new Dictionary<string, string>();
            reverseRawMap[Language.DE] = new Dictionary<string, string>();
            reverseRawMap[Language.ES] = new Dictionary<string, string>();
            reverseRawMap[Language.FR] = new Dictionary<string, string>();
            reverseNormalMap[Language.DE] = new Dictionary<string, string>();
            reverseNormalMap[Language.ES] = new Dictionary<string, string>();
            reverseNormalMap[Language.FR] = new Dictionary<string, string>();
        }

        private readonly Func<string, string> format;

        private readonly Dictionary<Language, Dictionary<string, string>> forwardRawMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> forwardNormalMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> reverseRawMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> reverseNormalMap = new Dictionary<Language, Dictionary<string, string>>();

        public void Add<T>(Language lang, T english, string translation)
            where T: class
        {
            if (lang == Language.EN)
                return;

            var formatted = format != null ? format(english.ToString()) : english.ToString();

            var normalizedEnglish = formatted.NormalizeCaseSensitiveString();
            var normalizedTranslation = formatted.NormalizeCaseSensitiveString();

            forwardRawMap[lang][formatted] = translation;
            forwardNormalMap[lang][normalizedEnglish] = normalizedTranslation;

            reverseRawMap[lang][translation] = formatted;
            reverseNormalMap[lang][normalizedTranslation] = normalizedEnglish;
        }

        public void Add(Language lang, IEnumerable<KeyValuePair<string, string>> pairs)
        {
            foreach (var pair in pairs)
                Add(lang, pair.Key, pair.Value);
        }

        public string GetTranslation(Language lang, string english)
        {
            if (lang == Language.EN)
                return english;

            return forwardRawMap[lang].ContainsKey(english) ?
                forwardNormalMap[lang][english]
                : english;
        }

        public string GetNormalizedTranslation(Language lang, string english)
        {
            var norm = english.NormalizeCaseSensitiveString();

            if (lang == Language.EN)
                return norm;

            return forwardNormalMap[lang].ContainsKey(norm) ?
                forwardNormalMap[lang][norm]
                : norm;
        }

        public string GetEnglish(Language lang, string translation)
        {
            if (lang == Language.EN)
                return translation;

            return reverseRawMap.ContainsKey(lang) && reverseRawMap[lang].ContainsKey(translation) ?
                reverseRawMap[lang][translation]
                : translation;
        }

        public string GetNormalizedEnglish(Language lang, string translation)
        {
            var norm = translation.NormalizeCaseSensitiveString();

            if (lang == Language.EN)
                return norm;

            return reverseNormalMap.ContainsKey(lang) && reverseNormalMap[lang].ContainsKey(norm) ?
                reverseNormalMap[lang][norm]
                : norm;
        }
    }
}
using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public abstract class TranslationBase 
        : ITranslation
    {
        protected TranslationBase(Language lang)
        {
            Lang = lang;

            SafeMap(cardTypeNames, AddCardTypeNames());
            SafeMap(keywords, AddKeywords());
            SafeMap(titles, AddTitles());
            SafeMap(traits, AddTraits());
        }

        private readonly Dictionary<string, string> cardTypeNames = new Dictionary<string, string>();
        private readonly Dictionary<string, string> keywords = new Dictionary<string, string>();
        private readonly Dictionary<string, string> titles = new Dictionary<string, string>();
        private readonly Dictionary<string, string> traits = new Dictionary<string, string>();

        protected static void SafeMap(Dictionary<string, string> map, Dictionary<string, string> translations)
        {
            foreach (var pair in translations)
            {
                if (map.ContainsKey(pair.Key))
                {
                    continue;
                }

                map[pair.Key] = pair.Value;
            }
        }

        protected abstract Dictionary<string, string> AddCardTypeNames();
        protected abstract Dictionary<string, string> AddKeywords();
        protected abstract Dictionary<string, string> AddTitles();
        protected abstract Dictionary<string, string> AddTraits();

        public Language Lang
        {
            get;
            private set;
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return cardTypeNames;
        }

        public Dictionary<string, string> Keywords()
        {
            return keywords;
        }

        public Dictionary<string, string> Titles()
        {
            return titles;
        }

        public Dictionary<string, string> Traits()
        {
            return traits;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class TranslationService : ITranslationService
    {
        public TranslationService()
        {
            cardTypeNameMap.Add(Language.DE, new Dictionary<string, string> {
                { "Hero", "Held" },
                { "Ally", "Verbündeter" },
                { "Attachment", "Verstärkung" },
                { "Event", "Ereignis" },
                { "Enemy", "Gegner" },
            });

            keywordMap.Add(Language.DE, new Dictionary<string, string> {
                { "Sentinel.", "Schildwache." }
            });

            titleMap.Add(Language.DE, new Dictionary<string, string> {
                { "Guard of the Citadel", "Wächter der Veste" }
            });

            traitMap.Add(Language.DE, new Dictionary<string, string> {
                { "Noble.", "Adlig." },
                { "Ranger.", "Waldläufer." },
                { "Warrior.", "Krieger." }
            });
        }

        //private readonly Language defaultLang = Language.EN;

        private readonly Dictionary<Language, Dictionary<string, string>> cardTypeNameMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> keywordMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> titleMap = new Dictionary<Language, Dictionary<string, string>>();
        private readonly Dictionary<Language, Dictionary<string, string>> traitMap = new Dictionary<Language, Dictionary<string, string>>();
        

        public string CardTypeName(Language lang, CardType type)
        {
            var name = type.ToString().Replace('_', '-');

            return cardTypeNameMap.ContainsKey(lang) && cardTypeNameMap[lang].ContainsKey(name) ?
                cardTypeNameMap[lang][name]
                : name;
        }

        public string Keyword(Language lang, string keyword)
        {
            return keywordMap.ContainsKey(lang) && keywordMap[lang].ContainsKey(keyword) ?
                keywordMap[lang][keyword]
                : keyword;
        }

        public string Title(Language lang, string title)
        {
            return titleMap.ContainsKey(lang) && titleMap[lang].ContainsKey(title) ?
                titleMap[lang][title]
                : title;
        }

        public string Trait(Language lang, string trait)
        {
            return traitMap.ContainsKey(lang) && traitMap[lang].ContainsKey(trait) ?
                traitMap[lang][trait]
                : trait;
        }
    }
}
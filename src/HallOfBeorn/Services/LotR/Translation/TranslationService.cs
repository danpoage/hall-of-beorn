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
            foreach (var translation in translations)
            {
                cardTypeNameMap.Add(translation.Lang, translation.CardTypeNames());
                keywordMap.Add(translation.Lang, translation.Keywords());
                titleMap.Add(translation.Lang, translation.Titles());
                traitMap.Add(translation.Lang, translation.Traits());
            }
        }

        private readonly List<ITranslation> translations = new List<ITranslation> { 
            new FrenchTranslation(),
            new GermanTranslation(), 
            new ItalianTranslation(),
            new PolishTranslation(),
            new SpanishTranslation() 
        };

        private readonly TranslationMap cardTypeNameMap = new TranslationMap((s) => s.Replace('_', '-'));
        private readonly TranslationMap keywordMap = new TranslationMap();
        private readonly TranslationMap titleMap = new TranslationMap();
        private readonly TranslationMap traitMap = new TranslationMap();

        private void InitializeSpanish()
        {
        }

        public string EnglishCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetEnglish(lang, Enum.GetName(typeof(CardType), type));
        }

        public string EnglishCardTypeName(Language lang, string cardTypeName)
        {
            return cardTypeNameMap.GetEnglish(lang, cardTypeName);
        }

        public string EnglishKeyword(Language lang, string keyword)
        {
            return keywordMap.GetEnglish(lang, keyword);
        }

        public string EnglishTitle(Language lang, string title)
        {
            return titleMap.GetEnglish(lang, title);
        }

        public string EnglishTrait(Language lang, string trait)
        {
            return traitMap.GetEnglish(lang, trait);
        }

        public string TranslateCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetTranslation(lang, type.ToString().Replace("_", "-"));
        }

        public string TranslateCardTypeName(Language lang, string typeName)
        {
            return cardTypeNameMap.GetTranslation(lang, typeName.Replace("_", "-"));
        }

        public string TranslateKeyword(Language lang, string keyword)
        {
            return keywordMap.GetTranslation(lang, keyword);
        }

        public string TranslateTitle(Language lang, string title)
        {
            return titleMap.GetTranslation(lang, title);
        }

        public string TranslateTrait(Language lang, string trait)
        {
            return traitMap.GetTranslation(lang, trait);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Translation
{
    public interface ITranslationService
    {
        string EnglishCardTypeName(Language lang, CardType type);
        string EnglishCardTypeName(Language lang, string typeName);
        string EnglishKeyword(Language lang, string keyword);
        string EnglishTitle(Language lang, string title);
        string EnglishTrait(Language lang, string trait);
        string TranslateCardTypeName(Language lang, CardType type);
        string TranslateCardTypeName(Language lang, string typeName);
        string TranslateKeyword(Language lang, string keyword);
        string TranslateTitle(Language lang, string title);
        string TranslateTrait(Language lang, string trait);
    }
}

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
        string EnglishKeyword(Language lang, string keyord);
        string EnglishTitle(Language lang, string title);
        string EnglishTrait(Language lang, string trait);
        string TranslateCardTypeName(Language lang, CardType type);
        string TranslateKeyword(Language lang, string keyord);
        string TranslateTitle(Language lang, string title);
        string TranslateTrait(Language lang, string trait);
    }
}

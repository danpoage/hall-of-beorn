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
        string CardTypeName(Language lang, CardType type);
        string Keyword(Language lang, string keyord);
        string Title(Language lang, string title);
        string Trait(Language lang, string trait);
    }
}

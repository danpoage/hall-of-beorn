using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public interface ITranslation
    {
        Language Lang { get; }
        Dictionary<string, string> CardTypeNames();
        Dictionary<string, string> Keywords();
        Dictionary<string, string> Titles();
        Dictionary<string, string> Traits();
    }
}

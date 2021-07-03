using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Services.LotR.Translation.ES
{
    public class SpanishTitles
    {
        private readonly Dictionary<string, string> titleMap = new Dictionary<string, string>();

        public string Translate(string english)
        {
            return titleMap.ContainsKey(english)
                ? titleMap[english]
                : null;
        }
    }
}
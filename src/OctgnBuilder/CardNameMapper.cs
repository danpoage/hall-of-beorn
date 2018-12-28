using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public class CardNameMapper : NameMapperBase
    {
        public CardNameMapper()
        {
        }

        private readonly Dictionary<string, string> _map = new Dictionary<string, string>();

        public string MapName(string cardName)
        {
            if (string.IsNullOrEmpty(cardName))
                return cardName;

            foreach (var token in _tokenMap.Keys)
            {
                cardName = cardName.Replace(token, _tokenMap[token]);
            }
            
            return _map.ContainsKey(cardName) ?
                _map[cardName]
                : cardName.Trim();
        }
    }
}

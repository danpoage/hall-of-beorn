using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public class SetNameMapper : NameMapperBase
    {
        public SetNameMapper()
        {
            _excluded.Add("The Hobbit - Over Hill and Under Hill - Nightmare");
            _excludedPrefix.Add("Custom Set -");

            _suffixMap.Add("- Nightmare", "Nightmare");
        }

        private readonly HashSet<string> _excluded = new HashSet<string>();
        private readonly HashSet<string> _excludedPrefix = new HashSet<string>();
        private readonly Dictionary<string, string> _suffixMap = new Dictionary<string, string>();

        public bool IsExcluded(string setName)
        {
            if (string.IsNullOrEmpty(setName))
                return true;

            foreach (var prefix in _excludedPrefix)
            {
                if (setName.StartsWith(prefix))
                    return true;
            }
            
            return _excluded.Contains(setName);
        }

        public string MapName(string setName, string setId)
        {
            if (string.IsNullOrEmpty(setName))
                return setName;

            foreach (var token in _tokenMap.Keys)
            {
                setName = setName.Replace(token, _tokenMap[token]);
            }
            
            foreach (var suffix in _suffixMap.Keys)
            {
                if (setName.EndsWith(suffix))
                    return setName.Replace(suffix, _suffixMap[suffix]);
            }

            return setName.Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public abstract class NameMapperBase
    {
        protected NameMapperBase()
        {
            _tokenMap.Add("H ma", "Háma");
            _tokenMap.Add("Gorn kh", "Gornákh");
            _tokenMap.Add("Grishn kh", "Grishnákh");
            _tokenMap.Add("ƒ", "â");
            _tokenMap.Add("„", "ä");
            _tokenMap.Add("‚", "é");
            _tokenMap.Add("‰", "ë");
            _tokenMap.Add("¡", "í");
            _tokenMap.Add("Œ", "î");
            _tokenMap.Add("¢", "ó");
            _tokenMap.Add("£", "ú");
            _tokenMap.Add("–", "û");
            _tokenMap.Add(" ", " ");
        }

        protected readonly Dictionary<string, string> _tokenMap = new Dictionary<string, string>();
    }
}

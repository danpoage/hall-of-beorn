using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Services.LotR.Octgn
{
    public interface IOctgnService
    {
        string GetCardOctgnGuid(string slug);
        string GetCardSlug(string octgnGuid);
        string GetSetOctgnGuid(string setName);
        string GetSetName(string octgnGuid);
    }
}

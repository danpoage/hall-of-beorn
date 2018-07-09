using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Search
{
    public interface IFilterService
    {
        IComponent GetFilter(string name, string value, bool isNegation);
    }
}
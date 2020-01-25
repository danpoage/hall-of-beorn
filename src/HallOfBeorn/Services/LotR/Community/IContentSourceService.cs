using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Community
{
    public interface IContentSourceService
    {
        ICreator GetContentSource(string slug);
        IEnumerable<ICreator> AllContentSources();
    }
}

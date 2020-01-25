using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Community
{
    public interface IContentSourceService
    {
        IContentSource GetContentSource(string slug);
        IEnumerable<IContentSource> AllContentSources();
    }
}

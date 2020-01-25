using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public interface IContentSource
    {
        string Name { get; }
        string Url { get; }
        IEnumerable<ILink> Links();
    }
}

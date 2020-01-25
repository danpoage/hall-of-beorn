using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public interface ICreator
    {
        string Name { get; }
        string SiteUrl { get; }
        IEnumerable<ILink> Links();
    }
}

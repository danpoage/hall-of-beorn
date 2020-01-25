using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public interface ICreator
    {
        string Name { get; }
        string SiteUrl { get; }
        string FeedUrl { get; }
        IEnumerable<ILink> Links();
    }
}

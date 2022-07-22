using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Community
{
    public interface ICreatorService
    {
        ICreator GetCreator(string slug);
        ICreator GetCreator(LinkType type);
        IEnumerable<ICreator> Creators();
        IEnumerable<ICreator> Podcasts();
        IEnumerable<ICreator> Blogs();
        IEnumerable<ICreator> Channels();
    }
}

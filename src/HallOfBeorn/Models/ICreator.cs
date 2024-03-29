﻿using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public interface ICreator
    {
        string Name { get; }
        string SiteUrl { get; }
        string FeedUrl { get; }
        LinkType DefaultLinkType { get; }
        IEnumerable<ILink> Links();
        IEnumerable<ILink> GetLinks(string cardSlug);
        void AssociateCardToUrl(string cardSlug, string url);
    }
}

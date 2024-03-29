﻿using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Links
{
    public interface ILinkService
    {
        IEnumerable<ILink> Links();
        IEnumerable<ILink> GetLinks(string slug);
        IEnumerable<ILink> GetLinks(LinkType type, IEnumerable<string> labels);
        IEnumerable<ILink> GetCharacterLinks(string name);
        bool LinksToCard(string name, string slug);
        bool HasCreator(string slug, string title, string creator);
    }
}

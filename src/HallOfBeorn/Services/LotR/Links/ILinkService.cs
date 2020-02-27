using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Links
{
    public interface ILinkService
    {
        IEnumerable<ILink> GetLinks(string slug);
        IEnumerable<ILink> GetCharacterLinks(string name);
    }
}

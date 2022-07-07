using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public interface ICharacterRepository
    {
        bool Exists(string name);
        Character Lookup(string name);
        IEnumerable<Character> All();
        bool IncludesCard(string name, string cardTitle, string cardSlug, Func<string, IEnumerable<ILink>> getLinksByName);
    }
}

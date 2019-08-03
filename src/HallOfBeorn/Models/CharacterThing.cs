using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public abstract class CharacterThing : Character
    {
        public CharacterThing(string name, string fullName, string type)
            : base(name, fullName, type)
        {
            Type = CharacterType.Thing;
        }
    }
}
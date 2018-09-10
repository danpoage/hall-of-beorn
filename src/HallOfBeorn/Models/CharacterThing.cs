using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public abstract class CharacterThing : Character
    {
        public CharacterThing(string name, string fullName)
            : base(name, fullName, string.Empty)
        {
            Type = CharacterType.Thing;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class CharacterPlace : CharacterGroup
    {
        protected CharacterPlace(string name, string fullName)
            : base(name, fullName)
        {
            Type = CharacterType.Place;
        }
    }
}
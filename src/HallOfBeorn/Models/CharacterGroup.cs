using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public abstract class CharacterGroup : Character
    {
        protected CharacterGroup(string name, string fullName)
            : base(name, fullName, string.Empty)
        {
            Type = CharacterType.Group;
        }

        protected void addLeader(string name)
        {
            addCharacterLink(this.leaders, name, string.Empty);
        }

        protected void addLeader(string name, string slug)
        {
            addCharacterLink(this.leaders, name, slug);
        }

        protected void addMember(string name)
        {
            addCharacterLink(this.members, name, string.Empty);
        }

        protected void addMember(string name, string slug)
        {
            addCharacterLink(this.members, name, slug);
        }

    }
}
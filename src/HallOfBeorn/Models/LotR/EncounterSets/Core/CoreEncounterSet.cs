using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.Core
{
    public abstract class CoreEncounterSet : EncounterSet
    {
        protected CoreEncounterSet(string name)
        {
            this.Set = "Core Set";
            this.Name = name;
        }
    }
}
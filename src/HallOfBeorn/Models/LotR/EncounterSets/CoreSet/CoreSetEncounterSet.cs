using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.CoreSet
{
    public abstract class CoreSetEncounterSet : EncounterSet
    {
        protected CoreSetEncounterSet(string name)
        {
            this.Set = "Core Set";
            this.Name = name;
        }
    }
}
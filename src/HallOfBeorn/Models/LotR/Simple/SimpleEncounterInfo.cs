using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Simple
{
    public class SimpleEncounterInfo
    {
        public SimpleEncounterInfo()
        {
            IncludedEncounterSets = new List<string>();
        }

        public string EncounterSet { get; set; }
        public uint EasyModeQuantity { get; set; }
        public List<string> IncludedEncounterSets { get; private set; }
    }
}
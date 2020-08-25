using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Scenario
        : INamed
    {
        public Scenario(byte number)
        {
            Number = number;
        }

        public byte Number { get; }
        public Content Name { get; set; }
        public INamed Product { get; set; }
        public EncounterSet EncounterSet { get; set; }
        public readonly List<EncounterSet> IncludedEncounterSets = new List<EncounterSet>();
    }
}

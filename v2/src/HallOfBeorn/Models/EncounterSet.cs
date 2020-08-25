using System;

namespace HallOfBeorn.Models
{
    public class EncounterSet
        : INamed
    {
        public Content Name { get; set; }
        public INamed Product { get; set; }
    }
}

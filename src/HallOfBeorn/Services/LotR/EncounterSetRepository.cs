using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class EncounterSetRepository
    {
        public EncounterSetRepository()
        {
        }

        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();

        public IEnumerable<EncounterSet> EncounterSets()
        {
            return encounterSets;
        }
    }
}
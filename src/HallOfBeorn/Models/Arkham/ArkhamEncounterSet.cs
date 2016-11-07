using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamEncounterSet
    {
        public string Name { get; private set; }

        private static List<ArkhamEncounterSet> all = new List<ArkhamEncounterSet>();

        static ArkhamEncounterSet()
        {
            all.Add(TheGathering);
            all.Add(TheMidnightMasks);
        }

        public static List<ArkhamEncounterSet> All()
        {
            return all;
        }

        public static ArkhamEncounterSet TheGathering = new ArkhamEncounterSet { Name = "The Gathering" };
        public static ArkhamEncounterSet TheMidnightMasks = new ArkhamEncounterSet { Name = "The Midnight Masks" };
    }
}
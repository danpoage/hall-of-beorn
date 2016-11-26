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
            all.Add(TheDevourerBelow);

            all.Add(CurseOfTheRougarou);
            all.Add(TheBayou);
        }

        public static List<ArkhamEncounterSet> All()
        {
            return all;
        }

        public static ArkhamEncounterSet TheGathering = new ArkhamEncounterSet { Name = "The Gathering" };
        public static ArkhamEncounterSet TheMidnightMasks = new ArkhamEncounterSet { Name = "The Midnight Masks" };
        public static ArkhamEncounterSet TheDevourerBelow = new ArkhamEncounterSet { Name = "The Devourer Below" };
        public static ArkhamEncounterSet CultOfUmordhoth = new ArkhamEncounterSet { Name = "Cult of Umordhoth" };

        public static ArkhamEncounterSet CurseOfTheRougarou = new ArkhamEncounterSet { Name = "Curse of the Rougarou" };
        public static ArkhamEncounterSet TheBayou = new ArkhamEncounterSet { Name = "The Bayou" };
    }
}
using System;
using System.Collections.Generic;

namespace HallOfBeorn.Data
{
    public static class EncounterSets
    {
        public static IReadOnlyList<string> All()
        {
            return new List<string>
            {
                PassageThroughMirkwood,
                JourneyAlongTheAnduin,
                EscapeFromDolGuldur,
                DolGuldurOrcs,
                SauronsReach,
                SpidersOfMirkwood,
                Wilderlands,
            };
        }

        public const string PassageThroughMirkwood = "Passage Through Mirkwood";
        public const string JourneyAlongTheAnduin = "Journey Along the Anduin";
        public const string JourneyDownTheAnduin = "Journey Down the Anduin"; //Alternate Name
        public const string EscapeFromDolGuldur = "Escape from Dol Guldur";
        public const string DolGuldurOrcs = "Dol Guldur Orcs";
        public const string SauronsReach = "Sauron's Reach";
        public const string SpidersOfMirkwood = "Spiders of Mirkwood";
        public const string Wilderlands = "Wilderlands";
        public const string TheHuntForGollum = "The Hunt for Gollum";
    }
}

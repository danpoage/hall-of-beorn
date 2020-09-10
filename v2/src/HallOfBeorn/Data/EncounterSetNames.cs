using System;
using System.Collections.Generic;

namespace HallOfBeorn.Data
{
    public static class EncounterSetNames
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

        public const string IntoThePit = "Into the Pit";
        public const string TheSeventhLevel = "The Seventh Level";
        public const string FlightFromMoria = "Flight from Moria";
        public const string PlunderingGoblins = "Plundering Goblins";
        public const string TwistsAndTurns = "Twists and Turns";
        public const string DeepsOfMoria = "Deeps of Moria";
        public const string HazardsOfThePit = "Hazards of the Pit";
        public const string MistyMountains = "Misty Mountains";
        public const string GoblinsOfTheDeep = "Goblins of the Deep";

        public const string AShadowOfThePast = "A Shadow of the Past";
        public const string Hunted = "Hunted";
        public const string TheRing = "The Ring";
        public const string TheBlackRiders = "The Black Riders";
        public const string TheHuntForGollumNightmare = "The Hunt for Gollum Nightmare";


    }
}

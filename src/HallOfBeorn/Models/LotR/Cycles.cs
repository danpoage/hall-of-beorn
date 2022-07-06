using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public static class Cycles
    {
        static Cycles()
        {
            all.Add(ShadowsOfMirkwood);
            all.Add(Dwarrowdelf);
            all.Add(AgaintTheShadow);
            all.Add(TheRingMaker);
            all.Add(AngmarAwakened);
            all.Add(DreamChaser);
            all.Add(Haradrim);
            all.Add(EredMithrin);
            all.Add(VengeanceOfMordor);
            all.Add(TheHobbit);
            all.Add(TheLordOfTheRings);
            all.Add(DoomMastered);
            all.Add(OathsOfTheRohirrim);
        }

        private static readonly List<string> all = new List<string>();

        public static readonly string ShadowsOfMirkwood = "Shadows of Mirkwood";
        public static readonly string Dwarrowdelf = "Dwarrowdelf";
        public static readonly string AgaintTheShadow = "Against the Shadow";
        public static readonly string TheRingMaker = "The Ring-maker";
        public static readonly string AngmarAwakened = "Angmar Awakened";
        public static readonly string DreamChaser = "Dream-chaser";
        public static readonly string Haradrim = "Haradrim";
        public static readonly string EredMithrin = "Ered Mithrin";
        public static readonly string VengeanceOfMordor = "Vengeance of Mordor";
        public static readonly string TheHobbit = "The Hobbit";
        public static readonly string TheLordOfTheRings = "The Lord of the Rings";
        public static readonly string DoomMastered = "Doom Mastered";
        public static readonly string OathsOfTheRohirrim = "Oaths of the Rohirrim";

        public static IEnumerable<string> All()
        {
            return all;
        }
    }
}
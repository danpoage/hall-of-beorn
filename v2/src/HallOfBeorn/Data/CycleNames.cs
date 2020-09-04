using System;
using System.Collections.Generic;

namespace HallOfBeorn.Data
{
    public static class CycleNames
    {
        public static IReadOnlyList<string> All()
        {
            return new List<string>
            {
                ShadowsOfMirkwood,
            };
        }

        public const string ShadowsOfMirkwood = "Shadows of Mirkwood";
    }
}

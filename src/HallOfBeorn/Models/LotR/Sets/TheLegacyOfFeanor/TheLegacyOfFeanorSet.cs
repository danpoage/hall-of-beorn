using System;

namespace HallOfBeorn.Models.LotR.Sets.TheLegacyOfFeanor
{
    public static class TheLegacyOfFeanorSet
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("The Legacy of Fëanor", "LoF", Models.SetType.The_Legacy_of_Feanor, Cycles.TheLegacyOfFeanor, 1);

            return cs;
        }
    }
}
using System;

namespace HallOfBeorn.Models.LotR.Sets.TheLegacyOfFeanor
{
    public static class BetrayingTheFalathrimSet
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("Betraying the Falathrim", "BTF", SetType.The_Legacy_of_Feanor, Cycles.TheLegacyOfFeanor, 2);

            return cs;
        }
    }
}
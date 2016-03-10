using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheAntleredCrownNightmare : CardSet
    {
        private const string setName = "The Antlered Crown Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TACN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2073;
        }
    }
}
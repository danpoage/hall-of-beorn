using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class CelebrimborsSecretNightmare : CardSet
    {
        private const string setName = "Celebrimbor's Secret Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2072;
        }
    }
}
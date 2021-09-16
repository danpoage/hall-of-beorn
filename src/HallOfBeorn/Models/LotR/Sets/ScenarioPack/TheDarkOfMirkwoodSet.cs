using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ScenarioPack
{
    public class TheDarkOfMirkwoodSet
        : CardSet
    {
        public const string setName = "The Dark of Mirkwood";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDoM";
            SetType = Models.SetType.Scenario_Pack;
            Cycle = "Scenario Pack";
            Number = 4002;
        }
    }
}
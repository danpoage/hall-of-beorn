﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBattleOfCarnDumProduct : Product
    {
        public TheBattleOfCarnDumProduct()
            : base("The Battle of Carn Dûm", "MEC43", ImageType.Jpg, new DateTime(2015, 11, 6))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC43.pdf";

            AddCardSet(CardSet.TheBattleOfCarnDum);

            AddScenario(Scenario.TheBattleOfCarnDum);
        }
    }
}
﻿using System;

namespace HallOfBeorn.Models.LotR.Products.Starter
{
    public class TwoPlayerLimitedEditionStarterProduct : Product
    {
        public TwoPlayerLimitedEditionStarterProduct()
            : base("Two-Player Limited Edition Starter", "MEC73", ImageType.Jpg, new DateTime(2018, 8, 28))
        {
            AddCardSet(CardSet.TwoPlayerLimitedEditionStarter);

            AddScenario(Scenario.TheOath);
            AddScenario(Scenario.TheCavesOfNibinDum);
        }
    }
}
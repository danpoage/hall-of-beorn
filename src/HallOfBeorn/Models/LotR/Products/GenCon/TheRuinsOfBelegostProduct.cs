﻿using System;

namespace HallOfBeorn.Models.LotR.Products.GenCon
{
    public class TheRuinsOfBelegostProduct : Product
    {
        public TheRuinsOfBelegostProduct()
            : base("The Ruins of Belegost", "OP014", ImageType.Jpg, new DateTime(2015, 8, 2))
        {
            AddCardSet(CardSet.TheRuinsOfBelegost);

            AddScenario(Scenario.TheRuinsOfBelegost);
        }
    }
}
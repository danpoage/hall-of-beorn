﻿using System;

namespace HallOfBeorn.Models.LotR.Products.Fellowship
{
    public class TheSiegeOfAnnuminasProduct : Product
    {
        public TheSiegeOfAnnuminasProduct()
            : base("The Siege of Annúminas", "OP016", ImageType.Jpg, new DateTime(2017, 3, 1))
        {
            AddCardSet(CardSet.TheSiegeOfAnnuminas);

            AddScenario(Scenario.TheSiegeOfAnnuminas);
        }
    }
}
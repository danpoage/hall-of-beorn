﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class UnderTheAshMountainsProduct : Product
    {
        public UnderTheAshMountainsProduct()
            : base("Under the Ash Mountains", "MEC81", ImageType.Jpg, new DateTime(2020, 6, 5))
        {
            AddCardSet(CardSet.UnderTheAshMountains);
            AddScenario(new Scenarios.VengeanceOfMordor.UnderTheAshMountainsScenario());
        }
    }
}
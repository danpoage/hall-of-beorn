﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheTreasonOfSarumanNightmareProduct : Product
    {
        public TheTreasonOfSarumanNightmareProduct()
            : base("The Treason of Saruman Nightmare", "MEN36", ImageType.Jpg, new DateTime(2016, 7, 1))
        {
            AddCardSet(CardSet.TheUrukHaiNightmare);
            AddCardSet(CardSet.HelmsDeepNightmare);
            AddCardSet(CardSet.TheRoadToIsengardNightmare);
        }
    }
}
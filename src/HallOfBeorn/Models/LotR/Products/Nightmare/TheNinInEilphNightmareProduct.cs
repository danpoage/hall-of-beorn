﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheNinInEilphNightmareProduct : Product
    {
        public TheNinInEilphNightmareProduct()
            : base("The Nîn-in-Eilph Nightmare", "MEN32", ImageType.Jpg, new DateTime(2016, 3, 15))
        {
            AddCardSet(CardSet.TheNinInEilphNightmare);
        }
    }
}
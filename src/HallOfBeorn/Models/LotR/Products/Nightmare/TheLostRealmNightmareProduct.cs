﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheLostRealmNightmareProduct : Product
    {
        public TheLostRealmNightmareProduct()
            : base("The Lost Realm Nightmare", "MEN35", ImageType.Jpg, new DateTime(2016, 6, 2))
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.IntrudersInChetwoodNightmare);
            AddCardSet(CardSet.TheWeatherHillsNightmare);
            AddCardSet(CardSet.DeadmensDikeNightmare);
        }
    }
}
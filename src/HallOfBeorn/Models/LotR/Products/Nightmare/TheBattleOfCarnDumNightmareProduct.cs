﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheBattleOfCarnDumNightmareProduct : Product
    {
        public TheBattleOfCarnDumNightmareProduct()
            : base("The Battle of Carn Dûm Nightmare", "MEN41", ImageType.Jpg, new DateTime(2017, 1, 1))
        {
            AddCardSet(CardSet.TheBattleOfCarnDumNightmare);
        }
    }
}
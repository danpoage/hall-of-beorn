﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class EscapeFromMountGramNightmareProduct : Product
    {
        public EscapeFromMountGramNightmareProduct()
            : base("Escape from Mount Gram Nightmare", "MEN38", ImageType.Jpg, new DateTime(2016, 8, 15))
        {
            AddCardSet(CardSet.EscapeFromMountGramNightmare);
        }
    }
}
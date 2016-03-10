﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class CelebrimborsSecretNightmareProoduct : Product
    {
        public CelebrimborsSecretNightmareProoduct()
            : base("Celebrimbor's Secret Nightmare", "MEN33", ImageType.Jpg)
        {
            AddCardSet(CardSet.CelebrimborsSecretNightmare);
        }
    }
}
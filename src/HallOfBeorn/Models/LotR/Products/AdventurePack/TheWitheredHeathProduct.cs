﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWitheredHeathProduct : Product
    {
        public TheWitheredHeathProduct()
            : base("The Withered Heath", "MEC66", ImageType.Jpg, new DateTime(2018, 7, 1))
        {
            AddCardSet(CardSet.TheWitheredHeath);
        }
    }
}
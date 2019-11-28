using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheDrownedRuinsNightmareProduct : Product
    {
        public TheDrownedRuinsNightmareProduct()
            : base("The Drowned Ruins Nightmare", "MEN48", ImageType.Jpg, new DateTime(2018, 3, 3))
        {
            AddCardSet(CardSet.TheDrownedRuinsNightmare);
        }
    }
}
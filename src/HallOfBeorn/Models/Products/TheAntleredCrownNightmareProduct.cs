using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheAntleredCrownNightmareProduct : Product
    {
        public TheAntleredCrownNightmareProduct()
            : base("The Antlered Crown Nightmare", "MEN34", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheAntleredCrownNightmare);
        }
    }
}
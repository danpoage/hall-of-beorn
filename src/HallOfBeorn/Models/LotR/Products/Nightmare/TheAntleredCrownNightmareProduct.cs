using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheAntleredCrownNightmareProduct : Product
    {
        public TheAntleredCrownNightmareProduct()
            : base("The Antlered Crown Nightmare", "MEN34", ImageType.Jpg, new DateTime(2016, 3, 15))
        {
            AddCardSet(CardSet.TheAntleredCrownNightmare);
        }
    }
}
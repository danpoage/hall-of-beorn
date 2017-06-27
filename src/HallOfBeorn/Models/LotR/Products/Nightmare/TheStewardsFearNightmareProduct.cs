using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheStewardsFearNightmareProduct : Product
    {
        public TheStewardsFearNightmareProduct()
            : base("The Steward's Fear Nightmare Deck", "MEN22", ImageType.Jpg, new DateTime(2015, 2, 12))
        {
            AddCardSet(CardSet.TheStewardsFearNightmare);
        }
    }
}
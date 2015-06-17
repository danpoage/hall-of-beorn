using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheStewardsFearNightmareProduct : Product
    {
        public TheStewardsFearNightmareProduct()
            : base("The Steward's Fear Nightmare Deck", "MEN22", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheStewardsFearNightmare);
        }
    }
}
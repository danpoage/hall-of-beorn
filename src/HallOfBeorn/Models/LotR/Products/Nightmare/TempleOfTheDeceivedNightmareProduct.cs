using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TempleOfTheDeceivedNightmareProduct : Product
    {
        public TempleOfTheDeceivedNightmareProduct()
            : base("Temple of the Deceived Nightmare", "MEN47", ImageType.Jpg)
        {
            AddCardSet(CardSet.TempleOfTheDeceivedNightmare);
        }
    }
}
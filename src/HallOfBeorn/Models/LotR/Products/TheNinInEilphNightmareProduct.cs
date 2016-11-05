using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheNinInEilphNightmareProduct : Product
    {
        public TheNinInEilphNightmareProduct()
            : base("The Nîn-in-Eilph Nightmare", "MEN32", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheNinInEilphNightmare);
        }
    }
}
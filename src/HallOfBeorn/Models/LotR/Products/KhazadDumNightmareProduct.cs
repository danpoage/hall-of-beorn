using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class KhazadDumNightmareProduct : Product
    {
        public KhazadDumNightmareProduct()
            : base("Khazad-dûm Nightmare Decks", "MEN10", ImageType.Png, new DateTime(2014, 6, 2))
        {
            IsPremier = true;

            AddCardSet(CardSet.IntoThePitNightmare);
            AddCardSet(CardSet.TheSeventhLevelNightmare);
            AddCardSet(CardSet.FlightFromMoriaNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class KhazadDumNightmareProduct : Product
    {
        public KhazadDumNightmareProduct()
            : base("Khazad-dûm Nightmare Decks", "MEN10", ImageType.Png)
        {
            IsPremier = true;

            CardSets.Add(CardSet.IntoThePitNightmare);
            CardSets.Add(CardSet.TheSeventhLevelNightmare);
            CardSets.Add(CardSet.FlightFromMoriaNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheWatcherInTheWaterNightmareProduct : Product
    {
        public TheWatcherInTheWaterNightmareProduct()
            : base("The Watcher in the Water Nightmare Deck", "MEN13", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheWatcherInTheWaterNightmare);
        }
    }
}
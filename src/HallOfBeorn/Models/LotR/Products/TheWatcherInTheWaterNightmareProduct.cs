using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheWatcherInTheWaterNightmareProduct : Product
    {
        public TheWatcherInTheWaterNightmareProduct()
            : base("The Watcher in the Water Nightmare Deck", "MEN13", ImageType.Jpg, new DateTime(2014, 8, 27))
        {
            AddCardSet(CardSet.TheWatcherInTheWaterNightmare);
        }
    }
}
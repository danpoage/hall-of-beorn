using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class RoadToRivendellNightmareProduct : Product
    {
        public RoadToRivendellNightmareProduct()
            : base("Road to Rivendell Nightmare Deck", "MEN12", ImageType.Jpg)
        {
            AddCardSet(CardSet.RoadToRivendellNightmare);
        }
    }
}
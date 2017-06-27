using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class RoadToRivendellNightmareProduct : Product
    {
        public RoadToRivendellNightmareProduct()
            : base("Road to Rivendell Nightmare Deck", "MEN12", ImageType.Jpg, new DateTime(2014, 8, 27))
        {
            AddCardSet(CardSet.RoadToRivendellNightmare);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheHuntForGollumNightmareProduct : Product
    {
        public TheHuntForGollumNightmareProduct()
            : base("The Hunt for Gollum Nightmare Deck", "MEN04", ImageType.Jpg, new DateTime(2013, 12, 30))
        {
            AddCardSet(CardSet.TheHuntForGollumNightmare);
        }
    }
}
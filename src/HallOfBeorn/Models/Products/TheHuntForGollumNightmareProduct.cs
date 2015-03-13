using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHuntForGollumNightmareProduct : Product
    {
        public TheHuntForGollumNightmareProduct()
            : base("The Hunt for Gollum Nightmare Deck", "MEN04", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheHuntForGollumNightmare);
        }
    }
}